namespace Cantina.Forms
{
    partial class FormReservas
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
            this.btnBuscarClientePorNif = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNif = new System.Windows.Forms.TextBox();
            this.listBoxMenus = new System.Windows.Forms.ListBox();
            this.listBoxExtras = new System.Windows.Forms.ListBox();
            this.btnReservarMenu = new System.Windows.Forms.Button();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.labelSaldoCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarClientePorNif
            // 
            this.btnBuscarClientePorNif.Location = new System.Drawing.Point(500, 6);
            this.btnBuscarClientePorNif.Name = "btnBuscarClientePorNif";
            this.btnBuscarClientePorNif.Size = new System.Drawing.Size(278, 81);
            this.btnBuscarClientePorNif.TabIndex = 0;
            this.btnBuscarClientePorNif.Text = "Buscar Cliente por Nif :";
            this.btnBuscarClientePorNif.UseVisualStyleBackColor = true;
            this.btnBuscarClientePorNif.Click += new System.EventHandler(this.btnBuscarClientePorNif_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nif do Cliente :";
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(213, 56);
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(262, 31);
            this.textNif.TabIndex = 2;
            // 
            // listBoxMenus
            // 
            this.listBoxMenus.FormattingEnabled = true;
            this.listBoxMenus.ItemHeight = 25;
            this.listBoxMenus.Location = new System.Drawing.Point(57, 300);
            this.listBoxMenus.Name = "listBoxMenus";
            this.listBoxMenus.Size = new System.Drawing.Size(747, 154);
            this.listBoxMenus.TabIndex = 3;
            this.listBoxMenus.SelectedIndexChanged += new System.EventHandler(this.listBoxMenus_SelectedIndexChanged);
            // 
            // listBoxExtras
            // 
            this.listBoxExtras.FormattingEnabled = true;
            this.listBoxExtras.ItemHeight = 25;
            this.listBoxExtras.Location = new System.Drawing.Point(57, 486);
            this.listBoxExtras.Name = "listBoxExtras";
            this.listBoxExtras.Size = new System.Drawing.Size(747, 129);
            this.listBoxExtras.TabIndex = 4;
            // 
            // btnReservarMenu
            // 
            this.btnReservarMenu.Location = new System.Drawing.Point(308, 660);
            this.btnReservarMenu.Name = "btnReservarMenu";
            this.btnReservarMenu.Size = new System.Drawing.Size(165, 80);
            this.btnReservarMenu.TabIndex = 5;
            this.btnReservarMenu.Text = "Reservar Menu";
            this.btnReservarMenu.UseVisualStyleBackColor = true;
            this.btnReservarMenu.Click += new System.EventHandler(this.btnReservarMenu_Click);
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(40, 137);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(181, 25);
            this.labelNomeCliente.TabIndex = 6;
            this.labelNomeCliente.Text = "labelNomeCliente";
            // 
            // labelSaldoCliente
            // 
            this.labelSaldoCliente.AutoSize = true;
            this.labelSaldoCliente.Location = new System.Drawing.Point(303, 137);
            this.labelSaldoCliente.Name = "labelSaldoCliente";
            this.labelSaldoCliente.Size = new System.Drawing.Size(180, 25);
            this.labelSaldoCliente.TabIndex = 7;
            this.labelSaldoCliente.Text = "labelSaldoCliente";
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 821);
            this.Controls.Add(this.labelSaldoCliente);
            this.Controls.Add(this.labelNomeCliente);
            this.Controls.Add(this.btnReservarMenu);
            this.Controls.Add(this.listBoxExtras);
            this.Controls.Add(this.listBoxMenus);
            this.Controls.Add(this.textNif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarClientePorNif);
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarClientePorNif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNif;
        private System.Windows.Forms.ListBox listBoxMenus;
        private System.Windows.Forms.ListBox listBoxExtras;
        private System.Windows.Forms.Button btnReservarMenu;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.Label labelSaldoCliente;
    }
}