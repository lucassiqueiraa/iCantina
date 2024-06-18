namespace Cantina.Forms
{
    partial class FormEstudante
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
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textAporteCredito = new System.Windows.Forms.TextBox();
            this.textNif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.btnListarCliente = new System.Windows.Forms.Button();
            this.btnGravarFuncionario = new System.Windows.Forms.Button();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnInativarCliente = new System.Windows.Forms.Button();
            this.btnGravarEdicao = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 25;
            this.listBoxClientes.Location = new System.Drawing.Point(231, 590);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(836, 154);
            this.listBoxClientes.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "NIF  :";
            // 
            // textAporteCredito
            // 
            this.textAporteCredito.Location = new System.Drawing.Point(511, 250);
            this.textAporteCredito.Name = "textAporteCredito";
            this.textAporteCredito.Size = new System.Drawing.Size(244, 31);
            this.textAporteCredito.TabIndex = 40;
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(511, 171);
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(244, 31);
            this.textNif.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Aporte Crédito :";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(511, 103);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(244, 31);
            this.textNome.TabIndex = 30;
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Location = new System.Drawing.Point(554, 402);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(187, 63);
            this.btnListarCliente.TabIndex = 32;
            this.btnListarCliente.Text = "Listar Cliente";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            // 
            // btnGravarFuncionario
            // 
            this.btnGravarFuncionario.Location = new System.Drawing.Point(327, 402);
            this.btnGravarFuncionario.Name = "btnGravarFuncionario";
            this.btnGravarFuncionario.Size = new System.Drawing.Size(187, 63);
            this.btnGravarFuncionario.TabIndex = 33;
            this.btnGravarFuncionario.Text = "Gravar Cliente";
            this.btnGravarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Location = new System.Drawing.Point(769, 500);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(187, 63);
            this.btnVoltarMenu.TabIndex = 34;
            this.btnVoltarMenu.Text = "Voltar Menu Principal";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            // 
            // btnInativarCliente
            // 
            this.btnInativarCliente.Location = new System.Drawing.Point(769, 402);
            this.btnInativarCliente.Name = "btnInativarCliente";
            this.btnInativarCliente.Size = new System.Drawing.Size(187, 63);
            this.btnInativarCliente.TabIndex = 36;
            this.btnInativarCliente.Text = "Inativar Cliente";
            this.btnInativarCliente.UseVisualStyleBackColor = true;
            // 
            // btnGravarEdicao
            // 
            this.btnGravarEdicao.Location = new System.Drawing.Point(554, 500);
            this.btnGravarEdicao.Name = "btnGravarEdicao";
            this.btnGravarEdicao.Size = new System.Drawing.Size(187, 63);
            this.btnGravarEdicao.TabIndex = 38;
            this.btnGravarEdicao.Text = "Gravar Edição Cliente";
            this.btnGravarEdicao.UseVisualStyleBackColor = true;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(327, 500);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(187, 63);
            this.btnEditarCliente.TabIndex = 37;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // FormEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 843);
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
            this.Name = "FormEstudante";
            this.Text = "FormEstudante";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAporteCredito;
        private System.Windows.Forms.TextBox textNif;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Button btnListarCliente;
        private System.Windows.Forms.Button btnGravarFuncionario;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Button btnInativarCliente;
        private System.Windows.Forms.Button btnGravarEdicao;
        private System.Windows.Forms.Button btnEditarCliente;
    }
}