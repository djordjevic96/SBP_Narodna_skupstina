using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;
using NHibernate;
using System.Windows.Forms;

namespace SBPNarodnaSkupstinaIIIDomaci
{
    public class PravniAktManager
    {
        public static List<PravniAktPregled> vratiPravneAktove()
        {
            List<PravniAktPregled> lista = new List<PravniAktPregled>();

            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from PravniAkt");
                IList<PravniAkt> x = q.List<PravniAkt>();

                foreach(PravniAkt p in x) {
                    lista.Add(new PravniAktPregled(p.IDPravnogAkta, p.BrojBiraca, p.TipPredlogaPravniAkt));
                }
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return lista;
        }

        public static PravniAktPregled updatePravniAkt(PravniAktPregled pa)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PravniAkt prav = s.Load<PravniAkt>(pa.IDPravniAkt);
                prav.BrojBiraca = pa.BrojBiraca;
                prav.TipPredlogaPravniAkt = pa.TipPredlogaPravnogAkta;
                

                s.Update(prav);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return pa;
        }
        public static void dodajPravniAkt(DodajPravniAkt dpa)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                PravniAkt pa = new PravniAkt();
                pa.BrojBiraca = dpa.BrojBiraca;
                pa.TipPredlogaPravniAkt = dpa.TipPredloga;
                pa.TipAPravniAkt = dpa.TipPA;

                s.Save(pa);
                s.Flush();
                s.Close();
            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }
    }
}
