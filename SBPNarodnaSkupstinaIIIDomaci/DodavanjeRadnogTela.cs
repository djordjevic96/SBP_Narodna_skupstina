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
using NHibernate.Linq;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;
using NHibernate.Criterion;

namespace SBPNarodnaSkupstinaIIIDomaci
{
    public partial class DodavanjeRadnogTela : Form
    {
        public DodajRadnoTelo oRadnoTelo;
        public DodavanjeRadnogTela()
        {
            InitializeComponent();
        }

        private void DodavanjeRadnogTela_Load(object sender, EventArgs e)
        {

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
        }

        private void DodavanjeRadnogTela_Load_1(object sender, EventArgs e)
        {
            //oRadnoTelo = new DodajRadnoTelo();
            //try
            //{
            //    ISession s = DataLayer.GetSession();
            //    oRadnoTelo.TipRadnogTela = cbxTip.Text;
            //    oRadnoTelo.PredsednikRadnogTela = s.Load<NarodniPoslanik>(Int16.Parse(txtIDp.Text));
            //    oRadnoTelo.ZamenikPredsednika = s.Load<NarodniPoslanik>(Int16.Parse(txtIDz.Text));
            //    oRadnoTelo.SluzbenaProstorija = s.Load<SluzbenaProstorija>(Int16.Parse(txtIDsp.Text));

            //    s.Close();
            //}
            //catch (Exception ec)
            //{
            //    MessageBox.Show(ec.Message);
            //}

            //RadnoTeloManager.dodajRadnoTelo(oRadnoTelo);
        }

        private void btnDodaj_Click_1(object sender, EventArgs e)
        {
            oRadnoTelo = new DodajRadnoTelo();
            try
            {
                ISession s = DataLayer.GetSession();
                oRadnoTelo.TipRadnogTela = cbxTip.Text;
                int id = Int16.Parse(txtIDp.Text);
                oRadnoTelo.PredsednikRadnogTela = s.Load<NarodniPoslanik>(id);
                int id1 = Int16.Parse(txtIDz.Text);
                oRadnoTelo.ZamenikPredsednika = s.Load<NarodniPoslanik>(id1);
                int id2 = Int16.Parse(txtIDsp.Text);
                oRadnoTelo.SluzbenaProstorija = s.Load<SluzbenaProstorija>(id2);

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            RadnoTeloManager.dodajRadnoTelo(oRadnoTelo);
        }
    }
}
