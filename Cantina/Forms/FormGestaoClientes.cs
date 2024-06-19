using Cantina.Data;
using Cantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cantina.Forms
{
    public partial class FormGestaoClientes : Form
    {
       // private int selectedClienteId = -1; // Adicionando esta linha para armazenar o ID do cliente selecionado

        public FormGestaoClientes()
        {
            InitializeComponent();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void btnGravarFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormEstudante formEstudante = new FormEstudante())
            {
                formEstudante.ShowDialog();
            }
            this.Show();
        }

        private void btnListarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FormProfessor formProfessor = new FormProfessor())
            {
                formProfessor.ShowDialog();
            }
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
            this.Hide();
            
        }
    }
}
