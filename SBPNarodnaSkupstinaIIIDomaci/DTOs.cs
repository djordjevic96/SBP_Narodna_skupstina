using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci
{
    public class NarodniPoslanikDodaj
    {
        public int NarodniPoslanikID { get; set; }
        public string LIme { get; set; }
        public string SrednjeIme { get; set; }
        public string prezime { get; set; }
        public int JMBG { get; set; }
        public int JIBNP { get; set; }
        public string MestoRodjenja { get; set; }
        public DateTime datumRodjenja { get; set; }
        public string mestoStanovanja { get; set; }
        public string ulicaStanovanja { get; set; }
        public int brojStanovanja { get; set; }
        public PoslanickaGrupa pripada {get;set;}
        public RadnoTelo pripadaRT { get; set; }
        //public BrojFiksnogTelefona brojTelefonaFiksnog { get; set; }
        //public BrojMobilnogTelefona brojMobilnogTelefona { get; set; }
        public int brojMobilnog { get; set; }
        public int brojFiksnog { get; set; }


        public NarodniPoslanikDodaj()
        {

        }

        public NarodniPoslanikDodaj(string ime,string srednje,string prezime,int jmbg,int jibnp,string mesto,DateTime datum,string mestoStanovanja,string ulicaS,int Broj,PoslanickaGrupa PG,RadnoTelo RT)//,int brojM,int brojf)
        {
            this.LIme = ime;
            this.SrednjeIme = srednje;
            this.prezime = prezime;
            this.JMBG = jmbg;
            this.JIBNP = jibnp;
            this.MestoRodjenja = mesto;
            this.datumRodjenja = datum;
            this.mestoStanovanja = mestoStanovanja;
            this.ulicaStanovanja = ulicaS;
            this.brojStanovanja = Broj;
            this.pripada = PG;
            this.pripadaRT = RT;
            //this.brojMobilnog = brojM;
            //this.brojFiksnog = brojf;
            //this.brojMobilnogTelefona = bm;
            //this.brojTelefonaFiksnog = bf;
        }
    }
    public class NarodniPoslanikPregled
    {
        public int NarodniPoslanikID { get; set; }
        public string LIme { get; set; }
        public string SrednjeIme { get; set; }
        public string prezime { get; set; }
        public int JMBG { get; set; }
        public int JIBNP { get; set; }

        public NarodniPoslanikPregled()
        {

        }
        public NarodniPoslanikPregled(int id,string ime,string srednje,string prezime,int jmbg, int jibnp)
        {
            this.NarodniPoslanikID = id;
            this.LIme = ime;
            this.SrednjeIme = srednje;
            this.prezime = prezime;
            this.JMBG = jmbg;
            this.JIBNP = jibnp;
        }
    }
    public class PoslanickaGrupaPregled
    {
        public string ImeGrupe { get; set; }
        public int IDPoslanickeGrupe { get; set; }
        //public NarodniPoslanik PredsednikPoslanickeGrupe { get; set; }
        //public NarodniPoslanik ZamenikPoslanickeGrupe { get; set; }

        public PoslanickaGrupaPregled()
        {

        }
        public PoslanickaGrupaPregled(string ime,int id/*,NarodniPoslanik pred,NarodniPoslanik zam*/)
        {
            this.ImeGrupe = ime;
            this.IDPoslanickeGrupe = id;
            //this.PredsednikPoslanickeGrupe = pred;
            //this.ZamenikPoslanickeGrupe = zam;
        }

    }

    public class SednicaPregled
    {

        public int IDSednice { get; set; }
        public int BrojZasedanja { get; set; }
        public DateTime? DatumKraja { get; set; }

        public SednicaPregled() { }

        public SednicaPregled(int id, int bz, DateTime? datum)
        {
            this.IDSednice = id;
            this.BrojZasedanja = bz;
            this.DatumKraja = datum;
        }

    
    }

    public class PravniAktPregled
    {
        public int IDPravniAkt { get; set; }
        public int BrojBiraca { get; set; }
        public string TipPredlogaPravnogAkta { get; set; }

        public PravniAktPregled() { }
        public PravniAktPregled(int id, int bb, string tppa)
        {
            this.IDPravniAkt = id;
            this.BrojBiraca = bb;
            this.TipPredlogaPravnogAkta = tppa;
        }


    }

    public class RadnoTeloPregled
    {
        public int IDRadnoTelo { get; set; }
        public string TipRadnogTela { get; set; }

        public RadnoTeloPregled() { }
        public RadnoTeloPregled(int id, string tip)
        {
            this.IDRadnoTelo = id;
            this.TipRadnogTela = tip;
        }
    }

    public class StalniRadniOdnosPrikaz
    {
        public virtual int ID { get; set; }
        public virtual string ImeFirme { get; set; }
        public virtual int Godine { get; set; }
        public virtual int Mesec { get; set; }
        public virtual int Dan { get; set; }
        public virtual int BrojRadneKnjizice { get; set; }

        public StalniRadniOdnosPrikaz()
        {

        }
        public StalniRadniOdnosPrikaz(int id,string ime,int g,int Mesec,int dan,int brojRadneKnjizice)
        {
            this.ID = id;
            this.ImeFirme = ime;
            this.Godine = g;
            this.Mesec = Mesec;
            this.Dan = dan;
            this.BrojRadneKnjizice = brojRadneKnjizice;
        }
    }

    public class DodajPravniAkt
    {
        public int BrojBiraca { get; set; }
        public string TipPA { get; set; }
        public string TipPredloga { get; set; }

        public DodajPravniAkt()
        {

        }

        public DodajPravniAkt(int bb, string t, string tt)
        {
            this.BrojBiraca = bb;
            this.TipPA = t;
            this.TipPredloga = tt;
        }
    }

    public class DodajRadnoTelo
    {
        public string TipRadnogTela { get; set; }
        public SluzbenaProstorija SluzbenaProstorija { get; set; }
        public NarodniPoslanik PredsednikRadnogTela { get; set; }
        public NarodniPoslanik ZamenikPredsednika { get; set; }

        public DodajRadnoTelo()
        {

        }
        public DodajRadnoTelo(string tip, SluzbenaProstorija sp, NarodniPoslanik prt, NarodniPoslanik zp)
        {

            this.TipRadnogTela = tip;
            this.SluzbenaProstorija = sp;
            this.PredsednikRadnogTela = prt;
            this.ZamenikPredsednika = zp;

        }
    }

}
