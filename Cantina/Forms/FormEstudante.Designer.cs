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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textCreditoAdicional = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBuscaNif = new System.Windows.Forms.TextBox();
            this.btnBuscarClientePorNif = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 25;
            this.listBoxClientes.Location = new System.Drawing.Point(228, 665);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(836, 154);
            this.listBoxClientes.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "NIF  :";
            // 
            // textAporteCredito
            // 
            this.textAporteCredito.Location = new System.Drawing.Point(289, 237);
            this.textAporteCredito.Name = "textAporteCredito";
            this.textAporteCredito.Size = new System.Drawing.Size(244, 31);
            this.textAporteCredito.TabIndex = 40;
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(289, 158);
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(244, 31);
            this.textNif.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Crédito Inicial :";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(289, 90);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(244, 31);
            this.textNome.TabIndex = 30;
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Location = new System.Drawing.Point(552, 490);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(187, 63);
            this.btnListarCliente.TabIndex = 32;
            this.btnListarCliente.Text = "Listar Cliente";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            this.btnListarCliente.Click += new System.EventHandler(this.btnListarCliente_Click);
            // 
            // btnGravarFuncionario
            // 
            this.btnGravarFuncionario.Location = new System.Drawing.Point(325, 490);
            this.btnGravarFuncionario.Name = "btnGravarFuncionario";
            this.btnGravarFuncionario.Size = new System.Drawing.Size(187, 63);
            this.btnGravarFuncionario.TabIndex = 33;
            this.btnGravarFuncionario.Text = "Gravar Cliente";
            this.btnGravarFuncionario.UseVisualStyleBackColor = true;
            this.btnGravarFuncionario.Click += new System.EventHandler(this.btnGravarCliente_Click);
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Location = new System.Drawing.Point(767, 588);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(187, 63);
            this.btnVoltarMenu.TabIndex = 34;
            this.btnVoltarMenu.Text = "Voltar Menu Principal";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnInativarCliente
            // 
            this.btnInativarCliente.Location = new System.Drawing.Point(767, 490);
            this.btnInativarCliente.Name = "btnInativarCliente";
            this.btnInativarCliente.Size = new System.Drawing.Size(187, 63);
            this.btnInativarCliente.TabIndex = 36;
            this.btnInativarCliente.Text = "Inativar Cliente";
            this.btnInativarCliente.UseVisualStyleBackColor = true;
            this.btnInativarCliente.MouseCaptureChanged += new System.EventHandler(this.btnInativarCliente_Click);
            // 
            // btnGravarEdicao
            // 
            this.btnGravarEdicao.Location = new System.Drawing.Point(552, 588);
            this.btnGravarEdicao.Name = "btnGravarEdicao";
            this.btnGravarEdicao.Size = new System.Drawing.Size(187, 63);
            this.btnGravarEdicao.TabIndex = 38;
            this.btnGravarEdicao.Text = "Gravar Edição Cliente";
            this.btnGravarEdicao.UseVisualStyleBackColor = true;
            this.btnGravarEdicao.Click += new System.EventHandler(this.btnGravarEdicao_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(325, 588);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(187, 63);
            this.btnEditarCliente.TabIndex = 37;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.MouseCaptureChanged += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 63);
            this.button1.TabIndex = 41;
            this.button1.Text = "Adicionar crédito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdicionarCredito_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Aporte de Crédito :";
            // 
            // textCreditoAdicional
            // 
            this.textCreditoAdicional.Location = new System.Drawing.Point(289, 317);
            this.textCreditoAdicional.Name = "textCreditoAdicional";
            this.textCreditoAdicional.Size = new System.Drawing.Size(244, 31);
            this.textCreditoAdicional.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nif desejado";
            // 
            // textBuscaNif
            // 
            this.textBuscaNif.Location = new System.Drawing.Point(208, 58);
            this.textBuscaNif.Name = "textBuscaNif";
            this.textBuscaNif.Size = new System.Drawing.Size(308, 31);
            this.textBuscaNif.TabIndex = 45;
            // 
            // btnBuscarClientePorNif
            // 
            this.btnBuscarClientePorNif.Location = new System.Drawing.Point(241, 123);
            this.btnBuscarClientePorNif.Name = "btnBuscarClientePorNif";
            this.btnBuscarClientePorNif.Size = new System.Drawing.Size(135, 77);
            this.btnBuscarClientePorNif.TabIndex = 46;
            this.btnBuscarClientePorNif.Text = "Buscar";
            this.btnBuscarClientePorNif.UseVisualStyleBackColor = true;
            this.btnBuscarClientePorNif.Click += new System.EventHandler(this.btnBuscarClientePorNif_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarClientePorNif);
            this.groupBox1.Controls.Add(this.textBuscaNif);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(688, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 250);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca Por Nif";
            // 
            // FormEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 843);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textCreditoAdicional);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textCreditoAdicional;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBuscaNif;
        private System.Windows.Forms.Button btnBuscarClientePorNif;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}