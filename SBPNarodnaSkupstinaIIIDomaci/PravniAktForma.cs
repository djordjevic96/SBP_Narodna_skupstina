using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci
{
    public partial class PravniAktForma : Form
    {
        DodavanjePravniAktForma dpf;
        PravniAktPregled pPregled;
        public PravniAktForma()
        {
            pPregled = new PravniAktPregled();
            InitializeComponent();
        }

        private void PravniAktForma_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<PravniAktPregled> listaPA = PravniAktManager.vratiPravneAktove();
            List<PravniAktPregled> sortirana = listaPA.OrderBy(x => x.IDPravniAkt).ToList();
            for (int i = 0; i < sortirana.Count; i++)
                listBox1.Items.Add(sortirana[i].IDPravniAkt +
                     " " + sortirana[i].TipPredlogaPravnogAkta + " " + sortirana[i].BrojBiraca);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (i == index)
                {
                    String s = listBox1.SelectedItem.ToString();
                    String[] niz = s.Split(' ');
                    txtIdPA.Text = niz[0];
                    txtBrojBiraca.Text = niz[2];
                    cbxKJPA.Text = niz[1];
                }
            }
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            pPregled.IDPravniAkt = Int16.Parse(txtIdPA.Text);
            pPregled.BrojBiraca = Int16.Parse(txtBrojBiraca.Text);
            pPregled.TipPredlogaPravnogAkta = cbxKJPA.Text;

            PravniAktPregled p = PravniAktManager.updatePravniAkt(pPregled);
            listBox1.Items.Clear();
            List<PravniAktPregled> listaPA = PravniAktManager.vratiPravneAktove();
            List<PravniAktPregled> sortirana = listaPA.OrderBy(x => x.IDPravniAkt).ToList();
            for (int i = 0; i < sortirana.Count; i++)
            {
                listBox1.Items.Add(sortirana[i].IDPravniAkt
                    + " " + sortirana[i].TipPredlogaPravnogAkta + " " + sortirana[i].BrojBiraca);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dpf = new DodavanjePravniAktForma();
            dpf.Show();
        }
    }
}
