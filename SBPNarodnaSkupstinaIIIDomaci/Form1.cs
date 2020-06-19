using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;


namespace SBPNarodnaSkupstinaIIIDomaci
{
    public partial class Form1 : Form
    {
        NarodniPoslanikForma npf;
        PoslanickaGrupaForma pgf;
        SednicaForma sf;
        PravniAktForma paf;
        RadnoTeloForma raf;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("DOBRO DOSLI U NARODNU SKUPSTINU, PRITISNITE OK");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            npf = new NarodniPoslanikForma();
            npf.Show();
        }

        private void btnPoslanickeGrupe_Click(object sender, EventArgs e)
        {
            pgf = new PoslanickaGrupaForma();
            pgf.Show();
        }

        private void btnSednica_Click(object sender, EventArgs e)
        {
            sf = new SednicaForma();
            sf.Show();
        }

        private void btnPravniAkt_Click(object sender, EventArgs e)
        {
            paf = new PravniAktForma();
            paf.Show();
        }

        private void btnRadnoTelo_Click(object sender, EventArgs e)
        {
            raf = new RadnoTeloForma();
            raf.Show();
        }
    }
}
