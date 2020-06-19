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
    public class SednicaManager
    {
        public static List<SednicaPregled> vratiSveSednice()
        {
            List<SednicaPregled> listaSednica = new List<SednicaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from Sednica");
                IList<Sednica> l = q.List<Sednica>();

                foreach (Sednica sed in l)
                {
                    listaSednica.Add(new SednicaPregled(sed.IDSednice, sed.BrojZasedanja, sed.DatumKraja));
                }
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return listaSednica;
        }

        public static SednicaPregled updateSednica(SednicaPregled obj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Sednica sed = s.Load<Sednica>(obj.IDSednice);
                sed.BrojZasedanja = obj.BrojZasedanja;
                sed.DatumKraja = obj.DatumKraja;

                s.Update(sed);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return obj;
        }
    }
}
