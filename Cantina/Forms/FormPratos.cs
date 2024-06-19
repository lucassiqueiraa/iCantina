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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Cantina.Forms
{
    public partial class FormPratos : Form
    {
        private int selectedPratoId = -1;
        public FormPratos()
        {
            InitializeComponent();
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Close();
        }

        private void ListarPratos()
        {
            List<Prato> pratos;
            using (var context = new CantinaContext())
            {
                pratos = context.Pratos.ToList();
            }
            listBoxPratos.Items.Clear();

            // Usando HashSet para armazenar IDs únicos
            HashSet<int> idsAdicionados = new HashSet<int>();
            foreach (var prato in pratos)
            {
                //Verifica se o ID já foi adicionado a Lista

                if (!idsAdicionados.Contains(prato.Id))
                {

                    listBoxPratos.Items.Add($"ID: {prato.Id}, Descrição: {prato.Descricao}, Tipo: {prato.Tipo}");
                    //Aqui vai adicionar o id a lista de ids adicionados.
                    idsAdicionados.Add(prato.Id);
                }

            }
        }

        private Control.ControlCollection GetControls()
        {
            return groupBoxTipo.Controls;
        }

        private void btnGravarPrato_Click(object sender, EventArgs e)
        {
            string descricao = textDescricao.Text.Trim();
            string tipo = "";

            //condição para atribuir o tipo do prato a variável "Prato"
            if (radioButtonCarne.Checked)
            {
                tipo = "Carne";
            }
            else if (radioButtonPeixe.Checked)
            {
                tipo = "Peixe";
            }
            else if (radioButtonVegetariano.Checked)
            {
                tipo = "Vegetariano";
            }


            // Validação simples dos campos de entrada

            if (string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Por favor, preencha todos os dados.");
                return;

            }

            Prato prato = new Prato
            {
                Descricao = descricao,
                Tipo = tipo,
            };
            //Aqui adicionamos o novo funcionario ao contexto e salvamos na base de dados   
            using (var context = new CantinaContext())
            {
                context.Pratos.Add(prato);
                context.SaveChanges();

            }
            //Aqui limpamos os campos após a gravação 
            textDescricao.Text = "";
            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.RadioButton)
                {
                    ((System.Windows.Forms.RadioButton)control).Checked = false;
                }
            }
            //atualizando a lista de funcionarios 
            ListarPratos();
        }

        private void btnInativarPrato_Click(object sender, EventArgs e)
        {
            //Primeiro vamos verificar se há algum item selecionado na ListBox
            if (listBoxPratos.SelectedItem != null)
            {
                //obter o texto/informação do item selecionado
                string selectedPrato = listBoxPratos.SelectedItem.ToString();

                //Agora é que são elas, Extraímos o ID do objeto selecionado
                int startIndex = selectedPrato.IndexOf("ID : ") + 4;
                int endIndex = selectedPrato.IndexOf(", ", startIndex);
                int id = int.Parse(selectedPrato.Substring(startIndex, endIndex - startIndex));

                //Agaro inativamos o funcionário com id extraído acima.
                using (var context = new CantinaContext())
                {
                    var prato = context.Pratos.Find(id);
                    if (prato != null)
                    {
                        prato.Ativo = false;
                        context.Entry(prato).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();

                        //agora atualizamos a lista de funcionarios, após a inativação 
                        ListarPratos();
                        //Mensagem de inativação do funcionário inativado
                        MessageBox.Show($"Prato {prato.Descricao} (ID: {prato.Id}) foi inativado.");

                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecione um prato para inativar!");
                    }
                }
            }
        }

        private void btnEditarPrato_Click(object sender, EventArgs e)
        {
            if (listBoxPratos.SelectedItem != null)
            {
                string selectedPrato = listBoxPratos.SelectedItem.ToString();
                int id = int.Parse(selectedPrato.Substring(4, selectedPrato.IndexOf(",") - 4));
                using (var context = new CantinaContext())
                {
                    var prato = context.Pratos.Find(id);
                    if (prato != null)
                    {
                        selectedPratoId = prato.Id;
                        textDescricao.Text = prato.Descricao;
                        foreach (Control control in groupBoxTipo.Controls)
                        {
                            System.Windows.Forms.RadioButton radioButton = control as System.Windows.Forms.RadioButton;
                            if (radioButton != null && radioButton.Text == prato.Tipo)
                            {
                                radioButton.Checked = true;
                                break;
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Prato não encontrado!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um Prato para editar!");
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (selectedPratoId != 0)
            {
                string descricao = textDescricao.Text.Trim();
                string tipo = "";

                //condição para atribuir o tipo do prato a variável "Prato"
                if (radioButtonCarne.Checked)
                {
                    tipo = "Carne";
                }
                else if (radioButtonPeixe.Checked)
                {
                    tipo = "Peixe";
                }
                else if (radioButtonVegetariano.Checked)
                {
                    tipo = "Vegetariano";
                }

                if (string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(tipo))
                {
                    MessageBox.Show("Por favor, preencha todos os dados!!");
                    return;
                }
                
                using (var context = new CantinaContext())
                {
                    var prato = context.Pratos.Find(selectedPratoId);
                    if (prato != null)
                    {
                        prato.Descricao = descricao;
                        prato.Tipo = tipo;
                        context.Entry(prato).State = System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();

                        ListarPratos();
                        MessageBox.Show($"Prato {prato.Descricao} (ID: {prato.Id}) foi atualizado.");

                        textDescricao.Text = "";
                        foreach (Control control in this.Controls)
                        {
                            if (control is System.Windows.Forms.RadioButton)
                            {
                                ((System.Windows.Forms.RadioButton)control).Checked = false;
                            }
                        }
                        selectedPratoId = -1;

                    }
                    else
                    {
                        MessageBox.Show("Prato nao encontrado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum Prato selecionado para edição.");
            }
        }

        private void FormPratos_Load(object sender, EventArgs e)
        {
            ListarPratos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listBoxPratos.SelectedItem == null)
            {
                MessageBox.Show("Selecione um prato para excluir.");
                return;
            }

            string selectedPrato = listBoxPratos.SelectedItem.ToString();
            int id = int.Parse(selectedPrato.Substring(4, selectedPrato.IndexOf(",") - 4));

            using (var context = new CantinaContext())
            {
                var prato = context.Pratos.Find(id);
                if (prato != null)
                {
                    context.Pratos.Remove(prato);
                    context.SaveChanges();
                    listBoxPratos.Items.Remove(listBoxPratos.SelectedItem);
                    MessageBox.Show("Prato excluído com sucesso.");
                }
                else
                {
                    MessageBox.Show("Prato não encontrado!");
                }
            }
        }

        
    }
}
