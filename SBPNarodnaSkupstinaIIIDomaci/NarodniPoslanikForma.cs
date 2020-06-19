using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBPNarodnaSkupstinaIIIDomaci
{
    public partial class NarodniPoslanikForma : Form
    {
        DodavanjeNarodnogPoslanikaForma novaForma;
        StalniRadniOdnosForma forma;
        public NarodniPoslanikForma()
        {
            InitializeComponent();
            
        }

        private void NarodniPoslanikForma_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Dobro dosli");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            novaForma = new DodavanjeNarodnogPoslanikaForma();
            novaForma.Show();
        }

        private void btnPrikazNp_Click(object sender, EventArgs e)
        {
            //lwNarodniPoslanik.Items.Clear();
            //List<NarodniPoslanikDodaj> listanp = NarodniPoslanikManager.vratiSveNarodnePoslanike();
            //foreach(NarodniPoslanikDodaj p in listanp)
            //{
            //    //ListViewItem item = new ListViewItem();
            //    ListViewItem item = new ListViewItem(new string[] { p.LIme, p.SrednjeIme,p.prezime,p.mestoStanovanja,p.datumRodjenja.ToString() });
            //    lwNarodniPoslanik.Items.Add(item);
            //}
            //lwNarodniPoslanik.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lwNarodniPoslanik.Items.Clear();
            //List<NarodniPoslanikPregled> listanp = NarodniPoslanikManager.vratiSveNarodnePoslanikeZaPregled();
            //foreach (NarodniPoslanikPregled p in listanp)
            //{
            //    //ListViewItem item = new ListViewItem();
            //    ListViewItem item = new ListViewItem(new string[] { p.NarodniPoslanikID.ToString(), p.LIme, p.SrednjeIme, p.prezime,p.JMBG.ToString(),p.JIBNP.ToString() });
            //    lwNarodniPoslanik.Items.Add(item);
            //}
            //lwNarodniPoslanik.Refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                //NarodniPoslanikManager.VratiPoslanika(1);
                //listBox1.Items.Clear();
                //List<NarodniPoslanikPregled> listanp = NarodniPoslanikManager.vratiSveNarodnePoslanikeZaPregled();
                //for (int i = 0; i < listanp.Count; i++)
                //{
                //    listBox1.Items.Add(listanp[i].LIme + listanp[i].SrednjeIme + listanp[i].prezime);
                //}

                //VRLO VAZNO OBAVESTENJE: OVAJ KOD RADI U DEBUG REZIMU,TAKO DA SA SESIJOM JE NEGDE PROBLEM



                listBox1.Items.Clear();
                List<NarodniPoslanikDodaj> listnp = NarodniPoslanikManager.vratiSveNarodnePoslanike();
                for(int i=0;i<listnp.Count;i++)
                {
                    listBox1.Items.Add(listnp[i].LIme + "  " + listnp[i].SrednjeIme + "  " + listnp[i].prezime + " " + listnp[i].mestoStanovanja);//+"  "+listnp[i].pripada.ImeGrupe );
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnStalniRadniOdnos_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<StalniRadniOdnosPrikaz> listst = NarodniPoslanikManager.vratiSveIzStalnogRadnogOdnosa();
            for(int i=0;i<listst.Count;i++)
            {
                listBox1.Items.Add(listst[i].ID +"   " + listst[i].Mesec+"  " +listst[i].ImeFirme+"  "+listst[i].Godine);
            }
        }

        private void btnDodajStalniRadniOdnos_Click(object sender, EventArgs e)
        {
            forma = new StalniRadniOdnosForma();
            forma.Show();
        }
    }
}
