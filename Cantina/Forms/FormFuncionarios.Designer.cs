using System;

namespace Cantina.Forms
{
    partial class FormFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textNif = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.btnGravarFuncionario = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxFuncionarios = new System.Windows.Forms.ListBox();
            this.btnInativarFuncionario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIF  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username :";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(152, 21);
            this.textNome.Margin = new System.Windows.Forms.Padding(2);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(124, 20);
            this.textNome.TabIndex = 3;
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(152, 57);
            this.textNif.Margin = new System.Windows.Forms.Padding(2);
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(124, 20);
            this.textNif.TabIndex = 4;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(152, 93);
            this.textUsername.Margin = new System.Windows.Forms.Padding(2);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(124, 20);
            this.textUsername.TabIndex = 5;
            // 
            // btnGravarFuncionario
            // 
            this.btnGravarFuncionario.Location = new System.Drawing.Point(152, 150);
            this.btnGravarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravarFuncionario.Name = "btnGravarFuncionario";
            this.btnGravarFuncionario.Size = new System.Drawing.Size(94, 33);
            this.btnGravarFuncionario.TabIndex = 7;
            this.btnGravarFuncionario.Text = "Gravar Funcionario";
            this.btnGravarFuncionario.UseVisualStyleBackColor = true;
            this.btnGravarFuncionario.Click += new System.EventHandler(this.btnGravarFuncionario_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(317, 201);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Voltar Menu Principal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnVoltarMenuPrincipal_Click);
            // 
            // listBoxFuncionarios
            // 
            this.listBoxFuncionarios.FormattingEnabled = true;
            this.listBoxFuncionarios.Location = new System.Drawing.Point(49, 243);
            this.listBoxFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxFuncionarios.Name = "listBoxFuncionarios";
            this.listBoxFuncionarios.Size = new System.Drawing.Size(420, 95);
            this.listBoxFuncionarios.TabIndex = 9;
            // 
            // btnInativarFuncionario
            // 
            this.btnInativarFuncionario.Location = new System.Drawing.Point(268, 150);
            this.btnInativarFuncionario.Margin = new System.Windows.Forms.Padding(2);
            this.btnInativarFuncionario.Name = "btnInativarFuncionario";
            this.btnInativarFuncionario.Size = new System.Drawing.Size(94, 33);
            this.btnInativarFuncionario.TabIndex = 10;
            this.btnInativarFuncionario.Text = "Inativar Funcionario";
            this.btnInativarFuncionario.UseVisualStyleBackColor = true;
            this.btnInativarFuncionario.Click += new System.EventHandler(this.btnInativarFuncionario_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(96, 201);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Editar Funcionario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEditarFuncionario_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(210, 201);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "Gravar Edição Funcionario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnSalvarEdicao_Click);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 386);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnInativarFuncionario);
            this.Controls.Add(this.listBoxFuncionarios);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGravarFuncionario);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textNif);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFuncionarios";
            this.Text = "Funcionário";
            this.Load += new System.EventHandler(this.FormFuncionarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textNif;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Button btnGravarFuncionario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxFuncionarios;
        private System.Windows.Forms.Button btnInativarFuncionario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}
