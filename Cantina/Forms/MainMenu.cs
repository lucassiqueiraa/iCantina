using Cantina.Data;
using Cantina.Forms;
using Cantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cantina
{
    public partial class MainMenu : Form
    {
        public string ClienteNome { get; set; }
        public MainMenu()
        {
            InitializeComponent();
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;

            // Configuração inicial do DataGridView
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            // Limpa as colunas existentes e adiciona as novas colunas necessárias
            listaMenus.Columns.Clear();

            listaMenus.Columns.Add("colId", "ID");
            listaMenus.Columns.Add("colDataHora", "Data e Hora");
            listaMenus.Columns.Add("colQtdDisponivel", "Quantidade Disponível");
            listaMenus.Columns.Add("colPrecoEstudante", "Preço Estudante");
            listaMenus.Columns.Add("colPrecoProfessor", "Preço Professor");
            listaMenus.Columns.Add("colPratos", "Pratos");
            listaMenus.Columns.Add("colExtras", "Extras");

            // Ajusta o modo de redimensionamento das colunas, se necessário
            listaMenus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Limpa as informações anteriores
            listaMenus.Rows.Clear();

            // Busca os menus do banco de dados para o dia selecionado
            DateTime selectedDate = e.Start;
            var menus = GetMenusFromDatabase(selectedDate);

            // Preenche o DataGridView com os menus encontrados
            foreach (var menu in menus)
            {
                var row = new DataGridViewRow();
                row.CreateCells(listaMenus);

                row.Cells[0].Value = menu.Id;
                row.Cells[1].Value = menu.DataHora.ToString("dd/MM/yyyy HH:mm:ss");
                row.Cells[2].Value = menu.QtdDisponivel;
                row.Cells[3].Value = menu.PrecoEstudante;
                row.Cells[4].Value = menu.PrecoProfessor;
                row.Cells[5].Value = string.Join(", ", menu.Pratos.Select(p => p.Descricao));
                row.Cells[6].Value = string.Join(", ", menu.Extras.Select(extra => extra.Descricao));

                listaMenus.Rows.Add(row);
            }
        }

        private List<Cantina.Models.Menu> GetMenusFromDatabase(DateTime date)
        {
            using (var context = new CantinaContext())
            {
                var menus = context.Menus
                    .Include(m => m.Pratos)
                    .Include(m => m.Extras)
                    .Where(m => DbFunctions.TruncateTime(m.DataHora) == date.Date)
                    .ToList();

                return menus;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Atualiza label com o nome do cliente
            funcionarioUsername.Text += ClienteNome;
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionarios formFuncionarios = new FormFuncionarios();
            formFuncionarios.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Configura o Timer
            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Atualiza a hora a cada tick
            lblHoras.Text = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormGestaoClientes formGestaoClientes = new FormGestaoClientes();
            formGestaoClientes.Show();
            this.Hide();
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
           FormExtras formExtras = new FormExtras();
           formExtras.Show();
           this.Hide();
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Hide();
        }

        private void btnMultas_Click(object sender, EventArgs e)
        {
            FormMultas formMultas = new FormMultas();
            formMultas.Show();
            this.Hide();
        }

        private void btnPratos_Click(object sender, EventArgs e)
        {
            FormPratos formPratos = new FormPratos();
            formPratos.Show();
            this.Hide();
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            FormReservas formReservas = new FormReservas();
            formReservas.Show();
            this.Hide();
        }
    }
}
