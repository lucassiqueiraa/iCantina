using Cantina.Data;
using Cantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            CarregarPratosExtras();
            LoadMenus();
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
            int? menuId = dataGridViewMenus.SelectedRows.Count > 0 ? (int?)dataGridViewMenus.SelectedRows[0].Cells["Id"].Value : null;
            var selectedPrato = _context.Pratos.Find((int)comboBoxPratos.SelectedValue);
            var selectedExtra = _context.Extras.Find((int)comboBoxExtras.SelectedValue);

            if (selectedPrato == null || selectedExtra == null)
            {
                MessageBox.Show("Selecione um prato e um extra válidos.");
                return;
            }

            Models.Menu menu;
            if (menuId.HasValue)
            {
                menu = _context.Menus.Include(m => m.Pratos).Include(m => m.Extras).FirstOrDefault(m => m.Id == menuId.Value);
                menu.Pratos.Clear();
                menu.Extras.Clear();
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
            menu.Pratos.Add(selectedPrato);
            menu.Extras.Add(selectedExtra);

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

            dataGridViewMenus.DataSource = menus.Select(m => new
            {
                m.Id,
                m.DataHora,
                m.QtdDisponivel,
                m.PrecoEstudante,
                m.PrecoProfessor,
                Pratos = string.Join(", ", m.Pratos.Select(p => p.Descricao)),
                Extras = string.Join(", ", m.Extras.Select(e => e.Descricao))
            }).ToList();

            dataGridViewMenus.Columns["Id"].HeaderText = "ID";
            dataGridViewMenus.Columns["DataHora"].HeaderText = "Data";
            dataGridViewMenus.Columns["QtdDisponivel"].HeaderText = "Quantidade";
            dataGridViewMenus.Columns["PrecoEstudante"].HeaderText = "Preço Estudante";
            dataGridViewMenus.Columns["PrecoProfessor"].HeaderText = "Preço Professor";
            dataGridViewMenus.Columns["Pratos"].HeaderText = "Prato";
            dataGridViewMenus.Columns["Extras"].HeaderText = "Extra";
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
        }
    }
}
