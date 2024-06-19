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
            this.btnExcluir = new System.Windows.Forms.Button();
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
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(149, 364);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(559, 100);
            this.listBoxClientes.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "NIF  :";
            // 
            // textAporteCredito
            // 
            this.textAporteCredito.Location = new System.Drawing.Point(192, 123);
            this.textAporteCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textAporteCredito.Name = "textAporteCredito";
            this.textAporteCredito.Size = new System.Drawing.Size(164, 23);
            this.textAporteCredito.TabIndex = 40;
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(192, 73);
            this.textNif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(164, 23);
            this.textNif.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Crédito Inicial :";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(192, 30);
            this.textNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(164, 23);
            this.textNome.TabIndex = 30;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(359, 261);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(125, 41);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.Text = "Excluir Cliente";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravarFuncionario
            // 
            this.btnGravarFuncionario.Location = new System.Drawing.Point(207, 261);
            this.btnGravarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravarFuncionario.Name = "btnGravarFuncionario";
            this.btnGravarFuncionario.Size = new System.Drawing.Size(125, 41);
            this.btnGravarFuncionario.TabIndex = 33;
            this.btnGravarFuncionario.Text = "Gravar Cliente";
            this.btnGravarFuncionario.UseVisualStyleBackColor = true;
            this.btnGravarFuncionario.Click += new System.EventHandler(this.btnGravarCliente_Click);
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Location = new System.Drawing.Point(503, 319);
            this.btnVoltarMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(125, 41);
            this.btnVoltarMenu.TabIndex = 34;
            this.btnVoltarMenu.Text = "Voltar Menu Principal";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnInativarCliente
            // 
            this.btnInativarCliente.Location = new System.Drawing.Point(503, 261);
            this.btnInativarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInativarCliente.Name = "btnInativarCliente";
            this.btnInativarCliente.Size = new System.Drawing.Size(125, 41);
            this.btnInativarCliente.TabIndex = 36;
            this.btnInativarCliente.Text = "Inativar Cliente";
            this.btnInativarCliente.UseVisualStyleBackColor = true;
            this.btnInativarCliente.MouseCaptureChanged += new System.EventHandler(this.btnInativarCliente_Click);
            // 
            // btnGravarEdicao
            // 
            this.btnGravarEdicao.Location = new System.Drawing.Point(359, 319);
            this.btnGravarEdicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravarEdicao.Name = "btnGravarEdicao";
            this.btnGravarEdicao.Size = new System.Drawing.Size(125, 41);
            this.btnGravarEdicao.TabIndex = 38;
            this.btnGravarEdicao.Text = "Gravar Edição Cliente";
            this.btnGravarEdicao.UseVisualStyleBackColor = true;
            this.btnGravarEdicao.Click += new System.EventHandler(this.btnGravarEdicao_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(207, 319);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(125, 41);
            this.btnEditarCliente.TabIndex = 37;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.MouseCaptureChanged += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 188);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 41;
            this.button1.Text = "Adicionar crédito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdicionarCredito_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Aporte de Crédito :";
            // 
            // textCreditoAdicional
            // 
            this.textCreditoAdicional.Location = new System.Drawing.Point(192, 175);
            this.textCreditoAdicional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCreditoAdicional.Name = "textCreditoAdicional";
            this.textCreditoAdicional.Size = new System.Drawing.Size(164, 23);
            this.textCreditoAdicional.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nif desejado";
            // 
            // textBuscaNif
            // 
            this.textBuscaNif.Location = new System.Drawing.Point(139, 37);
            this.textBuscaNif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBuscaNif.Name = "textBuscaNif";
            this.textBuscaNif.Size = new System.Drawing.Size(207, 23);
            this.textBuscaNif.TabIndex = 45;
            // 
            // btnBuscarClientePorNif
            // 
            this.btnBuscarClientePorNif.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarClientePorNif.Location = new System.Drawing.Point(160, 79);
            this.btnBuscarClientePorNif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarClientePorNif.Name = "btnBuscarClientePorNif";
            this.btnBuscarClientePorNif.Size = new System.Drawing.Size(91, 49);
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
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(459, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(376, 160);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca Por Nif";
            // 
            // FormEstudante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(865, 479);
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
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.textNif);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEstudante";
            this.Text = "FormEstudante";
            this.Load += new System.EventHandler(this.FormEstudante_Load);
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
        private System.Windows.Forms.Button btnExcluir;
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