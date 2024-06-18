using Cantina.Data;
using Cantina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Cantina.Forms
{
    public partial class FormFuncionarios : Form
    {
        private int selectedFuncionarioId = -1; // aqui declarei o campo a utilizar par alterar 
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

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            if(listBoxFuncionarios.SelectedItem != null)
            {
                string selectedFuncionario = listBoxFuncionarios.SelectedItem.ToString();
                int id = int.Parse(selectedFuncionario.Substring(4, selectedFuncionario.IndexOf(",") - 4));
                using(var context = new CantinaContext()) 
                {
                    var funcionario = context.Funcionarios.Find( id);
                    if(funcionario != null)
                    {
                        selectedFuncionarioId = funcionario.Id;
                        textNome.Text = funcionario.Nome;
                        textNif.Text = funcionario.NIF.ToString();
                        textUsername.Text = funcionario.Username;

                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionario para editar!");
            }
        }

        private void btnSalvarEdicao_Click(object sender, EventArgs e)
        {
            if(selectedFuncionarioId != 1)
            {
                string nome=textNome.Text.Trim();
                string nifText = textNif.Text.Trim();
                string username = textUsername.Text.Trim();

                if(string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(nifText) ||string.IsNullOrEmpty(username)) 
                {
                    MessageBox.Show("Por favor, preencha todos os dados!!");
                    return;
                }
                if(!int.TryParse(nifText, out int nif))
                {
                    MessageBox.Show("O NIF deve ser um número válido!!");
                    return;
                }
                using(var context = new CantinaContext())
                {
                    var funcionario = context.Funcionarios.Find(selectedFuncionarioId);
                    if(funcionario != null)
                    {
                        funcionario.Nome = nome;
                        funcionario.NIF = nif;
                        funcionario.Username = username;
                        context.Entry(funcionario).State=System.Data.Entity.EntityState.Modified;
                        context.SaveChanges();

                        ListarFuncionarios();
                        MessageBox.Show($"Funcionário {funcionario.Nome} (ID: {funcionario.Id}) foi atualizado.");
                        
                        textNome.Text = "";
                        textNif.Text = "";
                        textUsername.Text = "";
                        selectedFuncionarioId = -1;

                    }
                    else
                    {
                        MessageBox.Show("Funcionario nao encontrado.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhum funcionário selecionado para edição.");
            }

        }
    }

       
    }

