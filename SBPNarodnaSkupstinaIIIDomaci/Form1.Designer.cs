namespace SBPNarodnaSkupstinaIIIDomaci
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
            this.NarodniPoslanikForma = new System.Windows.Forms.Button();
            this.btnPoslanickeGrupe = new System.Windows.Forms.Button();
            this.btnSednica = new System.Windows.Forms.Button();
            this.btnPravniAkt = new System.Windows.Forms.Button();
            this.btnRadnoTelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NarodniPoslanikForma
            // 
            this.NarodniPoslanikForma.Location = new System.Drawing.Point(36, 28);
            this.NarodniPoslanikForma.Name = "NarodniPoslanikForma";
            this.NarodniPoslanikForma.Size = new System.Drawing.Size(122, 70);
            this.NarodniPoslanikForma.TabIndex = 0;
            this.NarodniPoslanikForma.Text = "Narodni poslanik";
            this.NarodniPoslanikForma.UseVisualStyleBackColor = true;
            this.NarodniPoslanikForma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPoslanickeGrupe
            // 
            this.btnPoslanickeGrupe.Location = new System.Drawing.Point(195, 28);
            this.btnPoslanickeGrupe.Name = "btnPoslanickeGrupe";
            this.btnPoslanickeGrupe.Size = new System.Drawing.Size(142, 70);
            this.btnPoslanickeGrupe.TabIndex = 1;
            this.btnPoslanickeGrupe.Text = "Poslanicke grupe";
            this.btnPoslanickeGrupe.UseVisualStyleBackColor = true;
            this.btnPoslanickeGrupe.Click += new System.EventHandler(this.btnPoslanickeGrupe_Click);
            // 
            // btnSednica
            // 
            this.btnSednica.Location = new System.Drawing.Point(91, 151);
            this.btnSednica.Name = "btnSednica";
            this.btnSednica.Size = new System.Drawing.Size(117, 66);
            this.btnSednica.TabIndex = 2;
            this.btnSednica.Text = "Sednica";
            this.btnSednica.UseVisualStyleBackColor = true;
            this.btnSednica.Click += new System.EventHandler(this.btnSednica_Click);
            // 
            // btnPravniAkt
            // 
            this.btnPravniAkt.Location = new System.Drawing.Point(365, 28);
            this.btnPravniAkt.Name = "btnPravniAkt";
            this.btnPravniAkt.Size = new System.Drawing.Size(136, 70);
            this.btnPravniAkt.TabIndex = 3;
            this.btnPravniAkt.Text = "Pravni akt";
            this.btnPravniAkt.UseVisualStyleBackColor = true;
            this.btnPravniAkt.Click += new System.EventHandler(this.btnPravniAkt_Click);
            // 
            // btnRadnoTelo
            // 
            this.btnRadnoTelo.Location = new System.Drawing.Point(314, 151);
            this.btnRadnoTelo.Name = "btnRadnoTelo";
            this.btnRadnoTelo.Size = new System.Drawing.Size(134, 66);
            this.btnRadnoTelo.TabIndex = 4;
            this.btnRadnoTelo.Text = "Radno telo";
            this.btnRadnoTelo.UseVisualStyleBackColor = true;
            this.btnRadnoTelo.Click += new System.EventHandler(this.btnRadnoTelo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 265);
            this.Controls.Add(this.btnRadnoTelo);
            this.Controls.Add(this.btnPravniAkt);
            this.Controls.Add(this.btnSednica);
            this.Controls.Add(this.btnPoslanickeGrupe);
            this.Controls.Add(this.NarodniPoslanikForma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NarodniPoslanikForma;
        private System.Windows.Forms.Button btnPoslanickeGrupe;
        private System.Windows.Forms.Button btnSednica;
        private System.Windows.Forms.Button btnPravniAkt;
        private System.Windows.Forms.Button btnRadnoTelo;
    }
}

