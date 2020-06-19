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
    public partial class PoslanickaGrupaForma : Form
    {
        PoslanickaGrupaPregled oPregled;
        public PoslanickaGrupaForma()
        {
            oPregled = new PoslanickaGrupaPregled();
            InitializeComponent();
        }

        private void PoslanickaGrupaForma_Load(object sender, EventArgs e)
        {
            //listView1.Items.Clear();
            //List<PoslanickaGrupaPregled> pregledLista = PoslanickaGrupaManager.vratiSvePoslanickeGrupe();
            //foreach(PoslanickaGrupaPregled p in pregledLista)
            //{
            //    ListViewItem item = new ListViewItem(new string[] { p.IDPoslanickeGrupe.ToString(), p.ImeGrupe });
            //    listView1.Items.Add(item);
            //}
            //listView1.Refresh();
            listBox1.Items.Clear();
            List<PoslanickaGrupaPregled> pregledLista = PoslanickaGrupaManager.vratiSvePoslanickeGrupe();
            List<PoslanickaGrupaPregled> sortirana = pregledLista.OrderBy(x => x.IDPoslanickeGrupe).ToList();
            for(int i=0;i< sortirana.Count;i++)
            {
                listBox1.Items.Add(sortirana[i].IDPoslanickeGrupe + " " + sortirana[i].ImeGrupe);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;

            for(int i=0;i<listBox1.Items.Count;i++)
            {
                if(i==index)
                {
                    String s = listBox1.SelectedItem.ToString();
                    String[] niz = s.Split(' ');
                    textBox1.Text = niz[0];
                    txtImePG.Text = niz[1];

                }
            }

            
        }

        private void btnPromeni_Click(object sender, EventArgs e)
        {
            oPregled.IDPoslanickeGrupe = Int16.Parse(textBox1.Text);
            oPregled.ImeGrupe = txtImePG.Text;

            PoslanickaGrupaPregled p =PoslanickaGrupaManager.updatePoslanickaGrupaBasic(oPregled);

            MessageBox.Show("Azurirano je " + p.ImeGrupe);
            listBox1.Items.Clear();
            List<PoslanickaGrupaPregled> pregledLista = PoslanickaGrupaManager.vratiSvePoslanickeGrupe();
            List<PoslanickaGrupaPregled> sortirana = pregledLista.OrderBy(x => x.IDPoslanickeGrupe).ToList();
            for (int i = 0; i < sortirana.Count; i++)
            {
                listBox1.Items.Add(sortirana[i].IDPoslanickeGrupe + " " + sortirana[i].ImeGrupe);
            }
        }
    }
}
