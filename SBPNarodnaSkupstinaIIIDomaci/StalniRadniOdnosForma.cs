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
    public partial class StalniRadniOdnosForma : Form
    {
        public StalniRadniOdnosForma()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void StalniRadniOdnosForma_Load(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from NarodniPoslanik");
                IList<NarodniPoslanik> listaPoslanickaGrupa = q.List<NarodniPoslanik>();

                foreach (NarodniPoslanik p in listaPoslanickaGrupa)
                {
                    //MessageBox.Show(p.ImeGrupe);
                    String novi = p.IDNarodniPoslanik.ToString()+" "+p.LicnoIme+p.Prezime;
                    comboBox1.Items.Add(novi);
                }

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s1 = DataLayer.GetSession();
                String vrednost = comboBox1.SelectedItem.ToString();
                String[] zaVrednost = vrednost.Split(' ');
                MessageBox.Show(zaVrednost[0] + "\n" + zaVrednost[1]);
                IQuery q = s1.CreateQuery("select r from NarodniPoslanik  r where  r.IDNarodniPoslanik=" + zaVrednost[0]);
                NarodniPoslanik Niko = q.UniqueResult<NarodniPoslanik>();
                MessageBox.Show(Niko.IDNarodniPoslanik.ToString());

                s1.Flush();

                StalniRadniOdnos novi = new StalniRadniOdnos();
                novi.ImeFirme = txtIme.Text;
                novi.Godine = Int16.Parse(txtGodina.Text);
                novi.Mesec = Int16.Parse(txtMesec.Text);
                novi.Dan = Int16.Parse(txtDan.Text);
                novi.BrojRadneKnjizice = Int16.Parse(txtBrojRKnjizice.Text);

                s1.Save(novi);
                s1.Flush();


                s1.Close();
            }
            catch(Exception exccc)
            {
                MessageBox.Show(exccc.InnerException.Message);
            }

            
        }
    }
}
