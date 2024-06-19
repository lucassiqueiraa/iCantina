namespace Cantina.Forms
{
    partial class FormProfessor
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
            this.textAporteCredito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGravarEdicao = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnInativarCliente = new System.Windows.Forms.Button();
            this.listBoxProfessores = new System.Windows.Forms.ListBox();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnGravarFuncionario = new System.Windows.Forms.Button();
            this.btnListarCliente = new System.Windows.Forms.Button();
            this.textNif = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarClientePorNif = new System.Windows.Forms.Button();
            this.textBuscaNif = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCreditoAdicional = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textAporteCredito
            // 
            this.textAporteCredito.Location = new System.Drawing.Point(287, 175);
            this.textAporteCredito.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textAporteCredito.Name = "textAporteCredito";
            this.textAporteCredito.Size = new System.Drawing.Size(164, 23);
            this.textAporteCredito.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(125, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Crédito inicial :";
            // 
            // btnGravarEdicao
            // 
            this.btnGravarEdicao.Location = new System.Drawing.Point(312, 345);
            this.btnGravarEdicao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravarEdicao.Name = "btnGravarEdicao";
            this.btnGravarEdicao.Size = new System.Drawing.Size(125, 41);
            this.btnGravarEdicao.TabIndex = 38;
            this.btnGravarEdicao.Text = "Gravar Edição Professor";
            this.btnGravarEdicao.UseVisualStyleBackColor = true;
            this.btnGravarEdicao.Click += new System.EventHandler(this.btnGravarEdicao_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(161, 345);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(125, 41);
            this.btnEditarCliente.TabIndex = 37;
            this.btnEditarCliente.Text = "Editar Professor";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarProfessor_Click);
            // 
            // btnInativarCliente
            // 
            this.btnInativarCliente.Location = new System.Drawing.Point(456, 282);
            this.btnInativarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInativarCliente.Name = "btnInativarCliente";
            this.btnInativarCliente.Size = new System.Drawing.Size(125, 41);
            this.btnInativarCliente.TabIndex = 36;
            this.btnInativarCliente.Text = "Inativar Professor";
            this.btnInativarCliente.UseVisualStyleBackColor = true;
            this.btnInativarCliente.Click += new System.EventHandler(this.btnInativarProfessor_Click);
            // 
            // listBoxProfessores
            // 
            this.listBoxProfessores.FormattingEnabled = true;
            this.listBoxProfessores.ItemHeight = 16;
            this.listBoxProfessores.Location = new System.Drawing.Point(97, 402);
            this.listBoxProfessores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxProfessores.Name = "listBoxProfessores";
            this.listBoxProfessores.Size = new System.Drawing.Size(559, 100);
            this.listBoxProfessores.TabIndex = 35;
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Location = new System.Drawing.Point(456, 345);
            this.btnVoltarMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(125, 41);
            this.btnVoltarMenu.TabIndex = 34;
            this.btnVoltarMenu.Text = "Voltar Menu Principal";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnGravarFuncionario
            // 
            this.btnGravarFuncionario.Location = new System.Drawing.Point(161, 282);
            this.btnGravarFuncionario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGravarFuncionario.Name = "btnGravarFuncionario";
            this.btnGravarFuncionario.Size = new System.Drawing.Size(125, 41);
            this.btnGravarFuncionario.TabIndex = 33;
            this.btnGravarFuncionario.Text = "Gravar Professor";
            this.btnGravarFuncionario.UseVisualStyleBackColor = true;
            this.btnGravarFuncionario.Click += new System.EventHandler(this.btnGravarProfessor_Click);
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Location = new System.Drawing.Point(312, 282);
            this.btnListarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(125, 41);
            this.btnListarCliente.TabIndex = 32;
            this.btnListarCliente.Text = "Listar Professor";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            this.btnListarCliente.Click += new System.EventHandler(this.btnListarProfessores_Click);
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(287, 96);
            this.textNif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(164, 23);
            this.textNif.TabIndex = 31;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(287, 57);
            this.textNome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(164, 23);
            this.textNome.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(125, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "NIF  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(125, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome  :";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(287, 135);
            this.textEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(164, 23);
            this.textEmail.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(125, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Email  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarClientePorNif);
            this.groupBox1.Controls.Add(this.textBuscaNif);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(540, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(376, 160);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca Por Nif";
            // 
            // btnBuscarClientePorNif
            // 
            this.btnBuscarClientePorNif.Location = new System.Drawing.Point(160, 79);
            this.btnBuscarClientePorNif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscarClientePorNif.Name = "btnBuscarClientePorNif";
            this.btnBuscarClientePorNif.Size = new System.Drawing.Size(91, 49);
            this.btnBuscarClientePorNif.TabIndex = 46;
            this.btnBuscarClientePorNif.Text = "Buscar";
            this.btnBuscarClientePorNif.UseVisualStyleBackColor = true;
            this.btnBuscarClientePorNif.Click += new System.EventHandler(this.btnBuscarProfessorPorNif_Click);
            // 
            // textBuscaNif
            // 
            this.textBuscaNif.Location = new System.Drawing.Point(139, 37);
            this.textBuscaNif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBuscaNif.Name = "textBuscaNif";
            this.textBuscaNif.Size = new System.Drawing.Size(207, 23);
            this.textBuscaNif.TabIndex = 45;
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
            // textCreditoAdicional
            // 
            this.textCreditoAdicional.Location = new System.Drawing.Point(287, 213);
            this.textCreditoAdicional.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCreditoAdicional.Name = "textCreditoAdicional";
            this.textCreditoAdicional.Size = new System.Drawing.Size(164, 23);
            this.textCreditoAdicional.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(125, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 50;
            this.label6.Text = "Aporte de Crédito :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 213);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 49;
            this.button1.Text = "Adicionar crédito";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAdicionarCredito_Click);
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(913, 479);
            this.Controls.Add(this.textCreditoAdicional);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAporteCredito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGravarEdicao);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnInativarCliente);
            this.Controls.Add(this.listBoxProfessores);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.btnGravarFuncionario);
            this.Controls.Add(this.btnListarCliente);
            this.Controls.Add(this.textNif);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormProfessor";
            this.Text = "FormProfessor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textAporteCredito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGravarEdicao;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnInativarCliente;
        private System.Windows.Forms.ListBox listBoxProfessores;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Button btnGravarFuncionario;
        private System.Windows.Forms.Button btnListarCliente;
        private System.Windows.Forms.TextBox textNif;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarClientePorNif;
        private System.Windows.Forms.TextBox textBuscaNif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCreditoAdicional;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}