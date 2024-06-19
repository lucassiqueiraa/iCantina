namespace Cantina
{
    partial class MainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMultas = new System.Windows.Forms.Button();
            this.btnPratos = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReservas = new System.Windows.Forms.Button();
            this.btnMenus = new System.Windows.Forms.Button();
            this.btnExtras = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.funcionarioUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHoras = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listaMenus = new System.Windows.Forms.DataGridView();
            this.colCarne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPeixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVegetariano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMenus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.btnMultas);
            this.panel2.Controls.Add(this.btnPratos);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnReservas);
            this.panel2.Controls.Add(this.btnMenus);
            this.panel2.Controls.Add(this.btnExtras);
            this.panel2.Controls.Add(this.btnClientes);
            this.panel2.Controls.Add(this.funcionarioUsername);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnFuncionarios);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 375);
            this.panel2.TabIndex = 4;
            // 
            // btnMultas
            // 
            this.btnMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnMultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnMultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnMultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultas.ForeColor = System.Drawing.Color.White;
            this.btnMultas.Image = global::Cantina.Properties.Resources.multa;
            this.btnMultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMultas.Location = new System.Drawing.Point(11, 443);
            this.btnMultas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.Size = new System.Drawing.Size(200, 40);
            this.btnMultas.TabIndex = 12;
            this.btnMultas.Text = "Multas";
            this.btnMultas.UseVisualStyleBackColor = false;
            this.btnMultas.Click += new System.EventHandler(this.btnMultas_Click);
            // 
            // btnPratos
            // 
            this.btnPratos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnPratos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPratos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPratos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnPratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPratos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPratos.ForeColor = System.Drawing.Color.White;
            this.btnPratos.Image = global::Cantina.Properties.Resources.pratos2;
            this.btnPratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPratos.Location = new System.Drawing.Point(11, 125);
            this.btnPratos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPratos.Name = "btnPratos";
            this.btnPratos.Size = new System.Drawing.Size(200, 40);
            this.btnPratos.TabIndex = 11;
            this.btnPratos.Text = "Pratos";
            this.btnPratos.UseVisualStyleBackColor = false;
            this.btnPratos.Click += new System.EventHandler(this.btnPratos_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Cantina.Properties.Resources.logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(2, 503);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(59, 60);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReservas
            // 
            this.btnReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnReservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservas.ForeColor = System.Drawing.Color.White;
            this.btnReservas.Image = global::Cantina.Properties.Resources.reserva;
            this.btnReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservas.Location = new System.Drawing.Point(11, 284);
            this.btnReservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReservas.Name = "btnReservas";
            this.btnReservas.Size = new System.Drawing.Size(200, 40);
            this.btnReservas.TabIndex = 9;
            this.btnReservas.Text = "Reservas";
            this.btnReservas.UseVisualStyleBackColor = false;
            // 
            // btnMenus
            // 
            this.btnMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnMenus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnMenus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnMenus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenus.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenus.ForeColor = System.Drawing.Color.White;
            this.btnMenus.Image = global::Cantina.Properties.Resources.menu;
            this.btnMenus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenus.Location = new System.Drawing.Point(11, 231);
            this.btnMenus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenus.Name = "btnMenus";
            this.btnMenus.Size = new System.Drawing.Size(200, 40);
            this.btnMenus.TabIndex = 8;
            this.btnMenus.Text = "Menus";
            this.btnMenus.UseVisualStyleBackColor = false;
            this.btnMenus.Click += new System.EventHandler(this.btnMenus_Click);
            // 
            // btnExtras
            // 
            this.btnExtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnExtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnExtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnExtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtras.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtras.ForeColor = System.Drawing.Color.White;
            this.btnExtras.Image = global::Cantina.Properties.Resources.extra;
            this.btnExtras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtras.Location = new System.Drawing.Point(11, 178);
            this.btnExtras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExtras.Name = "btnExtras";
            this.btnExtras.Size = new System.Drawing.Size(200, 40);
            this.btnExtras.TabIndex = 10;
            this.btnExtras.Text = "Extras";
            this.btnExtras.UseVisualStyleBackColor = false;
            this.btnExtras.Click += new System.EventHandler(this.btnExtras_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = global::Cantina.Properties.Resources.icons8_client_management_50;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(11, 337);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 40);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // funcionarioUsername
            // 
            this.funcionarioUsername.AutoSize = true;
            this.funcionarioUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionarioUsername.ForeColor = System.Drawing.Color.White;
            this.funcionarioUsername.Location = new System.Drawing.Point(41, 88);
            this.funcionarioUsername.Name = "funcionarioUsername";
            this.funcionarioUsername.Size = new System.Drawing.Size(97, 19);
            this.funcionarioUsername.TabIndex = 5;
            this.funcionarioUsername.Text = "Bem-Vindo, ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cantina.Properties.Resources.team;
            this.pictureBox1.Location = new System.Drawing.Point(58, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.btnFuncionarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFuncionarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnFuncionarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionarios.ForeColor = System.Drawing.Color.White;
            this.btnFuncionarios.Image = global::Cantina.Properties.Resources.icons8_management_50;
            this.btnFuncionarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionarios.Location = new System.Drawing.Point(11, 390);
            this.btnFuncionarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(200, 40);
            this.btnFuncionarios.TabIndex = 0;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1073, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "iCantina Management System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 35);
            this.panel1.TabIndex = 3;
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.Location = new System.Drawing.Point(1002, 48);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(62, 19);
            this.lblHoras.TabIndex = 5;
            this.lblHoras.Text = "Horário";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(546, 144);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // listaMenus
            // 
            this.listaMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaMenus.BackgroundColor = System.Drawing.SystemColors.Control;
            this.listaMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaMenus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCarne,
            this.colPeixe,
            this.colVegetariano});
            this.listaMenus.Location = new System.Drawing.Point(431, 347);
            this.listaMenus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaMenus.Name = "listaMenus";
            this.listaMenus.RowHeadersWidth = 82;
            this.listaMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaMenus.Size = new System.Drawing.Size(480, 118);
            this.listaMenus.TabIndex = 8;
            // 
            // colCarne
            // 
            this.colCarne.HeaderText = "Carne";
            this.colCarne.MinimumWidth = 10;
            this.colCarne.Name = "colCarne";
            // 
            // colPeixe
            // 
            this.colPeixe.HeaderText = "Peixe";
            this.colPeixe.MinimumWidth = 10;
            this.colPeixe.Name = "colPeixe";
            // 
            // colVegetariano
            // 
            this.colVegetariano.HeaderText = "Vegetariano";
            this.colVegetariano.MinimumWidth = 10;
            this.colVegetariano.Name = "colVegetariano";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 410);
            this.Controls.Add(this.listaMenus);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMenus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label funcionarioUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenus;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMultas;
        private System.Windows.Forms.Button btnPratos;
        private System.Windows.Forms.Button btnReservas;
        private System.Windows.Forms.Button btnExtras;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView listaMenus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVegetariano;
    }
}

