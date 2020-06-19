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
    public partial class RadnoTeloForma : Form
    {
        DodavanjeRadnogTela drt;
        RadnoTeloPregled rPregled;
        public RadnoTeloForma()
        {
            rPregled = new RadnoTeloPregled();
            InitializeComponent();
        }

        private void RadnoTeloForma_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<RadnoTeloPregled> listaRT = RadnoTeloManager.vratiRadnaTela();
            List<RadnoTeloPregled> sortirana = listaRT.OrderBy(x => x.IDRadnoTelo).ToList();
            for (int i = 0; i < sortirana.Count; i++)
                listBox1.Items.Add(sortirana[i].IDRadnoTelo + " " + sortirana[i].TipRadnogTela);
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
                    txtIDRT.Text = niz[0];
                    cbxTip.Text = niz[1];

                }
            }
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            rPregled.IDRadnoTelo = Int16.Parse(txtIDRT.Text);
            rPregled.TipRadnogTela = cbxTip.Text;

            RadnoTeloPregled r = RadnoTeloManager.updateRadnoTelo(rPregled);
            listBox1.Items.Clear();
            List<RadnoTeloPregled> listaRT = RadnoTeloManager.vratiRadnaTela();
            List<RadnoTeloPregled> sortirana = listaRT.OrderBy(x => x.IDRadnoTelo).ToList();
            for (int i = 0; i < sortirana.Count; i++)
                listBox1.Items.Add(sortirana[i].IDRadnoTelo + " " + sortirana[i].TipRadnogTela);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drt = new DodavanjeRadnogTela();
            drt.Show();
        }
    }
}
