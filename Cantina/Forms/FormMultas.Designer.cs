namespace Cantina.Forms
{
    partial class FormMultas
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxMultas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "Voltar Menu Principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnVoltarMenu_Click);
            // 
            // listBoxMultas
            // 
            this.listBoxMultas.FormattingEnabled = true;
            this.listBoxMultas.ItemHeight = 25;
            this.listBoxMultas.Location = new System.Drawing.Point(70, 59);
            this.listBoxMultas.Name = "listBoxMultas";
            this.listBoxMultas.Size = new System.Drawing.Size(655, 229);
            this.listBoxMultas.TabIndex = 1;
            // 
            // FormMultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxMultas);
            this.Controls.Add(this.button1);
            this.Name = "FormMultas";
            this.Text = "FormMultas";
            this.Load += new System.EventHandler(this.FormMultas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxMultas;
    }
}