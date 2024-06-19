using Cantina.Data;
using Cantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Cantina.Forms
{
    public partial class FormMenu : Form
    {
        private CantinaContext _context;

        public FormMenu()
        {
            InitializeComponent();
            _context = new CantinaContext();
            ConfigurarDataGridView();
            CarregarPratosExtras();
            LoadMenus();
        }

       

        public static T Clone<T>(T source)
    {
        if (Object.ReferenceEquals(source, null))
        {
            return default(T);
        }

        // Serializa o objeto para uma string JSON e depois deserializa de volta para um novo objeto.
        var deserializeSettings = new JsonSerializerSettings { ObjectCreationHandling = ObjectCreationHandling.Replace };
        return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source), deserializeSettings);
    }

        private void ConfigurarDataGridView()
        {
            dataGridViewMenus.AutoGenerateColumns = false;
            dataGridViewMenus.Columns.Clear();

            dataGridViewMenus.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Id", HeaderText = "ID", DataPropertyName = "Id" });
            dataGridViewMenus.Columns.Add(new DataGridViewTextBoxColumn() { Name = "DataHora", HeaderText = "Data", DataPropertyName = "DataHora" });
            dataGridViewMenus.Columns.Add(new DataGridViewTextBoxColumn() { Name = "QtdDisponivel", HeaderText = "Quantidade", DataPropertyName = "QtdDisponivel" });
            dataGridViewMenus.Columns.Add(new DataGridViewTextBoxColumn() { Name = "PrecoEstudante", HeaderText = "Preço Estudante", DataPropertyName = "PrecoEstudante" });
            dataGridViewMenus.Columns.Add(new DataGridViewTextBoxColumn() { Name = "PrecoProfessor", HeaderText = "Preço Professor", DataPropertyName = "PrecoProfessor" });
            dataGridViewMenus.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Pratos", HeaderText = "Prato", DataPropertyName = "Pratos" });
            dataGridViewMenus.Columns.Add(new DataGridViewTextBoxColumn() { Name = "Extras", HeaderText = "Extra", DataPropertyName = "Extras" });
        }

        private void CarregarPratosExtras()
        {
            var pratos = _context.Pratos.ToList();
            comboBoxPratos.DataSource = pratos;
            comboBoxPratos.DisplayMember = "Descricao";
            comboBoxPratos.ValueMember = "Id";

            var extras = _context.Extras.ToList();
            comboBoxExtras.DataSource = extras;
            comboBoxExtras.DisplayMember = "Descricao";
            comboBoxExtras.ValueMember = "Id";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool isEdit = dataGridViewMenus.SelectedRows.Count > 0 && dataGridViewMenus.SelectedRows[0].Cells["Id"].Value != null;

            var selectedPrato = _context.Pratos.Find((int)comboBoxPratos.SelectedValue);
            var selectedExtra = _context.Extras.Find((int)comboBoxExtras.SelectedValue);

            if (selectedPrato == null || selectedExtra == null)
            {
                MessageBox.Show("Selecione um prato e um extra válidos.");
                return;
            }

            Models.Menu menu = null;
            if (isEdit)
            {
                int menuId = (int)dataGridViewMenus.SelectedRows[0].Cells["Id"].Value;
                menu = _context.Menus.Include(m => m.Pratos).Include(m => m.Extras).FirstOrDefault(m => m.Id == menuId);

            }
            else
            {
                menu = new Models.Menu();
                _context.Menus.Add(menu);
            }

            menu.DataHora = dateTime.Value;
            menu.QtdDisponivel = (int)qtd.Value;
            menu.PrecoEstudante = decimal.Parse(txtPrecoEstudante.Text);
            menu.PrecoProfessor = decimal.Parse(txtPrecoProf.Text);

            // Clonar e adicionar o prato selecionado
            var clonedPrato = Clone(selectedPrato);
            if (!menu.Pratos.Any(p => p.Id == clonedPrato.Id))
            {
                menu.Pratos.Add(clonedPrato);
            }

            // Clonar e adicionar o extra selecionado
            var clonedExtra = Clone(selectedExtra);
            if (!menu.Extras.Any(extra => extra.Id == clonedExtra.Id))
            {
                menu.Extras.Add(clonedExtra);
            }

            _context.SaveChanges();
            LoadMenus();

            MessageBox.Show("Menu salvo com sucesso!");
        }

        // Método para clonar um objeto Prato
        private Prato Clone(Prato prato)
        {
            return new Prato
            {
                // Copie todas as propriedades necessárias aqui
                Descricao = prato.Descricao,
                // ... outras propriedades
            };
        }

        // Método para clonar um objeto Extra
        private Extra Clone(Extra extra)
        {
            return new Extra
            {
                // Copie todas as propriedades necessárias aqui
                Descricao = extra.Descricao,
                // ... outras propriedades
            };
        }


        private void LoadMenus()
        {
            var menus = _context.Menus
                .Include(m => m.Pratos)
                .Include(m => m.Extras)
                .ToList();

            dataGridViewMenus.Rows.Clear();

            foreach (var menu in menus)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridViewMenus);

                row.Cells[0].Value = menu.Id;
                row.Cells[1].Value = menu.DataHora;
                row.Cells[2].Value = menu.QtdDisponivel;
                row.Cells[3].Value = menu.PrecoEstudante;
                row.Cells[4].Value = menu.PrecoProfessor;
                row.Cells[5].Value = string.Join(", ", menu.Pratos.Select(p => p.Descricao));
                row.Cells[6].Value = string.Join(", ", menu.Extras.Select(e => e.Descricao));

                dataGridViewMenus.Rows.Add(row);
            }

            if (dataGridViewMenus.Rows.Count > 0)
            {
                dataGridViewMenus.ClearSelection();
                LimparCampos();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um menu para editar.");
                return;
            }

            var selectedRow = dataGridViewMenus.SelectedRows[0];
            if (selectedRow != null && selectedRow.Cells["Id"].Value != null)
            {
                int menuId = (int)selectedRow.Cells["Id"].Value;
                var menu = _context.Menus.Include(m => m.Pratos).Include(m => m.Extras).FirstOrDefault(m => m.Id == menuId);

                if (menu != null)
                {
                    dateTime.Value = menu.DataHora;
                    qtd.Value = menu.QtdDisponivel;
                    txtPrecoEstudante.Text = menu.PrecoEstudante.ToString();
                    txtPrecoProf.Text = menu.PrecoProfessor.ToString();
                    comboBoxPratos.SelectedValue = menu.Pratos.FirstOrDefault()?.Id;
                    comboBoxExtras.SelectedValue = menu.Extras.FirstOrDefault()?.Id;
                }
            }
            else
            {
                MessageBox.Show("Erro ao editar o menu. Tente novamente.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um menu para excluir.");
                return;
            }

            int menuId = (int)dataGridViewMenus.SelectedRows[0].Cells["Id"].Value;
            var menu = _context.Menus.Find(menuId);

            if (menu != null)
            {
                _context.Menus.Remove(menu);
                _context.SaveChanges();
                LoadMenus();
                MessageBox.Show("Menu excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Menu excluído com sucesso!");
            }
        }

        private void dataGridViewMenus_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewMenus.SelectedRows[0];
                if (selectedRow != null && selectedRow.Cells["Id"].Value != null)
                {
                    int menuId = (int)selectedRow.Cells["Id"].Value;
                    var menu = _context.Menus.Include(m => m.Pratos).Include(m => m.Extras).FirstOrDefault(m => m.Id == menuId);

                    if (menu != null)
                    {
                        dateTime.Value = menu.DataHora;
                        qtd.Value = menu.QtdDisponivel;
                        txtPrecoEstudante.Text = menu.PrecoEstudante.ToString();
                        txtPrecoProf.Text = menu.PrecoProfessor.ToString();
                        comboBoxPratos.SelectedValue = menu.Pratos.FirstOrDefault()?.Id;
                        comboBoxExtras.SelectedValue = menu.Extras.FirstOrDefault()?.Id;
                    }
                }
            }
            else
            {
                LimparCampos();
            }
        }

        private void LimparCampos()
        {
            dateTime.Value = DateTime.Now;
            qtd.Value = 0;
            txtPrecoEstudante.Clear();
            txtPrecoProf.Clear();
            comboBoxPratos.SelectedIndex = -1;
            comboBoxExtras.SelectedIndex = -1;
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(this);
            this.Hide();
        }
    }
}



