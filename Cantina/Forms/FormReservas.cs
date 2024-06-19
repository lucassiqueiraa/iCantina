using Cantina.Data;
using Cantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

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
                var menus = context.MenusDiarios
                    .Where(m => m.Data == DateTime.Today && m.QtdDisponivel > 0)
                    .ToList();

                listBoxMenus.Items.Clear();
                foreach (var menu in menus)
                {
                    listBoxMenus.Items.Add($"{menu.Nome} - Quantidade Disponível: {menu.QtdDisponivel}");
                }
            }
        }
        private void listBoxMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void btnReservarMenu_Click(object sender, EventArgs e)
        {
        }

    }
} 

