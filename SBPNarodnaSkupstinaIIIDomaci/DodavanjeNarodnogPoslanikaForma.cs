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
    public partial class DodavanjeNarodnogPoslanikaForma : Form
    {
        public NarodniPoslanikDodaj oNarodniPoslanik;
        public DodavanjeNarodnogPoslanikaForma()
        {
            InitializeComponent();
            dtpDatumRodjenja.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        public void validacijaPodataka()
        {
            if (txtIme.Text == "")
            {
                DialogResult dr = MessageBox.Show("Niste uneli ime narodnog poslanika", "Za unos imena pritisnite yes", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    txtIme.Focus();

                }

            }
            else
            {
                if (txtPrezime.Text == "")
                {
                    DialogResult dr = MessageBox.Show("Niste uneli Prezime narodnog poslanika", "Za unos imena pritisnite yes", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dr == DialogResult.Yes)
                    {
                        txtPrezime.Focus();

                    }
                }
                else
                {
                    if(txtMestoStanovanja.Text=="")
                    {
                        DialogResult dr = MessageBox.Show("Niste uneli mesto narodnog poslanika", "Za unos imena pritisnite yes", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dr == DialogResult.Yes)
                        {
                            txtMestoStanovanja.Focus();

                        }
                    }
                    else
                    {
                        if(txtUlica.Text=="")
                        {
                            DialogResult dr = MessageBox.Show("Niste uneli ulica narodnog poslanika", "Za unos imena pritisnite yes", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (dr == DialogResult.Yes)
                            {
                                txtUlica.Focus();

                            }
                        }
                    }
                }
            }
        }

        private void btnValidacija_Click(object sender, EventArgs e)
        {
            validacijaPodataka();
        }

        private void DodavanjeNarodnogPoslanikaForma_Load(object sender, EventArgs e)
        {
            
                try
                {
                    ISession s = DataLayer.GetSession();
                    IQuery q = s.CreateQuery("from PoslanickaGrupa");
                    IList<PoslanickaGrupa>  listaPoslanickaGrupa = q.List<PoslanickaGrupa>();

                    foreach(PoslanickaGrupa p in listaPoslanickaGrupa)
                    {
                    //MessageBox.Show(p.ImeGrupe);
                    String novi = p.IDPoslanickeGrupe.ToString() + " " + p.ImeGrupe;
                        cbClanPoslanickeGrupe.Items.Add(novi);
                    }

                    s.Close();
                }
                catch(Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            dodajUComboBoxRadnoTelo();
        }

        private void dodajUComboBoxRadnoTelo()
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from RadnoTelo");
                IList<RadnoTelo> listaPoslanickaGrupa = q.List<RadnoTelo>();

                foreach (RadnoTelo p in listaPoslanickaGrupa)
                {
                    //MessageBox.Show(p.ImeGrupe);
                    String novi = p.IDRadnoTelo.ToString() + " " + p.Tip;
                    cbClanRadnogTela.Items.Add(novi);
                }

                s.Close();

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            validacijaPodataka();
            oNarodniPoslanik = new NarodniPoslanikDodaj();
            oNarodniPoslanik.LIme = txtIme.Text;
            oNarodniPoslanik.SrednjeIme = txtSrednjeIme.Text;
            oNarodniPoslanik.prezime = txtPrezime.Text;
            oNarodniPoslanik.JMBG = Int32.Parse(txtJMBG.Text);
            oNarodniPoslanik.JIBNP = Int32.Parse(txtJIBNP.Text);
            oNarodniPoslanik.MestoRodjenja = txtMestoRodjenja.Text;
            MessageBox.Show(dtpDatumRodjenja.Value.ToString());
            oNarodniPoslanik.datumRodjenja = dtpDatumRodjenja.Value;
            oNarodniPoslanik.MestoRodjenja = txtMestoRodjenja.Text;
            oNarodniPoslanik.ulicaStanovanja = txtUlica.Text;
            oNarodniPoslanik.brojStanovanja = Int32.Parse(txtBroj.Text);

            try
            {
                ISession s1 = DataLayer.GetSession();
                String vrednost = cbClanPoslanickeGrupe.SelectedItem.ToString();
                String[] zaVrednost = vrednost.Split(' ');
                MessageBox.Show(zaVrednost[0]+"\n" + zaVrednost[1]);
                IQuery q = s1.CreateQuery("select r from PoslanickaGrupa  r where  r.IDPoslanickeGrupe=" + zaVrednost[0]);
                PoslanickaGrupa poslaniGrupa = q.UniqueResult<PoslanickaGrupa>();
                MessageBox.Show(poslaniGrupa.IDPoslanickeGrupe.ToString());
                //oNarodniPoslanik.pripadaRT
                oNarodniPoslanik.pripada = poslaniGrupa;


                s1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                ISession s2 = DataLayer.GetSession();
                String vrednost = cbClanRadnogTela.SelectedItem.ToString();
                String[] zaVrednost = vrednost.Split(' ');
                MessageBox.Show(zaVrednost[0] + "\n" + zaVrednost[1]);
                IQuery q = s2.CreateQuery("select r from RadnoTelo  r where  r.IDRadnoTelo=" + zaVrednost[0]);
                RadnoTelo radnTelo = q.UniqueResult<RadnoTelo>();
                MessageBox.Show(radnTelo.IDRadnoTelo.ToString());
                oNarodniPoslanik.pripadaRT = radnTelo;
                

                s2.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.InnerException.Message);
            }

            //oNarodniPoslanik.brojMobilnog = Int16.Parse(txtBrojMobilnog.Text);
            //oNarodniPoslanik.brojFiksnog = Int16.Parse(txtBrojFiksnogTelefona.Text);

            NarodniPoslanikManager.upisiNarodniPoslanik(oNarodniPoslanik);
             
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
