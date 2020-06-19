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
    public class RadnoTeloManager
    {
        public static List<RadnoTeloPregled> vratiRadnaTela()
        {
            List<RadnoTeloPregled> listaRT = new List<RadnoTeloPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from RadnoTelo");
                IList<RadnoTelo> rt = q.List<RadnoTelo>();

                foreach (RadnoTelo r in rt)
                    listaRT.Add(new RadnoTeloPregled(r.IDRadnoTelo, r.TipZaPrikaz));

                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return listaRT;
        }

        public static RadnoTeloPregled updateRadnoTelo(RadnoTeloPregled rt)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RadnoTelo r = s.Load<RadnoTelo>(rt.IDRadnoTelo);
                r.TipZaPrikaz = rt.TipRadnogTela;
                s.Update(r);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return rt;
        }

        public static void dodajRadnoTelo(DodajRadnoTelo drt)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                RadnoTelo rt = new RadnoTelo();
                rt.TipZaPrikaz = drt.TipRadnogTela;
                rt.JePredsednikRadnoTelo = drt.PredsednikRadnogTela;
                rt.JeZamenikRadnoTelo = drt.ZamenikPredsednika;
                rt.SluzbenaProstorijaRadnoTelo = drt.SluzbenaProstorija;

                s.Save(rt);
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
