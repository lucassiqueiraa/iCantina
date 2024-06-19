using Cantina.Data;
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
    public partial class FormMultas : Form
    {
        public FormMultas()
        {
            InitializeComponent();
        }

        private void FormMultas_Load(object sender, EventArgs e)
        {
            ListarMultas();
        }
        private void ListarMultas()
        {
            try
            {
                using (var context =new CantinaContext())
                {
                    var multas = context.Multas.ToList();
                    listBoxMultas.Items.Clear();
                    foreach (var multa in multas)
                    {
                        listBoxMultas.Items.Add($"ID: {multa.Id}, Valor: {multa.Valor:C}, NumHoras: {multa.NumHoras}");
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro ao listar multas: {ex.Message}");
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();

        }
    }
}
