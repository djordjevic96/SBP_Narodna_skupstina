namespace SBPNarodnaSkupstinaIIIDomaci
{
    partial class NarodniPoslanikForma
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStalniRadniOdnos = new System.Windows.Forms.Button();
            this.btnDodajStalniRadniOdnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodavanje narodnog poslanika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(599, 290);
            this.listBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(508, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Prikaz svih narodnih poslanika";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnStalniRadniOdnos
            // 
            this.btnStalniRadniOdnos.Location = new System.Drawing.Point(174, 13);
            this.btnStalniRadniOdnos.Name = "btnStalniRadniOdnos";
            this.btnStalniRadniOdnos.Size = new System.Drawing.Size(96, 52);
            this.btnStalniRadniOdnos.TabIndex = 5;
            this.btnStalniRadniOdnos.Text = "Stalni radni odnos";
            this.btnStalniRadniOdnos.UseVisualStyleBackColor = true;
            this.btnStalniRadniOdnos.Click += new System.EventHandler(this.btnStalniRadniOdnos_Click);
            // 
            // btnDodajStalniRadniOdnos
            // 
            this.btnDodajStalniRadniOdnos.Location = new System.Drawing.Point(323, 13);
            this.btnDodajStalniRadniOdnos.Name = "btnDodajStalniRadniOdnos";
            this.btnDodajStalniRadniOdnos.Size = new System.Drawing.Size(107, 52);
            this.btnDodajStalniRadniOdnos.TabIndex = 6;
            this.btnDodajStalniRadniOdnos.Text = "Dodaj stalni radni odnos";
            this.btnDodajStalniRadniOdnos.UseVisualStyleBackColor = true;
            this.btnDodajStalniRadniOdnos.Click += new System.EventHandler(this.btnDodajStalniRadniOdnos_Click);
            // 
            // NarodniPoslanikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 472);
            this.Controls.Add(this.btnDodajStalniRadniOdnos);
            this.Controls.Add(this.btnStalniRadniOdnos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "NarodniPoslanikForma";
            this.Text = "NarodniPoslanikForma";
            this.Load += new System.EventHandler(this.NarodniPoslanikForma_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStalniRadniOdnos;
        private System.Windows.Forms.Button btnDodajStalniRadniOdnos;
    }
}