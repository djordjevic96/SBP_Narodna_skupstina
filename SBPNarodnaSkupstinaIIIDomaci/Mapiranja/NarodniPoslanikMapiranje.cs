using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci.Mapiranja
{
    class NarodniPoslanikMapiranje:ClassMap<NarodniPoslanik>
    {
        public NarodniPoslanikMapiranje()
        {
            Table("NARODNI_POSLANIK");

            //Mapiranje ID-a
            Id(x => x.IDNarodniPoslanik, "IDNARODNIPOSLANIK").GeneratedBy.TriggerIdentity();

            //Mapiranje osnovnih entiteta
            Map(x => x.LicnoIme, "LICNOIME");
            Map(x => x.SrednjeIme, "SREDNJEIME");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.JMBG, "JMBG");
            Map(x => x.JIBNP, "JIBNP");
            Map(x => x.MestoRodjenja, "MESTORODJENJA");
            Map(x => x.DatumRodjenja, "DATUMRODJENJA");
            Map(x => x.MestoStanovanja, "MESTOSTANOVANJA");
            Map(x => x.UlicaStanovanja, "ULICA");
            Map(x => x.Broj, "BROJ");

            //Mpiranje sa Poslanickom grupom
            References(x => x.PripadaPoslanickojGrupi).Column("IDPOSLANICKEGRUPENPG").LazyLoad(); //Veza 1:N
            //HasOne(x => x.JePredsednikPoslanickeGrupe).PropertyRef(x => x.JePredsednikPoslanickeGrupe); //Veza 1:1 Predsednik
            //HasOne(x => x.JeZamenikPoslanickeGrupe).PropertyRef(x => x.JeZamenikPoslanickeGrupe); //Veza 1:1 Zamenik

            //Mapiranja sa Radnim Telom
            References(x => x.ClanRadnogTela).Column("IDRADNOTELORT").LazyLoad();
            //HasOne(x => x.JePredsednikRadnogTela).PropertyRef(x => x.JePredsednikRadnoTelo); //Veza 1:1 Predsednik
            //HasOne(x => x.JeZamenikRadnogTela).PropertyRef(x => x.JeZamenikRadnoTelo);//Veza 1:1 Zamenik

            //Mapiranje sa vanrednom sednicom veza N:M
            HasMany(x => x.NarodniPoslanikSednica).KeyColumn("IDNARODNIPOSLANIKNP").LazyLoad().Cascade.All().Inverse(); //MNOGOOO CUDNO PROVERITI

            //Mapiranje sa pravnim aktom veza N:M
            HasMany(x => x.NarodniPoslanikPravniAkt).KeyColumn("IDNARODNIPOSLANIKNP").LazyLoad().Cascade.All().Inverse(); //MNOGO CUDNOOO Proveriti

            //Mapiranje fiksnog telefona
            HasMany(x => x.NarodniPoslanikBrojFiksnogTelefona).KeyColumn("IDNARODNIPOSLANIKNP").LazyLoad().Cascade.All().Inverse();

            //Mapiranje mobilnog telefona
            HasMany(x => x.NarodniPoslanikBrojMobilnogTelefona).KeyColumn("IDNARODNIPOSLANIKNP").LazyLoad().Cascade.All().Inverse();
        }
    }
    class StalniRadniOdnosMapiranje : SubclassMap<StalniRadniOdnos>
    {
        public StalniRadniOdnosMapiranje()
        {
            Table("STALNIRADNIODNOS");
            KeyColumn("IDNARODNIPOSLANIKNP");

            Map(x => x.ImeFirme, "IMEFIRME");
            Map(x => x.Godine, "GODINE");
            Map(x => x.Mesec, "MESEC");
            Map(x => x.Dan, "DAN");
            Map(x => x.BrojRadneKnjizice, "BROJRADNEKNJIZICE");
        }
    }
}
