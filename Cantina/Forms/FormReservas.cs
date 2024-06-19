using Cantina.Data;
using Cantina.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using Menu = Cantina.Models.Menu;
using System.Runtime.Remoting.Contexts;
using iTextSharp.text.pdf;
using iTextSharp.text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (listBoxMenus.SelectedItem != null)
            {
                Menu menu = (Menu)listBoxMenus.SelectedItem;
                CarregarExtrasDisponiveis(menu);
            }
        }

        private void CarregarExtrasDisponiveis(Menu menu)
        {
            using (var context = new CantinaContext())
            {
                /* var extras = context.Extras
                     .Where(e => e.Ativo) // Considera apenas extras ativos
                     .ToList();

                 // Limpa a lista atual de extras no ListBox
                 listBoxExtras.Items.Clear();

                 // Adiciona os extras ao ListBox
                 foreach (var extra in extras)
                 {
                     listBoxExtras.Items.Add(extra);
                 }*/
                
                    // Carregar os extras disponíveis para o menu selecionado
                    var extrasDisponiveis = context.Extras
                        .Where(e => e.Ativo) // Considera apenas extras ativos
                        .ToList();

                    // Limpa a lista atual de extras no ListBox
                    listBoxExtras.Items.Clear();

                    // Adiciona os extras ao ListBox
                    foreach (var extra in extrasDisponiveis)
                    {
                        listBoxExtras.Items.Add(extra); // Aqui adicionamos o objeto Extra diretamente
                    }
                
            }
        }

        private void btnReservarMenu_Click(object sender, EventArgs e)
        {
            if (selectedClienteId != -1 && listBoxMenus.SelectedItem != null)
            {
                Menu menu = (Menu)listBoxMenus.SelectedItem;
                List<Extra> extrasSelecionados = listBoxExtras.SelectedItems.Cast<Extra>().ToList();

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

        private bool VerificarDisponibilidade(Menu menu, List<Extra> extrasSelecionados)
        {

            using (var context = new CantinaContext())
            {
                // Verificar se o menu está disponível
                var menuDisponivel = context.Menus
                    .Any(m => m.Id == menu.Id);
                if (!menuDisponivel)
                {
                    return false;
                }

                // Verificar se todos os extras selecionados estão disponíveis
                foreach (var extra in extrasSelecionados)
                {
                    var extraDisponivel = context.Extras
                        .Any(e => e.Id == extra.Id);
                    if (!extraDisponivel)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private decimal CalcularValorTotalReserva(Menu menu, List<Extra> extrasSelecionados)
        {
            decimal valorTotal = menu.PrecoEstudante; // ou menu.PrecoProfessor dependendo do cliente

            // Adicione lógica para calcular valor total considerando extras selecionados
            foreach (var extra in extrasSelecionados)
            {
                valorTotal += extra.Preco;
            }

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
                    context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        private void CriarReserva(int clienteId, Menu menu, List<Extra> extrasSelecionados, decimal valorTotal)
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
                    context.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        private string GerarFaturaPDF(Menu menu, List<Extra> extrasSelecionados, decimal valorTotal)
        {
            // Implemente lógica para gerar fatura simplificada em PDF
            string diretorioDestino = @"C:\fatura"; // Exemplo de caminho absoluto

            if (!Directory.Exists(diretorioDestino))
            {
                Directory.CreateDirectory(diretorioDestino);
            }

            string nomeArquivo = $"Fatura_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string caminhoCompleto = Path.Combine(diretorioDestino, nomeArquivo);

            try
            {
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(caminhoCompleto, FileMode.Create));
                doc.Open();

                doc.Add(new Paragraph($"Fatura Simplificada - Data: {DateTime.Now}"));
                doc.Add(new Paragraph($"Cliente: {selectedClienteId}")); // Exemplo básico, substituir pelo nome do cliente

                doc.Add(new Paragraph($"Menu: {menu.DataHora.ToShortDateString()}"));
                doc.Add(new Paragraph($"Preço do Menu: {menu.PrecoEstudante:C}"));

                // Adicione detalhes dos extras selecionados
                if (extrasSelecionados.Any())
                {
                    doc.Add(new Paragraph("Extras:"));
                    foreach (var extra in extrasSelecionados)
                    {
                        doc.Add(new Paragraph($"- {extra.Descricao} - Preço: {extra.Preco:C}"));
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

                return caminhoCompleto; // Retorna o caminho completo do arquivo gerado
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao gerar a fatura: {ex.Message}");
                return null; // Retorna null em caso de erro
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedClienteId != -1 && listBoxMenus.SelectedItem != null)
            {
                Menu menu = (Menu)listBoxMenus.SelectedItem;
                List<Extra> extrasSelecionados = listBoxExtras.SelectedItems.Cast<Extra>().ToList();

                // Calcular valor total da reserva
                decimal valorTotal = CalcularValorTotalReserva(menu, extrasSelecionados);

                // Gerar fatura simplificada em PDF
                string caminhoFatura = GerarFaturaPDF(menu, extrasSelecionados, valorTotal);

                // Verifica se o arquivo foi gerado corretamente
                if (!string.IsNullOrEmpty(caminhoFatura))
                {
                    // Abrir o arquivo PDF gerado
                    try
                    {
                        System.Diagnostics.Process.Start(caminhoFatura);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocorreu um erro ao abrir a fatura: {ex.Message}");
                    }

                    MessageBox.Show("Fatura gerada e aberta com sucesso!");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao gerar a fatura.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um cliente e um menu para gerar a fatura.");
            }
        }
    }
}
