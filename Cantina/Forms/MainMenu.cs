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

            // Configurar colunas do DataGridView
            listaMenus.Columns.Clear();
            listaMenus.Columns.Add("colCarne", "Carne");
            listaMenus.Columns.Add("colPeixe", "Peixe");
            listaMenus.Columns.Add("colVegetariano", "Vegetariano");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Limpa as informações anteriores
            listaMenus.Rows.Clear();

            // Busca os menus do banco de dados para o dia selecionado
            DateTime selectedDate = e.Start;
            var menus = GetMenusFromDatabase(selectedDate);

            // Supondo que 'menus' seja uma lista de objetos Menu
            foreach (var menu in menus)
            {
                var carne = menu.Pratos.FirstOrDefault(p => p.Tipo == "Carne");
                var peixe = menu.Pratos.FirstOrDefault(p => p.Tipo == "Peixe");
                var vegetariano = menu.Pratos.FirstOrDefault(p => p.Tipo == "Vegetariano");

                listaMenus.Rows.Add(
                    carne != null ? carne.Descricao : "",
                    peixe != null ? peixe.Descricao : "",
                    vegetariano != null ? vegetariano.Descricao : ""
                );
            }
        }


        private List<Cantina.Models.Menu> GetMenusFromDatabase(DateTime date)
        {
            using (var context = new CantinaContext())
            {
                var menus = context.Menus
                    .Include(m => m.Pratos) // Garante que os pratos sejam incluídos na consulta
                    .Include(m => m.Extras) // Garante que os extras sejam incluídos na consulta
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
           
        }
    }
}
