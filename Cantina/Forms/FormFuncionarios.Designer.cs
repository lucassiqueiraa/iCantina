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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIF  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username :";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(304, 41);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(244, 31);
            this.textNome.TabIndex = 3;
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(304, 109);
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(244, 31);
            this.textNif.TabIndex = 4;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(304, 178);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(244, 31);
            this.textUsername.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Listar Funcionarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnListarFuncionarios_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "Gravar Funcionario";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGravarFuncionario_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(533, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 63);
            this.button3.TabIndex = 8;
            this.button3.Text = "Voltar Menu Principal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnVoltarMenuPrincipal_Click);
            // 
            // FormFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textNif);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormFuncionarios";
            this.Text = "Funcionário";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}