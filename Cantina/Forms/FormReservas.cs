using Cantina.Data;
using Cantina.Models;
using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Cantina.Forms
{
    public partial class FormReservas : Form
    {
        private int selectedClienteId = -1;

        public FormReservas()
        {
            InitializeComponent();
        }

        private void btnBuscarClientePorNif_Click(object sender, EventArgs e)
        {
            string nifText = textNif.Text.Trim();

            if (!int.TryParse(nifText, out int nif))
            {
                MessageBox.Show("O NIF deve ser um número válido!");
                return;
            }

            using (var context = new CantinaContext())
            {
                var cliente = context.Clientes.FirstOrDefault(c => c.NIF == nif);
                if (cliente != null)
                {
                    selectedClienteId = cliente.Id;
                    labelNomeCliente.Text = $"Nome: {cliente.Nome}";
                    labelSaldoCliente.Text = $"Saldo: {cliente.Saldo:C}";
                    MessageBox.Show($"Cliente {cliente.Nome} encontrado.");

                    // Após encontrar o cliente, carregue os menus disponíveis
                    CarregarMenusDisponiveis();
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                    selectedClienteId = -1;
                }
            }
        }

        private void CarregarMenusDisponiveis()
        {
            using (var context = new CantinaContext())
            {
                DateTime today = DateTime.Today;
                DateTime tomorrow = today.AddDays(1);

                var menus = context.Menus
                    .Where(m => m.DataHora >= today && m.DataHora < tomorrow && m.QtdDisponivel > 0)
                    .ToList();
                listBoxMenus.Items.Clear();
                foreach (var menu in menus)
                {
                    listBoxMenus.Items.Add(menu);
                }
            }
        }

        private void listBoxMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aqui você pode adicionar lógica para lidar com a seleção de menus, se necessário
        }

        private void btnReservarMenu_Click(object sender, EventArgs e)
        {
            // Aqui você pode adicionar lógica para reservar o menu selecionado
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
