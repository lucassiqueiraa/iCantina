using Cantina.Data;
using Cantina.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina.Forms
{
    public partial class FormExtras : Form
    {
        private int selectedExtraId = -1;
        public FormExtras()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(this);
            this.Hide();
        }

        private void ListarExtras()
        {
            List<Extra> extras;
            using (var context = new CantinaContext())
            {
                extras = context.Extras.ToList();
            }
            listBoxExtras.Items.Clear();

            // Usando HashSet para armazenar IDs únicos
            HashSet<int> idsAdicionados = new HashSet<int>();
            foreach (var extra in extras)
            {
                //Verifica se o ID já foi adicionado a Lista

                if (!idsAdicionados.Contains(extra.Id))
                {

                    listBoxExtras.Items.Add($"ID: {extra.Id}, Descrição: {extra.Descricao}, Preço: {extra.Preco}");
                    //Aqui vai adicionar o id a lista de ids adicionados.
                    idsAdicionados.Add(extra.Id);
                }

            }
        }

        private void btnGravarExtra_Click(object sender, EventArgs e)
        {

            ///<summary>
            ///Captura de dados através dos formulários
            ///</summary>
            ///

            string descricao = textDescricao.Text.Trim();
            string precoText = textPreco.Text.Trim();

            // Validação simples dos campos de entrada

            if (string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(precoText))
            {
                MessageBox.Show("Por favor, preencha todos os dados.");
                return;

            }

            //Aqui precisei alterar/converter o NIF para int
            if (!decimal.TryParse(precoText, out decimal preco))
            {
                MessageBox.Show("O preço deve ser um número válido!!");
            }

            Extra extra = new Extra
            {
                Descricao = descricao,
                Preco = preco,
            };
            //Aqui adicionamos o novo funcionario ao contexto e salvamos na base de dados   
            using (var context = new CantinaContext())
            {
                context.Extras.Add(extra);
                context.SaveChanges();

            }
            //Aqui limpamos os campos após a gravação 
            textDescricao.Text = "";
            textPreco.Text = "";

            //atualizando a lista de funcionarios 
            ListarExtras();
        }

        private void btnInativarExtra_Click(object sender, EventArgs e)
        {
            //Primeiro vamos verificar se há algum item selecionado na ListBox
            if (listBoxExtras.SelectedItem != null)
            {
                //obter o texto/informação do item selecionado
                string selectedExtra = listBoxExtras.SelectedItem.ToString();

                //Agora é que são elas, Extraímos o ID do objeto selecionado
                int startIndex = selectedExtra.IndexOf("ID : ") + 4;
                int endIndex = selectedExtra.IndexOf(", ", startIndex);
                int id = int.Parse(selectedExtra.Substring(startIndex, endIndex - startIndex));

                //Agaro inativamos o funcionário com id extraído acima.
                using (var context = new CantinaContext())
                {
                    var extra = context.Extras.Find(id);
                    if (extra != null)
                    {
                        extra.Ativo = false;
                        context.Entry(extra).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();

                        //agora atualizamos a lista de funcionarios, após a inativação 
                        ListarExtras();
                        //Mensagem de inativação do funcionário inativado
                        MessageBox.Show($"Extra {extra.Descricao} (ID: {extra.Id}) foi inativado.");

                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecione um extra para inativar!");
                    }
                }
            }
        }

        private void btnEditarExtra_Click(object sender, EventArgs e)
        {
            if (listBoxExtras.SelectedItem != null)
            {
                string selectedExtra = listBoxExtras.SelectedItem.ToString();
                int id = int.Parse(selectedExtra.Substring(4, selectedExtra.IndexOf(",") - 4));
                using (var context = new CantinaContext())
                {
                    var extra = context.Extras.Find(id);
                    if (extra != null)
                    {
                        selectedExtraId = extra.Id;
                        textDescricao.Text = extra.Descricao;
                        textPreco.Text = extra.Preco.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Extra não encontrado!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um Extra para editar!");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (selectedExtraId != 0)
            {
                string descricao = textDescricao.Text.Trim();
                string precoText = textPreco.Text.Trim();

                if (string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(precoText))
                {
                    MessageBox.Show("Por favor, preencha todos os dados!!");
                    return;
                }
                if (!decimal.TryParse(precoText, out decimal preco))
                {
                    MessageBox.Show("O preço deve ser um número válido!!");
                    return;
                }
                using (var context = new CantinaContext())
                {
                    var extra = context.Extras.Find(selectedExtraId);
                    if (extra != null)
                    {
                        extra.Descricao = descricao;
                        extra.Preco = preco;
                        context.Entry(extra).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();

                        ListarExtras();
                        MessageBox.Show($"Extra {extra.Descricao} (ID: {extra.Id}) foi atualizado.");

                        textDescricao.Text = "";
                        textPreco.Text = "";
                        selectedExtraId = -1;

                    }
                    else
                    {
                        MessageBox.Show("Extra nao encontrado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum Extra selecionado para edição.");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listBoxExtras.SelectedItem == null)
            {
                MessageBox.Show("Selecione um extra para excluir.");
                return;
            }

            string selectedExtra = listBoxExtras.SelectedItem.ToString();
            int id = int.Parse(selectedExtra.Substring(4, selectedExtra.IndexOf(",") - 4));

            using (var context = new CantinaContext())
            {
                var extra = context.Extras.Find(id);
                if (extra != null)
                {
                    context.Extras.Remove(extra);
                    context.SaveChanges();
                    listBoxExtras.Items.Remove(listBoxExtras.SelectedItem);
                    MessageBox.Show("Extra excluído com sucesso.");
                }
                else
                {
                    MessageBox.Show("Extra não encontrado!");
                }
            }
        }

        private void FormExtras_Load(object sender, EventArgs e)
        {
            ListarExtras();
        }
    }
}
