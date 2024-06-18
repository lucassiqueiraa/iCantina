using Cantina.Data;
using Cantina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Cantina.Forms
{
    public partial class FormProfessor : Form
    {
        private int selectedProfessorId = -1;

        public FormProfessor()
        {
            InitializeComponent();
        }

        private void btnGravarProfessor_Click(object sender, EventArgs e)
        {
            string nome = textNome.Text.Trim();
            string nifText = textNif.Text.Trim();
            string creditoText = textAporteCredito.Text.Trim();
            string email = textEmail.Text.Trim();

            // Validação básica na entrada de informações
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(nifText) || string.IsNullOrEmpty(creditoText) || string.IsNullOrEmpty(email))
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

            Professor professor = new Professor()
            {
                Nome = nome,
                NIF = nif,
                Saldo = credito,
                Email = email
            };

            try
            {
                using (var context = new CantinaContext())
                {
                    context.Professores.Add(professor);
                    context.SaveChanges();
                }

                textNome.Text = "";
                textNif.Text = "";
                textAporteCredito.Text = "";
                textEmail.Text = "";

                ListarProfessores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gravar professor: {ex.Message}");
            }
        }

        private void ListarProfessores()
        {
            try
            {
                using (var context = new CantinaContext())
                {
                    var professores = context.Professores.ToList();
                    listBoxProfessores.Items.Clear();
                    foreach (var professor in professores)
                    {
                        listBoxProfessores.Items.Add($"ID: {professor.Id}, Nome: {professor.Nome}, NIF: {professor.NIF}, Saldo: {professor.Saldo:C}, Email: {professor.Email}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao listar professores: {ex.Message}");
            }
        }

        private void btnListarProfessores_Click(object sender, EventArgs e)
        {
            ListarProfessores();
        }

        private void btnInativarProfessor_Click(object sender, EventArgs e)
        {
            if (listBoxProfessores.SelectedItem != null)
            {
                string selectedProfessor = listBoxProfessores.SelectedItem.ToString();
                int startIndex = selectedProfessor.IndexOf("ID: ") + 4;
                int endIndex = selectedProfessor.IndexOf(",", startIndex);
                int id = int.Parse(selectedProfessor.Substring(startIndex, endIndex - startIndex));

                try
                {
                    using (var context = new CantinaContext())
                    {
                        var professor = context.Professores.Find(id);
                        if (professor != null)
                        {
                            professor.Ativo = false;
                            context.Entry(professor).State = EntityState.Modified;
                            context.SaveChanges();

                            ListarProfessores();
                            MessageBox.Show($"Professor {professor.Nome} (ID: {professor.Id}) foi inativado.");
                        }
                        else
                        {
                            MessageBox.Show("Professor não encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao inativar professor: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um professor para inativar!");
            }
        }

        private void btnEditarProfessor_Click(object sender, EventArgs e)
        {
            if (listBoxProfessores.SelectedItem != null)
            {
                string selectedProfessor = listBoxProfessores.SelectedItem.ToString();
                int startIndex = selectedProfessor.IndexOf("ID: ") + 4;
                int endIndex = selectedProfessor.IndexOf(",", startIndex);
                int id = int.Parse(selectedProfessor.Substring(startIndex, endIndex - startIndex));

                try
                {
                    using (var context = new CantinaContext())
                    {
                        var professor = context.Professores.Find(id);
                        if (professor != null)
                        {
                            selectedProfessorId = professor.Id;
                            textNome.Text = professor.Nome;
                            textNif.Text = professor.NIF.ToString();
                            textEmail.Text = professor.Email;
                            textAporteCredito.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Professor não encontrado!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao editar professor: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Selecione um professor para editar!");
            }
        }

        private void btnGravarEdicao_Click(object sender, EventArgs e)
        {
            if (selectedProfessorId != -1)
            {
                string nome = textNome.Text.Trim();
                string nifText = textNif.Text.Trim();
                string email = textEmail.Text.Trim();

                if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(nifText) || string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Por favor, preencha todos os dados!!");
                    return;
                }
                if (!int.TryParse(nifText, out int nif))
                {
                    MessageBox.Show("O NIF deve ser um número válido!!");
                    return;
                }

                try
                {
                    using (var context = new CantinaContext())
                    {
                        var professor = context.Professores.Find(selectedProfessorId);
                        if (professor != null)
                        {
                            professor.Nome = nome;
                            professor.NIF = nif;
                            professor.Email = email;
                            context.Entry(professor).State = EntityState.Modified;
                            context.SaveChanges();

                            ListarProfessores();
                            MessageBox.Show($"Professor {professor.Nome} (ID: {professor.Id}) foi atualizado.");

                            textNome.Text = "";
                            textNif.Text = "";
                            textEmail.Text = "";
                            textAporteCredito.Enabled = true;
                            selectedProfessorId = -1;
                        }
                        else
                        {
                            MessageBox.Show("Professor não encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao gravar edição do professor: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Nenhum professor selecionado para edição.");
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(this);
            this.Hide();
        }
    }
}
