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
    public class PoslanickaGrupaManager
    {
        public static List<PoslanickaGrupaPregled> vratiSvePoslanickeGrupe()
        {
            List<PoslanickaGrupaPregled> listaPoslanickihGrupa = new List<PoslanickaGrupaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from PoslanickaGrupa");
                IList<PoslanickaGrupa> lista = q.List<PoslanickaGrupa>();

                foreach(PoslanickaGrupa p in lista)
                {
                    listaPoslanickihGrupa.Add(new PoslanickaGrupaPregled(p.ImeGrupe, p.IDPoslanickeGrupe/*, p.JePredsednikPoslanickeGrupe, p.JeZamenikPoslanickeGrupe*/));
                }
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return listaPoslanickihGrupa;
        }
        public static PoslanickaGrupaPregled updatePoslanickaGrupaBasic(PoslanickaGrupaPregled obj)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                PoslanickaGrupa posl = s.Load<PoslanickaGrupa>(obj.IDPoslanickeGrupe);
                posl.ImeGrupe = obj.ImeGrupe;

                s.Update(posl);
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
            return obj;
        }
    }
}
