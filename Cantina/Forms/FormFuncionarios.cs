using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina.Forms
{
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }
        private void btnVoltarMenuPrincipal_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(this);
            this.Hide();
        }

        private void btnListarFuncionarios_Click(object sender, EventArgs e)
        {
            ListarFuncionarios();
        }

        private void ListarFuncionarios()
        {

        }

        private  void btnGravarFuncionario_Click(object sender, EventArgs e)
        {

            ///<summary>
            ///aqui vem a lógica de gravar na base de dados.
            ///</summary>

        }
        
       
    }
}
