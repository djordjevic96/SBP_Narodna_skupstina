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
    public partial class DodavanjePravniAktForma : Form
    {
        public DodajPravniAkt pa;
        public DodavanjePravniAktForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                pa = new DodajPravniAkt();
                try
                {
                    ISession s = DataLayer.GetSession();
                    pa.BrojBiraca = Int16.Parse(textBox1.Text);
                    pa.TipPA = comboBox1.Text;
                    pa.TipPredloga = comboBox2.Text;

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
                PravniAktManager.dodajPravniAkt(pa);
        }
    }
}
