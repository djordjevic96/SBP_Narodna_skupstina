namespace SBPNarodnaSkupstinaIIIDomaci
{
    partial class DodavanjeRadnogTela
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbxTip = new System.Windows.Forms.ComboBox();
            this.txtIDsp = new System.Windows.Forms.TextBox();
            this.txtIDz = new System.Windows.Forms.TextBox();
            this.txtIDp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(86, 205);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(158, 23);
            this.btnDodaj.TabIndex = 19;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click_1);
            // 
            // cbxTip
            // 
            this.cbxTip.FormattingEnabled = true;
            this.cbxTip.Items.AddRange(new object[] {
            "STALNI RADNI ODBOR",
            "PRIVREMENI ODBOR",
            "ANKETNI ODBOR",
            "KOMISIJA"});
            this.cbxTip.Location = new System.Drawing.Point(158, 157);
            this.cbxTip.Name = "cbxTip";
            this.cbxTip.Size = new System.Drawing.Size(121, 21);
            this.cbxTip.TabIndex = 18;
            // 
            // txtIDsp
            // 
            this.txtIDsp.Location = new System.Drawing.Point(158, 121);
            this.txtIDsp.Name = "txtIDsp";
            this.txtIDsp.Size = new System.Drawing.Size(121, 20);
            this.txtIDsp.TabIndex = 17;
            // 
            // txtIDz
            // 
            this.txtIDz.Location = new System.Drawing.Point(158, 84);
            this.txtIDz.Name = "txtIDz";
            this.txtIDz.Size = new System.Drawing.Size(121, 20);
            this.txtIDz.TabIndex = 16;
            // 
            // txtIDp
            // 
            this.txtIDp.Location = new System.Drawing.Point(158, 49);
            this.txtIDp.Name = "txtIDp";
            this.txtIDp.Size = new System.Drawing.Size(121, 20);
            this.txtIDp.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tip:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID sluzbene prostorije:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID zamenika:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID predsednika:";
            // 
            // DodavanjeRadnogTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 276);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cbxTip);
            this.Controls.Add(this.txtIDsp);
            this.Controls.Add(this.txtIDz);
            this.Controls.Add(this.txtIDp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "DodavanjeRadnogTela";
            this.Text = "DodavanjeRadnogTela";
            this.Load += new System.EventHandler(this.DodavanjeRadnogTela_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbxTip;
        private System.Windows.Forms.TextBox txtIDsp;
        private System.Windows.Forms.TextBox txtIDz;
        private System.Windows.Forms.TextBox txtIDp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}