namespace Cantina.Forms
{
    partial class FormGestaoClientes
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
            this.btnGravarFuncionario = new System.Windows.Forms.Button();
            this.btnListarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGravarFuncionario
            // 
            this.btnGravarFuncionario.Location = new System.Drawing.Point(162, 157);
            this.btnGravarFuncionario.Name = "btnGravarFuncionario";
            this.btnGravarFuncionario.Size = new System.Drawing.Size(250, 190);
            this.btnGravarFuncionario.TabIndex = 20;
            this.btnGravarFuncionario.Text = "Cliente Estudante";
            this.btnGravarFuncionario.UseVisualStyleBackColor = true;
            this.btnGravarFuncionario.Click += new System.EventHandler(this.btnGravarFuncionario_Click);
            // 
            // btnListarCliente
            // 
            this.btnListarCliente.Location = new System.Drawing.Point(487, 157);
            this.btnListarCliente.Name = "btnListarCliente";
            this.btnListarCliente.Size = new System.Drawing.Size(237, 190);
            this.btnListarCliente.TabIndex = 19;
            this.btnListarCliente.Text = "Cliente Professor";
            this.btnListarCliente.UseVisualStyleBackColor = true;
            this.btnListarCliente.Click += new System.EventHandler(this.btnListarCliente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 134);
            this.button1.TabIndex = 21;
            this.button1.Text = "Menu Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormGestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 770);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGravarFuncionario);
            this.Controls.Add(this.btnListarCliente);
            this.Name = "FormGestaoClientes";
            this.Text = "FormGestaoClientes";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGravarFuncionario;
        private System.Windows.Forms.Button btnListarCliente;
        private System.Windows.Forms.Button button1;
    }
}