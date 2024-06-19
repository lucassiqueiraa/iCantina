using Cantina.Data;
using Cantina.Models;
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
    public partial class FormEstudante : Form
    {
        private int selectedClienteId = -1; // Adicionando esta linha para armazenar o ID do cliente selecionado

        public FormEstudante()
        {
            InitializeComponent();
        }

        private void btnGravarCliente_Click(object sender, EventArgs e)
        {
            string nome = textNome.Text.Trim();
            string nifText = textNif.Text.Trim();
            string creditoText = textAporteCredito.Text.Trim();

            // Validação básica na entrada de informações
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(nifText) || string.IsNullOrEmpty(creditoText))
            {
                MessageBox.Show("Por favor, preencha todos os campos!!");
                return;
            }
            if (!int.TryParse(nifText, out int nif))
            {
                MessageBox.Show("O NIF deve ser um número válido!");
                return;
            }
            if (!decimal.TryParse(creditoText, out decimal credito))
            {
                MessageBox.Show("O crédito inicial deve ser um valor válido");
                return;
            }
            Cliente cliente = new Cliente()
            {
                Nome = nome,
                NIF = nif,
                Saldo = credito // Atribui crédito à conta do cliente
            };
            // Adiciona o cliente ao contexto e salva na base
            using (var context = new CantinaContext())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
            // Limpar campos após a gravação na base
            textNome.Text = "";
            textNif.Text = "";
            textAporteCredito.Text = "";

            // Atualizar a lista de clientes
            ListarClientes();
        }

        private void ListarClientes()
        {
            List<Cliente> clientes;
            using (var context = new CantinaContext())
            {
                clientes = context.Clientes.ToList();
            }
            listBoxClientes.Items.Clear();
            foreach (var cliente in clientes)
            {
                listBoxClientes.Items.Add($"ID: {cliente.Id}, Nome: {cliente.Nome}, NIF: {cliente.NIF}, Saldo: {cliente.Saldo:C}");
            }
        }

        private void btnInativarCliente_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null)
            {
                string selectedCliente = listBoxClientes.SelectedItem.ToString();
                int startIndex = selectedCliente.IndexOf("ID: ") + 4;
                int endIndex = selectedCliente.IndexOf(",", startIndex);
                int id = int.Parse(selectedCliente.Substring(startIndex, endIndex - startIndex));

                using (var context = new CantinaContext())
                {
                    var cliente = context.Clientes.Find(id);
                    if (cliente != null)
                    {
                        cliente.Ativo = false;
                        context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();

                        ListarClientes();
                        MessageBox.Show($"Cliente {cliente.Nome} (ID: {cliente.Id}) foi inativado.");
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente para inativar!");
            }
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem != null)
            {
                string selectedCliente = listBoxClientes.SelectedItem.ToString();
                int startIndex = selectedCliente.IndexOf("ID: ") + 4;
                int endIndex = selectedCliente.IndexOf(",", startIndex);
                int id = int.Parse(selectedCliente.Substring(startIndex, endIndex - startIndex));

                using (var context = new CantinaContext())
                {
                    var cliente = context.Clientes.Find(id);
                    if (cliente != null)
                    {
                        selectedClienteId = cliente.Id;
                        textNome.Text = cliente.Nome;
                        textNif.Text = cliente.NIF.ToString();
                        // O crédito não pode ser alterado manualmente
                        textAporteCredito.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para editar!");
            }
        }

        private void btnGravarEdicao_Click(object sender, EventArgs e)
        {
            if (selectedClienteId != -1)
            {
                string nome = textNome.Text.Trim();
                string nifText = textNif.Text.Trim();

                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(nifText))
                {
                    MessageBox.Show("Por favor, preencha todos os dados!!");
                    return;
                }
                if (!int.TryParse(nifText, out int nif))
                {
                    MessageBox.Show("O NIF deve ser um número válido!!");
                    return;
                }

                using (var context = new CantinaContext())
                {
                    var cliente = context.Clientes.Find(selectedClienteId);
                    if (cliente != null)
                    {
                        cliente.Nome = nome;
                        cliente.NIF = nif;
                        context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();

                        ListarClientes();
                        MessageBox.Show($"Cliente {cliente.Nome} (ID: {cliente.Id}) foi atualizado.");

                        textNome.Text = "";
                        textNif.Text = "";
                        textAporteCredito.Enabled = true;
                        selectedClienteId = -1;
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado para edição.");
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(this);
            this.Hide();
        }

        private void btnAdicionarCredito_Click(object sender, EventArgs e)
        {
            if (selectedClienteId != -1)
            {
                string creditoAdicionalText = textCreditoAdicional.Text.Trim();

                if (!decimal.TryParse(creditoAdicionalText, out decimal creditoAdicional))
                {
                    MessageBox.Show("O valor do crédito adicional deve ser um número válido.");
                    return;
                }

                using (var context = new CantinaContext())
                {
                    var cliente = context.Clientes.Find(selectedClienteId);
                    if (cliente != null)
                    {
                        cliente.Saldo += creditoAdicional;
                        context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();

                        ListarClientes();
                        MessageBox.Show($"Crédito adicionado com sucesso! Novo saldo de {cliente.Nome} (ID: {cliente.Id}) é {cliente.Saldo:C}");

                        textCreditoAdicional.Text = "";
                        textNome.Text = "";
                        textNif.Text = "";
                        textAporteCredito.Enabled = true;
                        textCreditoAdicional.Enabled = false;
                        selectedClienteId = -1;
                    }
                    else
                    {
                        MessageBox.Show("Cliente não encontrado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, busque um cliente pelo NIF ou selecione um cliente na lista!");
            }
        } 

        private void btnBuscarClientePorNif_Click(object sender, EventArgs e)
        {
            string nifText = textBuscaNif.Text.Trim();

            if(!int.TryParse(nifText,out int nif))
            {
                MessageBox.Show("O NIF deve ser um número válido!");
                return;
            }
            using(var context = new CantinaContext())
            {
                var cliente = context.Clientes.FirstOrDefault(c => c.NIF == nif);
                if(cliente != null)
                {
                    selectedClienteId = cliente.Id;
                    textNome.Text = cliente.Nome;
                    textNif.Text = cliente.NIF.ToString();
                    textAporteCredito.Enabled = false;
                    textCreditoAdicional.Enabled = true;
                    MessageBox.Show($"Cliente {cliente.Nome} (ID: {cliente.Id}) encontrado.");

                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("Selecione um prato para excluir.");
                return;
            }

            string selectedCliente = listBoxClientes.SelectedItem.ToString();
            int id = int.Parse(selectedCliente.Substring(4, selectedCliente.IndexOf(",") - 4));

            using (var context = new CantinaContext())
            {
                var cliente = context.Clientes.Find(id);
                if (cliente != null)
                {
                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                    listBoxClientes.Items.Remove(listBoxClientes.SelectedItem);
                    MessageBox.Show("Cliente excluído com sucesso.");
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                }
            }
        }

        private void FormEstudante_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }
    }
}
