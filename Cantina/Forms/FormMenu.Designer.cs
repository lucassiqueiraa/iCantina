namespace Cantina.Forms
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.qtd = new System.Windows.Forms.NumericUpDown();
            this.txtPrecoEstudante = new System.Windows.Forms.TextBox();
            this.txtPrecoProf = new System.Windows.Forms.TextBox();
            this.comboBoxPratos = new System.Windows.Forms.ComboBox();
            this.comboBoxExtras = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dataGridViewMenus = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtdDisponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoEstudante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pratos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Extras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSet1 = new Cantina.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnVoltarMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço Estudante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço Professor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pratos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(70, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Extras:";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(130, 22);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 6;
            this.dateTime.Value = new System.DateTime(2024, 6, 19, 0, 0, 0, 0);
            // 
            // qtd
            // 
            this.qtd.Location = new System.Drawing.Point(131, 52);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(120, 20);
            this.qtd.TabIndex = 7;
            // 
            // txtPrecoEstudante
            // 
            this.txtPrecoEstudante.Location = new System.Drawing.Point(130, 78);
            this.txtPrecoEstudante.Name = "txtPrecoEstudante";
            this.txtPrecoEstudante.Size = new System.Drawing.Size(121, 20);
            this.txtPrecoEstudante.TabIndex = 8;
            // 
            // txtPrecoProf
            // 
            this.txtPrecoProf.Location = new System.Drawing.Point(130, 104);
            this.txtPrecoProf.Name = "txtPrecoProf";
            this.txtPrecoProf.Size = new System.Drawing.Size(120, 20);
            this.txtPrecoProf.TabIndex = 9;
            // 
            // comboBoxPratos
            // 
            this.comboBoxPratos.FormattingEnabled = true;
            this.comboBoxPratos.Location = new System.Drawing.Point(130, 130);
            this.comboBoxPratos.Name = "comboBoxPratos";
            this.comboBoxPratos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPratos.TabIndex = 10;
            // 
            // comboBoxExtras
            // 
            this.comboBoxExtras.FormattingEnabled = true;
            this.comboBoxExtras.Location = new System.Drawing.Point(130, 162);
            this.comboBoxExtras.Name = "comboBoxExtras";
            this.comboBoxExtras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExtras.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(176, 193);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(46, 248);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(148, 248);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dataGridViewMenus
            // 
            this.dataGridViewMenus.AllowUserToOrderColumns = true;
            this.dataGridViewMenus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMenus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DataHora,
            this.QtdDisponivel,
            this.PrecoEstudante,
            this.PrecoProfessor,
            this.Pratos,
            this.Extras});
            this.dataGridViewMenus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewMenus.Location = new System.Drawing.Point(272, 84);
            this.dataGridViewMenus.MultiSelect = false;
            this.dataGridViewMenus.Name = "dataGridViewMenus";
            this.dataGridViewMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenus.Size = new System.Drawing.Size(526, 150);
            this.dataGridViewMenus.TabIndex = 15;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // DataHora
            // 
            this.DataHora.HeaderText = "Data";
            this.DataHora.Name = "DataHora";
            // 
            // QtdDisponivel
            // 
            this.QtdDisponivel.HeaderText = "Quantidade";
            this.QtdDisponivel.Name = "QtdDisponivel";
            // 
            // PrecoEstudante
            // 
            this.PrecoEstudante.HeaderText = "Preço Estudante";
            this.PrecoEstudante.Name = "PrecoEstudante";
            // 
            // PrecoProfessor
            // 
            this.PrecoProfessor.HeaderText = "Preço Professor";
            this.PrecoProfessor.Name = "PrecoProfessor";
            // 
            // Pratos
            // 
            this.Pratos.HeaderText = "Prato";
            this.Pratos.Name = "Pratos";
            // 
            // Extras
            // 
            this.Extras.HeaderText = "Extra";
            this.Extras.Name = "Extras";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // btnVoltarMenu
            // 
            this.btnVoltarMenu.Location = new System.Drawing.Point(103, 316);
            this.btnVoltarMenu.Name = "btnVoltarMenu";
            this.btnVoltarMenu.Size = new System.Drawing.Size(75, 23);
            this.btnVoltarMenu.TabIndex = 16;
            this.btnVoltarMenu.Text = "Voltar Menu";
            this.btnVoltarMenu.UseVisualStyleBackColor = true;
            this.btnVoltarMenu.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarMenu);
            this.Controls.Add(this.dataGridViewMenus);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.comboBoxExtras);
            this.Controls.Add(this.comboBoxPratos);
            this.Controls.Add(this.txtPrecoProf);
            this.Controls.Add(this.txtPrecoEstudante);
            this.Controls.Add(this.qtd);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qtd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.NumericUpDown qtd;
        private System.Windows.Forms.TextBox txtPrecoEstudante;
        private System.Windows.Forms.TextBox txtPrecoProf;
        private System.Windows.Forms.ComboBox comboBoxPratos;
        private System.Windows.Forms.ComboBox comboBoxExtras;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dataGridViewMenus;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtdDisponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoEstudante;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pratos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Extras;
        private System.Windows.Forms.Button btnVoltarMenu;
    }
}