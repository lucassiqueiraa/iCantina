using Cantina.Data;
using Cantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cantina.Forms
{
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
        }
        private void btnVoltarMenuPrincipal_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(this);
            this.Hide();
        }

        private void btnListarFuncionarios_Click(object sender, EventArgs e)
        {
            ListarFuncionarios();
        }

        private void ListarFuncionarios()
        {
            List<Funcionario> funcionarios;
            using (var context = new CantinaContext())
            {
                funcionarios = context.Funcionarios.ToList();
            }
            listBoxFuncionarios.Items.Clear();

            // Usando HashSet para armazenar IDs únicos
            HashSet<int> idsAdicionados = new HashSet<int>();
            foreach (var funcionario in funcionarios)
            {
                //Verifica se o ID já foi adicionado a Lista

                if(!idsAdicionados.Contains(funcionario.Id))
                {

                    listBoxFuncionarios.Items.Add($"ID: {funcionario.Id}, Nome: {funcionario.Nome}, NIF: {funcionario.NIF}, Username: {funcionario.Username}");
                    //Aqui vai adicionar o id a lista de ids adicionados.
                    idsAdicionados.Add(funcionario.Id);
                }

            }
        }

        private void btnGravarFuncionario_Click(object sender, EventArgs e)
        {
            ///<summary>
            ///Captura de dados através dos formulários
            ///</summary>
            ///
         
            string nome = textNome.Text.Trim();
            string nifText = textNif.Text.Trim();  
            string username = textUsername.Text.Trim();

            // Validação simples dos campos de entrada

            if(string.IsNullOrEmpty(nome)||string.IsNullOrEmpty(nifText) || string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Por favor, preencha todos os dados.");
                return;

            }

            //Aqui precisei alterar/converter o NIF para int
            if (!int.TryParse(nifText, out int nif))
            {
                MessageBox.Show("O nif deve ser um número válido!!");
            }

            Funcionario funcionario = new Funcionario
            {
                Nome = nome,
                NIF = nif,
                Username = username,
            };
            //Aqui adicionamos o novo funcionario ao contexto e salvamos na base de dados   
            using(var context = new CantinaContext())
            {
                context.Funcionarios.Add(funcionario);
                context.SaveChanges();

            }
            //Aqui limpamos os campos após a gravação 
            textNome.Text = "";
            textNif.Text = "";
            textUsername.Text = "";

            //atualizando a lista de funcionarios 
            ListarFuncionarios();



        }

        private void FormFuncionarios_Load(object sender, EventArgs e)
        {
            // Opcional: Chamar o método para listar funcionários ao carregar o formulário
            // Assim, quando abrir o formulário ele automaticamente lista
            // ListarFuncionarios();

        }

        private void btnInativarFuncionario_Click(object sender, EventArgs e)
        {
            //Primeiro vamos verificar se há algum item selecionado na ListBox
            if(listBoxFuncionarios.SelectedItem != null) 
            {
                //obter o texto/informação do item selecionado
                string selectedFuncionario =listBoxFuncionarios.SelectedItem.ToString();

                //Agora é que são elas, Extraímos o ID do objeto selecionado
                int startIndex = selectedFuncionario.IndexOf("ID : ")+4;
                int endIndex= selectedFuncionario.IndexOf(", ",startIndex);
                int id=int.Parse(selectedFuncionario.Substring(startIndex,endIndex - startIndex));

                //Agaro inativamos o funcionário com id extraído acima.
                using(var context = new CantinaContext())
                {
                    var funcionario = context.Funcionarios.Find(id);
                    if(funcionario != null)
                    {
                        funcionario.Ativo = false;
                        context.Entry(funcionario).State=System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();

                        //agora atualizamos a lista de funcionarios, após a inativação 
                        ListarFuncionarios();
                        //Mensagem de inativação do funcionário inativado
                        MessageBox.Show($"Funcionário {funcionario.Nome} (ID: {funcionario.Id}) foi inativado.");

                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecione um funcionário para inativar!");
                    }
                }
            }

        }
    }

       
    }

