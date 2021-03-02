namespace budicMarinProvjeraZnaja0203
{
    partial class Form1
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
            this.richTextBoxTablica = new System.Windows.Forms.RichTextBox();
            this.buttonUnesi = new System.Windows.Forms.Button();
            this.buttonObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxTablica
            // 
            this.richTextBoxTablica.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxTablica.Name = "richTextBoxTablica";
            this.richTextBoxTablica.Size = new System.Drawing.Size(776, 270);
            this.richTextBoxTablica.TabIndex = 0;
            this.richTextBoxTablica.Text = "";
            this.richTextBoxTablica.TextChanged += new System.EventHandler(this.richTextBoxTablica_TextChanged);
            // 
            // buttonUnesi
            // 
            this.buttonUnesi.Location = new System.Drawing.Point(12, 307);
            this.buttonUnesi.Name = "buttonUnesi";
            this.buttonUnesi.Size = new System.Drawing.Size(75, 23);
            this.buttonUnesi.TabIndex = 1;
            this.buttonUnesi.Text = "Unesi";
            this.buttonUnesi.UseVisualStyleBackColor = true;
            this.buttonUnesi.Click += new System.EventHandler(this.buttonUnesi_Click);
            // 
            // buttonObrisi
            // 
            this.buttonObrisi.Location = new System.Drawing.Point(713, 307);
            this.buttonObrisi.Name = "buttonObrisi";
            this.buttonObrisi.Size = new System.Drawing.Size(75, 23);
            this.buttonObrisi.TabIndex = 2;
            this.buttonObrisi.Text = "Obriši";
            this.buttonObrisi.UseVisualStyleBackColor = true;
            this.buttonObrisi.Click += new System.EventHandler(this.buttonObrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 344);
            this.Controls.Add(this.buttonObrisi);
            this.Controls.Add(this.buttonUnesi);
            this.Controls.Add(this.richTextBoxTablica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonUnesi;
        private System.Windows.Forms.Button buttonObrisi;
        public System.Windows.Forms.RichTextBox richTextBoxTablica;
    }
}

