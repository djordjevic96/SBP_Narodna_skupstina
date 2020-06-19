using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci.Mapiranja
{
    class SednicaMapiranje:ClassMap<Sednica>
    {
        public SednicaMapiranje()
        {
            Table("SEDNICA");

            DiscriminateSubClassesOnColumn("TIPSEDNICE");

            Id(x => x.IDSednice, "IDSEDNICE").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojZasedanja, "BROJZASEDANJA");
            Map(x => x.DatumPocetka, "DATUMPOCETKA");
            Map(x => x.DatumKraja, "DATUMKRAJA");
            Map(x => x.BrojSaziva, "BROJSAZIVA");

            //Mapiranje sa radnimDanom
            HasMany(x => x.jeRadilaSednica).KeyColumn("IDSEDNICES").LazyLoad().Cascade.All().Inverse();
        }
    }
    class VanrednaSednicaMapiranje : SubclassMap<VanrednaSednica>
    {
        public VanrednaSednicaMapiranje()
        {
            DiscriminatorValue("VANREDNA");

            Map(x => x.IncijativaSednica, "INICIJATIVA");
            //HasMany(x => x.NarodniPoslanikSednica).KeyColumn("IDNARODNIPOSLANIKNP").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.jeSazvanaVanrednaSednica).KeyColumn("IDSEDNICE").LazyLoad().Cascade.All().Inverse();


        }
    }
    class RedovnaSednicaMapiranje : SubclassMap<RedovnaSednica>
    {
        public RedovnaSednicaMapiranje()
        {
            DiscriminatorValue("REDOVNA");
        }
    }
}
