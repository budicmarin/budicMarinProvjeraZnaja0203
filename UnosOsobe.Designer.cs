namespace budicMarinProvjeraZnaja0203
{
    partial class UnosOsobe
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelIme = new System.Windows.Forms.Label();
            this.labelPrezime = new System.Windows.Forms.Label();
            this.labelOIB = new System.Windows.Forms.Label();
            this.labelDatumRod = new System.Windows.Forms.Label();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxOIB = new System.Windows.Forms.TextBox();
            this.dateTimePickerDatum = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(52, 355);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(454, 355);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelIme
            // 
            this.labelIme.AutoSize = true;
            this.labelIme.Location = new System.Drawing.Point(36, 39);
            this.labelIme.Name = "labelIme";
            this.labelIme.Size = new System.Drawing.Size(34, 17);
            this.labelIme.TabIndex = 2;
            this.labelIme.Text = "Ime:";
            // 
            // labelPrezime
            // 
            this.labelPrezime.AutoSize = true;
            this.labelPrezime.Location = new System.Drawing.Point(409, 39);
            this.labelPrezime.Name = "labelPrezime";
            this.labelPrezime.Size = new System.Drawing.Size(63, 17);
            this.labelPrezime.TabIndex = 3;
            this.labelPrezime.Text = "Prezime:";
            // 
            // labelOIB
            // 
            this.labelOIB.AutoSize = true;
            this.labelOIB.Location = new System.Drawing.Point(36, 105);
            this.labelOIB.Name = "labelOIB";
            this.labelOIB.Size = new System.Drawing.Size(31, 17);
            this.labelOIB.TabIndex = 4;
            this.labelOIB.Text = "OIB";
            // 
            // labelDatumRod
            // 
            this.labelDatumRod.AutoSize = true;
            this.labelDatumRod.Location = new System.Drawing.Point(409, 105);
            this.labelDatumRod.Name = "labelDatumRod";
            this.labelDatumRod.Size = new System.Drawing.Size(49, 17);
            this.labelDatumRod.TabIndex = 5;
            this.labelDatumRod.Text = "Datum";
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(39, 60);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 22);
            this.textBoxIme.TabIndex = 6;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(412, 60);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrezime.TabIndex = 7;
            // 
            // textBoxOIB
            // 
            this.textBoxOIB.Location = new System.Drawing.Point(39, 125);
            this.textBoxOIB.Name = "textBoxOIB";
            this.textBoxOIB.Size = new System.Drawing.Size(100, 22);
            this.textBoxOIB.TabIndex = 8;
            // 
            // dateTimePickerDatum
            // 
            this.dateTimePickerDatum.Location = new System.Drawing.Point(412, 126);
            this.dateTimePickerDatum.Name = "dateTimePickerDatum";
            this.dateTimePickerDatum.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDatum.TabIndex = 9;
            // 
            // UnosOsobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerDatum);
            this.Controls.Add(this.textBoxOIB);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.labelDatumRod);
            this.Controls.Add(this.labelOIB);
            this.Controls.Add(this.labelPrezime);
            this.Controls.Add(this.labelIme);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Name = "UnosOsobe";
            this.Text = "UnosOsobe";
            this.Load += new System.EventHandler(this.UnosOsobe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelIme;
        private System.Windows.Forms.Label labelPrezime;
        private System.Windows.Forms.Label labelOIB;
        private System.Windows.Forms.Label labelDatumRod;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxOIB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatum;
    }
}