using Autenticacao.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cantina;

namespace Autenticacao
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = login_username.Text;
            string nifText = login_nif.Text;

            //Verificação de nif válido 
            if(!int.TryParse(nifText, out int nif))
            {
                MessageBox.Show("O NIF deve ser um número válido!");
                login_nif.Focus();
                return;
            }
           

            // Chama o método Authenticate no AuthController para autenticar o usuário
            if (AuthController.Authenticate(username, nif))
            {
                // Autenticação bem-sucedida, abre a tela principal do cliente
                var form = new Cantina.MainMenu();
                form.Show();
                this.Hide();
            }
            else
            {
                // Usuário não está registrado ou a senha está incorreta
                MessageBox.Show("Invalid Username or NIF");
                login_username.Text = "";
                login_nif.Text = "";
                login_username.Focus();
            }
        }
    }
}
