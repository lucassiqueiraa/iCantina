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
            this.dataSet1 = new Cantina.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qtd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço Estudante:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço Professor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pratos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Extras:";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(103, 24);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(200, 20);
            this.dateTime.TabIndex = 6;
            // 
            // qtd
            // 
            this.qtd.Location = new System.Drawing.Point(104, 54);
            this.qtd.Name = "qtd";
            this.qtd.Size = new System.Drawing.Size(120, 20);
            this.qtd.TabIndex = 7;
            // 
            // txtPrecoEstudante
            // 
            this.txtPrecoEstudante.Location = new System.Drawing.Point(103, 80);
            this.txtPrecoEstudante.Name = "txtPrecoEstudante";
            this.txtPrecoEstudante.Size = new System.Drawing.Size(121, 20);
            this.txtPrecoEstudante.TabIndex = 8;
            // 
            // txtPrecoProf
            // 
            this.txtPrecoProf.Location = new System.Drawing.Point(103, 106);
            this.txtPrecoProf.Name = "txtPrecoProf";
            this.txtPrecoProf.Size = new System.Drawing.Size(120, 20);
            this.txtPrecoProf.TabIndex = 9;
            // 
            // comboBoxPratos
            // 
            this.comboBoxPratos.FormattingEnabled = true;
            this.comboBoxPratos.Location = new System.Drawing.Point(103, 132);
            this.comboBoxPratos.Name = "comboBoxPratos";
            this.comboBoxPratos.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPratos.TabIndex = 10;
            // 
            // comboBoxExtras
            // 
            this.comboBoxExtras.FormattingEnabled = true;
            this.comboBoxExtras.Location = new System.Drawing.Point(103, 164);
            this.comboBoxExtras.Name = "comboBoxExtras";
            this.comboBoxExtras.Size = new System.Drawing.Size(121, 21);
            this.comboBoxExtras.TabIndex = 11;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(149, 195);
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
            this.dataGridViewMenus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewMenus.Location = new System.Drawing.Point(262, 80);
            this.dataGridViewMenus.MultiSelect = false;
            this.dataGridViewMenus.Name = "dataGridViewMenus";
            this.dataGridViewMenus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMenus.Size = new System.Drawing.Size(526, 150);
            this.dataGridViewMenus.TabIndex = 15;
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
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}