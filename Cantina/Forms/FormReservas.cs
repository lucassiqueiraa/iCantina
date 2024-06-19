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
                var menus = context.MenusDiarios.Where(m => m.Data == DateTime.Today).ToList();
                listBoxMenus.Items.Clear();
                foreach (var menu in menus)
                {
                    listBoxMenus.Items.Add(menu);
                }
            }
        }

        private void listBoxMenus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMenus.SelectedItem != null)
            {
                MenuDiario menu = (MenuDiario)listBoxMenus.SelectedItem;
                CarregarExtrasDisponiveis(menu);
            }
        }

        private void CarregarExtrasDisponiveis(MenuDiario menu)
        {
            // Implemente lógica para carregar extras disponíveis do menu selecionado
            // Exemplo básico:
            listBoxExtras.Items.Clear();
            listBoxExtras.Items.Add("Extra 1");
            listBoxExtras.Items.Add("Extra 2");
            // Adicione lógica para verificar a disponibilidade de cada extra
        }

        private void btnReservarMenu_Click(object sender, EventArgs e)
        {
            if (selectedClienteId != -1 && listBoxMenus.SelectedItem != null)
            {
                MenuDiario menu = (MenuDiario)listBoxMenus.SelectedItem;
                List<string> extrasSelecionados = listBoxExtras.SelectedItems.Cast<string>().ToList();

                // Verificar disponibilidade de pratos e extras
                if (VerificarDisponibilidade(menu, extrasSelecionados))
                {
                    // Calcular valor total da reserva
                    decimal valorTotal = CalcularValorTotalReserva(menu, extrasSelecionados);

                    // Verificar período de multa
                    if (VerificarPeriodoMulta())
                    {
                        // Registrar multa
                        RegistrarMulta(selectedClienteId);
                    }

                    // Criar e salvar reserva
                    CriarReserva(selectedClienteId, menu, extrasSelecionados, valorTotal);

                    // Atualizar saldo do cliente
                    AtualizarSaldoCliente(selectedClienteId, valorTotal);

                    // Gerar fatura simplificada em PDF
                    GerarFaturaPDF(menu, extrasSelecionados, valorTotal);

                    MessageBox.Show("Reserva realizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Pratos ou extras selecionados não estão disponíveis.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente e um menu para reservar.");
            }
        }

        private bool VerificarDisponibilidade(MenuDiario menu, List<string> extrasSelecionados)
        {
            // Implemente lógica para verificar disponibilidade de pratos e extras
            // Verifique quantidade disponível e retorne true se tudo estiver disponível
            return true;
        }

        private decimal CalcularValorTotalReserva(MenuDiario menu, List<string> extrasSelecionados)
        {
            decimal valorTotal = menu.Valor;

            // Adicione lógica para calcular valor total considerando extras selecionados
            // Exemplo básico:
            valorTotal += extrasSelecionados.Count * 2; // Exemplo de valor fixo para cada extra

            return valorTotal;
        }

        private bool VerificarPeriodoMulta()
        {
            // Implemente lógica para verificar se a reserva foi feita durante o período de multa
            // Exemplo básico: verificar se a reserva foi feita após as 18:00 do dia anterior
            DateTime dataLimite = DateTime.Today.AddDays(-1).AddHours(18);
            return DateTime.Now > dataLimite;
        }

        private void RegistrarMulta(int clienteId)
        {
            // Implemente lógica para registrar a multa para o cliente
            // Exemplo básico: adicionar uma multa de 1€ ao cliente
            using (var context = new CantinaContext())
            {
                Cliente cliente = context.Clientes.Find(clienteId);
                if (cliente != null)
                {
                    cliente.Saldo -= 1; // Deduzir 1€ do saldo
                    context.Entry(cliente).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        private void CriarReserva(int clienteId, MenuDiario menu, List<string> extrasSelecionados, decimal valorTotal)
        {
            // Implemente lógica para criar e salvar a reserva
            using (var context = new CantinaContext())
            {
                Reserva reserva = new Reserva
                {
                    ClienteId = clienteId,
                    MenuId = menu.Id,
                    DataHora = DateTime.Now,
                    Utilizada = false
                    // Adicione outras propriedades da reserva conforme necessário
                };

                context.Reservas.Add(reserva);
                context.SaveChanges();
            }
        }

        private void AtualizarSaldoCliente(int clienteId, decimal valorTotal)
        {
            // Implemente lógica para atualizar o saldo do cliente após a reserva
            using (var context = new CantinaContext())
            {
                Cliente cliente = context.Clientes.Find(clienteId);
                if (cliente != null)
                {
                    cliente.Saldo -= valorTotal;
                    context.Entry(cliente).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        private void GerarFaturaPDF(MenuDiario menu, List<string> extrasSelecionados, decimal valorTotal)
        {
            // Implemente lógica para gerar fatura simplificada em PDF
            string nomeArquivo = $"Fatura_{DateTime.Now:yyyyMMddHHmmss}.pdf";

            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream(nomeArquivo, FileMode.Create));
            doc.Open();

            doc.Add(new Paragraph($"Fatura Simplificada - Data: {DateTime.Now}"));
            doc.Add(new Paragraph($"Cliente: {selectedClienteId}")); // Exemplo básico, substituir pelo nome do cliente

            doc.Add(new Paragraph($"Menu: {menu.Nome}"));
            doc.Add(new Paragraph($"Valor do Menu: {menu.Valor:C}"));

            // Adicione detalhes dos extras selecionados
            if (extrasSelecionados.Any())
            {
                doc.Add(new Paragraph("Extras:"));
                foreach (var extra in extrasSelecionados)
                {
                    doc.Add(new Paragraph($"- {extra}"));
                }
            }
            else
            {
                doc.Add(new Paragraph("Sem Extras."));
            }

            // Adicione detalhes das multas (se houver)
            if (VerificarPeriodoMulta())
            {
                doc.Add(new Paragraph("Multa Aplicada: 1€")); // Exemplo básico, substituir por lógica real de multas
            }

            doc.Add(new Paragraph($"Total: {valorTotal:C}"));

            doc.Close();
        }
    }
}
