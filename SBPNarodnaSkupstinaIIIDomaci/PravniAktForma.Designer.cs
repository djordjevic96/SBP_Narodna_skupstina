namespace SBPNarodnaSkupstinaIIIDomaci
{
    partial class PravniAktForma
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdPA = new System.Windows.Forms.TextBox();
            this.txtBrojBiraca = new System.Windows.Forms.TextBox();
            this.btnPromeni = new System.Windows.Forms.Button();
            this.cbxKJPA = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(281, 8);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(289, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Pravnog Akta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj biraca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ko je predlozio akt:";
            // 
            // txtIdPA
            // 
            this.txtIdPA.Location = new System.Drawing.Point(134, 24);
            this.txtIdPA.Name = "txtIdPA";
            this.txtIdPA.Size = new System.Drawing.Size(121, 20);
            this.txtIdPA.TabIndex = 5;
            // 
            // txtBrojBiraca
            // 
            this.txtBrojBiraca.Location = new System.Drawing.Point(134, 58);
            this.txtBrojBiraca.Name = "txtBrojBiraca";
            this.txtBrojBiraca.Size = new System.Drawing.Size(121, 20);
            this.txtBrojBiraca.TabIndex = 6;
            // 
            // btnPromeni
            // 
            this.btnPromeni.Location = new System.Drawing.Point(66, 153);
            this.btnPromeni.Name = "btnPromeni";
            this.btnPromeni.Size = new System.Drawing.Size(131, 43);
            this.btnPromeni.TabIndex = 7;
            this.btnPromeni.Text = "Promeni";
            this.btnPromeni.UseVisualStyleBackColor = true;
            this.btnPromeni.Click += new System.EventHandler(this.btnPromeni_Click);
            // 
            // cbxKJPA
            // 
            this.cbxKJPA.FormattingEnabled = true;
            this.cbxKJPA.Items.AddRange(new object[] {
            "VLADA",
            "NARODNI POSLANICI",
            "BIRACI"});
            this.cbxKJPA.Location = new System.Drawing.Point(134, 98);
            this.cbxKJPA.Name = "cbxKJPA";
            this.cbxKJPA.Size = new System.Drawing.Size(121, 21);
            this.cbxKJPA.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "Dodaj novi pravni akt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PravniAktForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 313);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbxKJPA);
            this.Controls.Add(this.btnPromeni);
            this.Controls.Add(this.txtBrojBiraca);
            this.Controls.Add(this.txtIdPA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "PravniAktForma";
            this.Text = "PravniAktForma";
            this.Load += new System.EventHandler(this.PravniAktForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdPA;
        private System.Windows.Forms.TextBox txtBrojBiraca;
        private System.Windows.Forms.Button btnPromeni;
        private System.Windows.Forms.ComboBox cbxKJPA;
        private System.Windows.Forms.Button button1;
    }
}