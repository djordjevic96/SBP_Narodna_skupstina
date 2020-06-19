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
    public class NarodniPoslanikManager
    {
       public static void upisiNarodniPoslanik(NarodniPoslanikDodaj npd)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                NarodniPoslanik np = new NarodniPoslanik();
                np.LicnoIme = npd.LIme;
                np.SrednjeIme = npd.SrednjeIme;
                np.Prezime = npd.prezime;
                np.JMBG = npd.JMBG;
                np.JIBNP = npd.JIBNP;
                np.MestoRodjenja = npd.MestoRodjenja;
                np.DatumRodjenja = npd.datumRodjenja;
                np.MestoStanovanja = npd.mestoStanovanja;
                np.UlicaStanovanja = npd.ulicaStanovanja;
                np.Broj = npd.brojStanovanja;

                s.Save(np);
                s.Flush();


                np.PripadaPoslanickojGrupi = npd.pripada;
                np.ClanRadnogTela = npd.pripadaRT;

                s.Save(np);
                s.Flush();
                s.Close();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        public static List<NarodniPoslanikDodaj> vratiSveNarodnePoslanike()
        {
            List<NarodniPoslanikDodaj> lista = new List<NarodniPoslanikDodaj>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from NarodniPoslanik");
                IList<NarodniPoslanik> narodniLista = q.List<NarodniPoslanik>();

                foreach (NarodniPoslanik p in narodniLista)
                {
                    NarodniPoslanikDodaj upis = new NarodniPoslanikDodaj(p.LicnoIme, p.SrednjeIme, p.Prezime, p.JMBG, p.JIBNP, p.MestoRodjenja, p.DatumRodjenja, p.MestoStanovanja, p.UlicaStanovanja, p.Broj, p.PripadaPoslanickojGrupi, p.ClanRadnogTela);
                    lista.Add(upis);
                }

                s.Flush();
                s.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lista;

        }

        public static NarodniPoslanik VratiPoslanika(int id)
        {
            Entiteti.NarodniPoslanik p = null;
            try
            {
                ISession s = DataLayer.GetSession();

                p = s.Load<Entiteti.NarodniPoslanik>(id);

                MessageBox.Show(p.LicnoIme);

                s.Close();


            }

            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

            return p;
        }
        public static List<NarodniPoslanikPregled> vratiSveNarodnePoslanikeZaPregled()
        {
            List<NarodniPoslanikPregled> lista = new List<NarodniPoslanikPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IQuery q = s.CreateQuery("from NarodniPoslanik");
                IList<NarodniPoslanik> narodniLista = q.List<NarodniPoslanik>();

                foreach (NarodniPoslanik p in narodniLista)
                {
                    NarodniPoslanikPregled upis = new NarodniPoslanikPregled(p.IDNarodniPoslanik, p.LicnoIme, p.SrednjeIme, p.Prezime, p.JMBG, p.JIBNP);
                    lista.Add(upis);
                }

                s.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return lista;

        }

        public static List<StalniRadniOdnosPrikaz> vratiSveIzStalnogRadnogOdnosa()
        {
            List<StalniRadniOdnosPrikaz> lista = new List<StalniRadniOdnosPrikaz>();
            try
            {
                ISession s = DataLayer.GetSession();
                IQuery q = s.CreateQuery("from StalniRadniOdnos");
                IList<StalniRadniOdnos> listaN = q.List<StalniRadniOdnos>();

                foreach(StalniRadniOdnos p in listaN)
                {
                    StalniRadniOdnosPrikaz upis = new StalniRadniOdnosPrikaz(p.IDNarodniPoslanik, p.ImeFirme, p.Godine, p.Mesec, p.Dan,p.BrojRadneKnjizice);
                    lista.Add(upis);

                }
            }
            catch(Exception exccc)
            {
                MessageBox.Show(exccc.Message);
            }

            return lista;
        }
    }
}
