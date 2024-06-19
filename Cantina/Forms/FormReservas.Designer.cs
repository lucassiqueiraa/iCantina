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
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.labelSaldoCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textNif = new System.Windows.Forms.TextBox();
            this.btnBuscarClientePorNif = new System.Windows.Forms.Button();
            this.listBoxMenus = new System.Windows.Forms.ListBox();
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
            this.groupBox1.Location = new System.Drawing.Point(64, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busca Por Nif";
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Location = new System.Drawing.Point(49, 141);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(141, 25);
            this.labelNomeCliente.TabIndex = 0;
            this.labelNomeCliente.Text = "Nome Cliente";
            // 
            // labelSaldoCliente
            // 
            this.labelSaldoCliente.AutoSize = true;
            this.labelSaldoCliente.Location = new System.Drawing.Point(263, 141);
            this.labelSaldoCliente.Name = "labelSaldoCliente";
            this.labelSaldoCliente.Size = new System.Drawing.Size(67, 25);
            this.labelSaldoCliente.TabIndex = 1;
            this.labelSaldoCliente.Text = "Saldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nif : ";
            // 
            // textNif
            // 
            this.textNif.Location = new System.Drawing.Point(68, 47);
            this.textNif.Name = "textNif";
            this.textNif.Size = new System.Drawing.Size(189, 31);
            this.textNif.TabIndex = 3;
            // 
            // btnBuscarClientePorNif
            // 
            this.btnBuscarClientePorNif.Location = new System.Drawing.Point(309, 21);
            this.btnBuscarClientePorNif.Name = "btnBuscarClientePorNif";
            this.btnBuscarClientePorNif.Size = new System.Drawing.Size(134, 57);
            this.btnBuscarClientePorNif.TabIndex = 4;
            this.btnBuscarClientePorNif.Text = "Buscar";
            this.btnBuscarClientePorNif.UseVisualStyleBackColor = true;
            this.btnBuscarClientePorNif.Click += new System.EventHandler(this.btnBuscarClientePorNif_Click);
            // 
            // listBoxMenus
            // 
            this.listBoxMenus.FormattingEnabled = true;
            this.listBoxMenus.ItemHeight = 25;
            this.listBoxMenus.Location = new System.Drawing.Point(64, 313);
            this.listBoxMenus.Name = "listBoxMenus";
            this.listBoxMenus.Size = new System.Drawing.Size(774, 154);
            this.listBoxMenus.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(811, 632);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 93);
            this.button1.TabIndex = 2;
            this.button1.Text = "Menu Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxMenus);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Button button1;
    }
}