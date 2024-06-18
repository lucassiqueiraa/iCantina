using Cantina.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
