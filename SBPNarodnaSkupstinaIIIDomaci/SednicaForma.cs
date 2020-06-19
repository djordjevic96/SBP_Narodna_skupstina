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
    public partial class SednicaForma : Form
    {
        SednicaPregled sPregled;
        public SednicaForma()
        {
            sPregled = new SednicaPregled();
            InitializeComponent();
        }

        private void SednicaForma_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<SednicaPregled> pregledLista = SednicaManager.vratiSveSednice();
            List<SednicaPregled> sortirana = pregledLista.OrderBy(x => x.IDSednice).ToList();
            for (int i = 0; i < sortirana.Count; i++)
                listBox1.Items.Add(sortirana[i].IDSednice + " " + Convert.ToDateTime(sortirana[i].DatumKraja).ToString("dd.MM.yyyy") + " " + sortirana[i].BrojZasedanja);
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
                    txtIdSed.Text = niz[0];
                    dateTimePicker1.Value = DateTime.ParseExact(niz[1], "dd.MM.yyyy", null);
                    txtBrojZasedanja.Text = niz[2];

                }
            }
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            sPregled.IDSednice = Int16.Parse(txtIdSed.Text);
            sPregled.DatumKraja = dateTimePicker1.Value;
            sPregled.BrojZasedanja = Int16.Parse(txtBrojZasedanja.Text);

            SednicaPregled s = SednicaManager.updateSednica(sPregled);
            listBox1.Items.Clear();
            List<SednicaPregled> pregledLista = SednicaManager.vratiSveSednice();
            List<SednicaPregled> sortirana = pregledLista.OrderBy(x => x.IDSednice).ToList();
            for (int i = 0; i < sortirana.Count; i++)
                listBox1.Items.Add(sortirana[i].IDSednice + " " + Convert.ToDateTime(sortirana[i].DatumKraja).ToString("dd.MM.yyyy") + " " + sortirana[i].BrojZasedanja);
        }
    }
}
