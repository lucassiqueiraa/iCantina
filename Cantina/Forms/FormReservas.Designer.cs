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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarClientePorNif = new System.Windows.Forms.Button();
            this.textNif = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSaldoCliente = new System.Windows.Forms.Label();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.listBoxMenus = new System.Windows.Forms.ListBox();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.listBoxExtras = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarClientePorNif);
            this.groupBox1.Controls.Add(this.textNif);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelSaldoCliente);
            this.groupBox1.Controls.Add(this.labelNomeCliente);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(32, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(222, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca Por Nif";
            // 
            // btnBuscarClientePorNif
            // 
            this.btnBuscarClientePorNif.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClientePorNif.Location = new System.Drawing.Point(154, 11);
            this.btnBuscarClientePorNif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarClientePorNif.Name = "btnBuscarClientePorNif";
            this.btnBuscarClientePorNif.Size = new System.Drawing.Size(67, 30);
            this.btnBuscarClientePorNif.TabIndex = 4;
            this.btnBuscarClientePorNif.Text = "Buscar";
            this.btnBuscarClientePorNif.UseVisualStyleBackColor = true;
            this.btnBuscarClientePorNif.Click += new System.EventHandler(this.btnBuscarClientePorNif_Click);
            // 
            // textNif
            // 
            this.textNif.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNif.Location = new System.Drawing.Point(34, 24);
            this.textNif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(96, 23);
            this.textNif.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nif : ";
            // 
            // labelSaldoCliente
            // 
            this.labelSaldoCliente.AutoSize = true;
            this.labelSaldoCliente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldoCliente.Location = new System.Drawing.Point(132, 73);
            this.labelSaldoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaldoCliente.Name = "labelSaldoCliente";
            this.labelSaldoCliente.Size = new System.Drawing.Size(42, 16);
            this.labelSaldoCliente.TabIndex = 1;
            this.labelSaldoCliente.Text = "Saldo";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(24, 73);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(90, 16);
            this.labelNomeCliente.TabIndex = 0;
            this.labelNomeCliente.Text = "Nome Cliente";
            // 
            // listBoxMenus
            // 
            this.listBoxMenus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxMenus.FormattingEnabled = true;
            this.listBoxMenus.ItemHeight = 16;
            this.listBoxMenus.Location = new System.Drawing.Point(32, 163);
            this.listBoxMenus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxMenus.Name = "listBoxMenus";
            this.listBoxMenus.Size = new System.Drawing.Size(389, 68);
            this.listBoxMenus.TabIndex = 1;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(438, 344);
            this.btnMenuPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(96, 40);
            this.btnMenuPrincipal.TabIndex = 2;
            this.btnMenuPrincipal.Text = "Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = true;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // listBoxExtras
            // 
            this.listBoxExtras.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxExtras.FormattingEnabled = true;
            this.listBoxExtras.ItemHeight = 16;
            this.listBoxExtras.Location = new System.Drawing.Point(32, 268);
            this.listBoxExtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxExtras.Name = "listBoxExtras";
            this.listBoxExtras.Size = new System.Drawing.Size(389, 68);
            this.listBoxExtras.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 344);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gerar Fatura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(556, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxExtras);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.listBoxMenus);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReservas";
            this.Text = "FormReservas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSaldoCliente;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.TextBox textNif;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarClientePorNif;
        private System.Windows.Forms.ListBox listBoxMenus;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.ListBox listBoxExtras;
        private System.Windows.Forms.Button button1;
    }
}