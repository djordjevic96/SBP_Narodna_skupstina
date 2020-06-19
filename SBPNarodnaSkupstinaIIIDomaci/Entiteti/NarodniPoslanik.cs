using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPNarodnaSkupstinaIIIDomaci.Entiteti
{
    public class NarodniPoslanik
    {
        //"Klasicni atributi"
        public virtual int IDNarodniPoslanik { get; protected set; }
        public virtual string LicnoIme { get; set; }
        public virtual string SrednjeIme { get; set; }
        public virtual string Prezime { get; set; }
        public virtual int JMBG { get; set; }
        public virtual int JIBNP { get; set; }
        public virtual string MestoRodjenja { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string MestoStanovanja { get; set; }
        public virtual string UlicaStanovanja { get; set; }
        public virtual int Broj { get; set; }

        //Poslanicka grupa
        public virtual PoslanickaGrupa PripadaPoslanickojGrupi { get; set; }
        //public virtual PoslanickaGrupa JePredsednikPoslanickeGrupe { get; set; }
        //public virtual PoslanickaGrupa JeZamenikPoslanickeGrupe { get; set; }

        //Radno telo
        public virtual RadnoTelo ClanRadnogTela { get; set; }
        //public virtual RadnoTelo JePredsednikRadnogTela { get; set; }
        //public virtual RadnoTelo JeZamenikRadnogTela { get; set; }

        //Veza sa Vanrednom sednicom -Tip sednice 
        public virtual IList<SednicaJeSazvana> NarodniPoslanikSednica { get; set; }

        //Veza sa Pravnim aktom - poslnik je predlozio
        public virtual IList<PoslanikJePredlozio> NarodniPoslanikPravniAkt { get; set; }

        //Mobilni telefon
        public virtual IList<BrojMobilnogTelefona> NarodniPoslanikBrojMobilnogTelefona { get; set; }
        //Fiksni telefon
        public virtual IList<BrojFiksnogTelefona> NarodniPoslanikBrojFiksnogTelefona { get; set; }
        public NarodniPoslanik()
        {
            NarodniPoslanikSednica = new List<SednicaJeSazvana>();
            NarodniPoslanikPravniAkt = new List<PoslanikJePredlozio>();
            NarodniPoslanikBrojMobilnogTelefona = new List<BrojMobilnogTelefona>();
            NarodniPoslanikBrojFiksnogTelefona = new List<BrojFiksnogTelefona>();
        }
    }
    public class StalniRadniOdnos:NarodniPoslanik
    {
        public StalniRadniOdnos() : base()
        {
            
        }
        public virtual string ImeFirme { get; set; }
        public virtual int Godine { get; set; }
        public virtual int Mesec { get; set; }
        public virtual int Dan { get; set; }
        public virtual int BrojRadneKnjizice { get; set; }
    }
}
