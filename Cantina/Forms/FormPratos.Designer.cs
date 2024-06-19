namespace Cantina.Forms
{
    partial class FormPratos
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
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.radioButtonCarne = new System.Windows.Forms.RadioButton();
            this.radioButtonPeixe = new System.Windows.Forms.RadioButton();
            this.radioButtonVegetariano = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnEditarPrato = new System.Windows.Forms.Button();
            this.btnInativarPrato = new System.Windows.Forms.Button();
            this.listBoxPratos = new System.Windows.Forms.ListBox();
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            this.btnGravarPrato = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.groupBoxTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(321, 32);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(100, 20);
            this.textDescricao.TabIndex = 2;
            // 
            // radioButtonCarne
            // 
            this.radioButtonCarne.AutoSize = true;
            this.radioButtonCarne.Location = new System.Drawing.Point(27, 32);
            this.radioButtonCarne.Name = "radioButtonCarne";
            this.radioButtonCarne.Size = new System.Drawing.Size(53, 17);
            this.radioButtonCarne.TabIndex = 4;
            this.radioButtonCarne.TabStop = true;
            this.radioButtonCarne.Text = "Carne";
            this.radioButtonCarne.UseVisualStyleBackColor = true;
            // 
            // radioButtonPeixe
            // 
            this.radioButtonPeixe.AutoSize = true;
            this.radioButtonPeixe.Location = new System.Drawing.Point(97, 32);
            this.radioButtonPeixe.Name = "radioButtonPeixe";
            this.radioButtonPeixe.Size = new System.Drawing.Size(51, 17);
            this.radioButtonPeixe.TabIndex = 5;
            this.radioButtonPeixe.TabStop = true;
            this.radioButtonPeixe.Text = "Peixe";
            this.radioButtonPeixe.UseVisualStyleBackColor = true;
            // 
            // radioButtonVegetariano
            // 
            this.radioButtonVegetariano.AutoSize = true;
            this.radioButtonVegetariano.Location = new System.Drawing.Point(154, 32);
            this.radioButtonVegetariano.Name = "radioButtonVegetariano";
            this.radioButtonVegetariano.Size = new System.Drawing.Size(82, 17);
            this.radioButtonVegetariano.TabIndex = 6;
            this.radioButtonVegetariano.TabStop = true;
            this.radioButtonVegetariano.Text = "Vegetariano";
            this.radioButtonVegetariano.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(343, 188);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(94, 33);
            this.btnGravar.TabIndex = 32;
            this.btnGravar.Text = "Gravar Edição Funcionario";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnEditarPrato
            // 
            this.btnEditarPrato.Location = new System.Drawing.Point(229, 188);
            this.btnEditarPrato.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarPrato.Name = "btnEditarPrato";
            this.btnEditarPrato.Size = new System.Drawing.Size(94, 33);
            this.btnEditarPrato.TabIndex = 31;
            this.btnEditarPrato.Text = "Editar Funcionario";
            this.btnEditarPrato.UseVisualStyleBackColor = true;
            this.btnEditarPrato.Click += new System.EventHandler(this.btnEditarPrato_Click);
            // 
            // btnInativarPrato
            // 
            this.btnInativarPrato.Location = new System.Drawing.Point(450, 137);
            this.btnInativarPrato.Margin = new System.Windows.Forms.Padding(2);
            this.btnInativarPrato.Name = "btnInativarPrato";
            this.btnInativarPrato.Size = new System.Drawing.Size(94, 33);
            this.btnInativarPrato.TabIndex = 30;
            this.btnInativarPrato.Text = "Inativar Funcionario";
            this.btnInativarPrato.UseVisualStyleBackColor = true;
            this.btnInativarPrato.Click += new System.EventHandler(this.btnInativarPrato_Click);
            // 
            // listBoxPratos
            // 
            this.listBoxPratos.FormattingEnabled = true;
            this.listBoxPratos.Location = new System.Drawing.Point(191, 258);
            this.listBoxPratos.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxPratos.Name = "listBoxPratos";
            this.listBoxPratos.Size = new System.Drawing.Size(420, 82);
            this.listBoxPratos.TabIndex = 29;
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Location = new System.Drawing.Point(450, 188);
            this.btnVoltarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(94, 33);
            this.btnVoltarMenu.TabIndex = 28;
            this.btnVoltarMenu.Text = "Voltar Menu Principal";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // btnGravarPrato
            // 
            this.btnGravarPrato.Location = new System.Drawing.Point(229, 137);
            this.btnGravarPrato.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravarPrato.Name = "btnGravarPrato";
            this.btnGravarPrato.Size = new System.Drawing.Size(94, 33);
            this.btnGravarPrato.TabIndex = 27;
            this.btnGravarPrato.Text = "Gravar Funcionario";
            this.btnGravarPrato.UseVisualStyleBackColor = true;
            this.btnGravarPrato.Click += new System.EventHandler(this.btnGravarPrato_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(343, 137);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 33);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir Prato";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.radioButtonVegetariano);
            this.groupBoxTipo.Controls.Add(this.radioButtonCarne);
            this.groupBoxTipo.Controls.Add(this.radioButtonPeixe);
            this.groupBoxTipo.Location = new System.Drawing.Point(253, 58);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(259, 74);
            this.groupBoxTipo.TabIndex = 33;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo do Prato";
            // 
            // FormPratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnEditarPrato);
            this.Controls.Add(this.btnInativarPrato);
            this.Controls.Add(this.listBoxPratos);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.btnGravarPrato);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.label1);
            this.Name = "FormPratos";
            this.Text = "FormPratos";
            this.Load += new System.EventHandler(this.FormPratos_Load);
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.RadioButton radioButtonCarne;
        private System.Windows.Forms.RadioButton radioButtonPeixe;
        private System.Windows.Forms.RadioButton radioButtonVegetariano;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnEditarPrato;
        private System.Windows.Forms.Button btnInativarPrato;
        private System.Windows.Forms.ListBox listBoxPratos;
        private System.Windows.Forms.Button btnVoltarMenu;
        private System.Windows.Forms.Button btnGravarPrato;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox groupBoxTipo;
    }
}