using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci.Mapiranja
{
    class PravniAktMapiranje:ClassMap<PravniAkt>
    {
        public PravniAktMapiranje()
        {
            Table("PRAVNIAKT");

            //Pravljenje diskriminatora 
            DiscriminateSubClassesOnColumn("TIPPA");

            Id(x => x.IDPravnogAkta, "IDPRAVNOGAKTA").GeneratedBy.TriggerIdentity();


            //Mapiranje atributa
            Map(x => x.BrojBiraca, "BROJBIRACA");
            Map(x => x.TipPredlogaPravniAkt, "TIPPREDLOGA");

            //Mapiranje vezom sa narodnim poslanikom
            HasMany(x => x.NarodniPoslanikPravniAkt).Table("POSLANIKJEPREDLOZIO").KeyColumn("IDPRAVNOGAKTA").LazyLoad().Cascade.All().Inverse();

        }
    }
    class TumacenjeMapiranje : SubclassMap<Tumacenje>
    {
        public TumacenjeMapiranje()
        {
            DiscriminatorValue("TUMACENJE");
        }
    }

    class ZakonMapiranje : SubclassMap<Zakon>
    {
        public ZakonMapiranje()
        {
            DiscriminatorValue("ZAKON");

        }
    }
    class PreporukeMapiranje : SubclassMap<Preporuke>
    {
        public PreporukeMapiranje()
        {
            DiscriminatorValue("PREPORUKA");
        }
    }
    class OdlukeMapiranje : SubclassMap<Odluke>
    {
        public OdlukeMapiranje()
        {
            DiscriminatorValue("ODLUKA");
        }
    }
    class DeklaracijeMapiranje : SubclassMap<Deklaracije>
    {
        public DeklaracijeMapiranje()
        {
            DiscriminatorValue("DEKLARACIJA");
        }
    }
}
