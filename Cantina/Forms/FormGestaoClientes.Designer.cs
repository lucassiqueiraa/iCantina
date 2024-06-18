namespace Cantina.Forms
{
    partial class FormGestaoClientes
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
            this.btnGravarEdicao = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnInativarCliente = new System.Windows.Forms.Button();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnGravarFuncionario = new System.Windows.Forms.Button();
            this.btnListarCliente = new System.Windows.Forms.Button();
            this.textNif = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textAporteCredito = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGravarEdicao
            // 
            this.btnGravarEdicao.Location = new System.Drawing.Point(456, 464);
            this.btnGravarEdicao.Name = "btnGravarEdicao";
            this.btnGravarEdicao.Size = new System.Drawing.Size(187, 63);
            this.btnGravarEdicao.TabIndex = 25;
            this.btnGravarEdicao.Text = "Gravar Edição Cliente";
            this.btnGravarEdicao.UseVisualStyleBackColor = true;
            this.btnGravarEdicao.Click += new System.EventHandler(this.btnGravarEdicao_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(229, 464);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(187, 63);
            this.btnEditarCliente.TabIndex = 24;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnInativarCliente
            // 
            this.btnInativarCliente.Location = new System.Drawing.Point(671, 366);
            this.btnInativarCliente.Name = "btnInativarCliente";
            this.btnInativarCliente.Size = new System.Drawing.Size(187, 63);
            this.btnInativarCliente.TabIndex = 23;
            this.btnInativarCliente.Text = "Inativar Cliente";
            this.btnInativarCliente.UseVisualStyleBackColor = true;
            this.btnInativarCliente.Click += new System.EventHandler(this.btnInativarCliente_Click);
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 25;
            this.listBoxClientes.Location = new System.Drawing.Point(133, 554);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(836, 154);
            this.listBoxClientes.TabIndex = 22;
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Location = new System.Drawing.Point(671, 464);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(187, 63);
            this.btnVoltarMenu.TabIndex = 21;
            this.btnVoltarMenu.Text = "Voltar Menu Principal";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnGravarFuncionario
            // 
            this.btnGravarFuncionario.Location = new System.Drawing.Point(229, 366);
            this.btnGravarFuncionario.Name = "btnGravarFuncionario";
            this.btnGravarFuncionario.Size = new System.Drawing.Size(187, 63);
            this.btnGravarFuncionario.TabIndex = 20;
            this.btnGravarFuncionario.Text = "Gravar Cliente";
            this.btnGravarFuncionario.UseVisualStyleBackColor = true;
            this.btnGravarFuncionario.Click += new System.EventHandler(this.btnGravarCliente_Click);
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Location = new System.Drawing.Point(456, 366);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(187, 63);
            this.btnListarCliente.TabIndex = 19;
            this.btnListarCliente.Text = "Listar Cliente";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            this.btnListarCliente.Click += new System.EventHandler(this.btnListarCliente_Click);
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(413, 135);
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(244, 31);
            this.textNif.TabIndex = 17;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(413, 67);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(244, 31);
            this.textNome.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "NIF  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Aporte Crédito :";
            // 
            // textAporteCredito
            // 
            this.textAporteCredito.Location = new System.Drawing.Point(413, 214);
            this.textAporteCredito.Name = "textAporteCredito";
            this.textAporteCredito.Size = new System.Drawing.Size(244, 31);
            this.textAporteCredito.TabIndex = 27;
            // 
            // FormGestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 770);
            this.Controls.Add(this.textAporteCredito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGravarEdicao);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnInativarCliente);
            this.Controls.Add(this.listBoxClientes);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.btnGravarFuncionario);
            this.Controls.Add(this.btnListarCliente);
            this.Controls.Add(this.textNif);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGestaoClientes";
            this.Text = "FormGestaoClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravarEdicao;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnInativarCliente;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Button btnGravarFuncionario;
        private System.Windows.Forms.Button btnListarCliente;
        private System.Windows.Forms.TextBox textNif;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAporteCredito;
    }
}