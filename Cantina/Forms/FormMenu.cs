using Cantina.Data;
using Cantina.Models;
using Newtonsoft.Json;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

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

        private void ConfigurarDataGridView()
        {
            dataGridViewMenus.AutoGenerateColumns = false;
            dataGridViewMenus.Columns.Clear();

            // Configuração das colunas básicas do DataGridView
            dataGridViewMenus.Columns.Add("Id", "ID");
            dataGridViewMenus.Columns.Add("DataHora", "Data");
            dataGridViewMenus.Columns.Add("QtdDisponivel", "Quantidade");
            dataGridViewMenus.Columns.Add("PrecoEstudante", "Preço Estudante");
            dataGridViewMenus.Columns.Add("PrecoProfessor", "Preço Professor");
            dataGridViewMenus.Columns.Add("Pratos", "Pratos");
            dataGridViewMenus.Columns.Add("Extras", "Extras");
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

            // Associar o prato selecionado ao menu, se ainda não estiver associado
            var selectedPratoId = (int)comboBoxPratos.SelectedValue;
            if (!menu.Pratos.Any(p => p.Id == selectedPratoId))
            {
                var selectedPrato = _context.Pratos.Find(selectedPratoId);
                if (selectedPrato != null)
                {
                    menu.Pratos.Add(selectedPrato);
                }
            }

            // Associar o extra selecionado ao menu, se ainda não estiver associado
            var selectedExtraId = (int)comboBoxExtras.SelectedValue;
            if (!menu.Extras.Any(extra => extra.Id == selectedExtraId))
            {
                var selectedExtra = _context.Extras.Find(selectedExtraId);
                if (selectedExtra != null)
                {
                    menu.Extras.Add(selectedExtra);
                }
            }

            _context.SaveChanges();
            LoadMenus();

            MessageBox.Show("Menu salvo com sucesso!");
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
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridViewMenus);

                row.Cells[0].Value = menu.Id;
                row.Cells[1].Value = menu.DataHora.ToString("dd/MM/yyyy HH:mm:ss");
                row.Cells[2].Value = menu.QtdDisponivel;
                row.Cells[3].Value = menu.PrecoEstudante;
                row.Cells[4].Value = menu.PrecoProfessor;
                row.Cells[5].Value = string.Join(", ", menu.Pratos.Select(p => p.Descricao));
                row.Cells[6].Value = string.Join(", ", menu.Extras.Select(e => e.Descricao));

                dataGridViewMenus.Rows.Add(row);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewMenus.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um menu para editar.");
                return;
            }

            int menuId = (int)dataGridViewMenus.SelectedRows[0].Cells["Id"].Value;
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
                MessageBox.Show("Erro ao excluir o menu. Tente novamente.");
            }
        }
        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(this);
            this.Hide();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTime.ShowUpDown = true;
        }
    }
}
