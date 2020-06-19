using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci.Mapiranja
{
    class RadnoTeloMapiranje:ClassMap<RadnoTelo>
    {
        public RadnoTeloMapiranje()
        {
            Table("RADNOTELO");

            DiscriminateSubClassesOnColumn("TIP");

            Id(x => x.IDRadnoTelo, "IDRADNOTELO").GeneratedBy.TriggerIdentity();

            //Mapiranje 1:1 Radnotelo-PredsednikradnogTela-NaroniPoslanik
            References(x => x.JePredsednikRadnoTelo).Column("IDNARODNIPOSLANIKNPP").LazyLoad();
            //Mapiranje 1:1 RadnoTelo-ZamenikRadnnogTela-narodniPoslanik
            References(x => x.JeZamenikRadnoTelo).Column("IDNARODNIPOSLANIKNPP").LazyLoad();

            //Mapiranje 1:N RadnoTelo-JeClan-NarodniPoslanik
            HasMany(x => x.ClanRadnoTelo).KeyColumn("IDRADNOTELORT").LazyLoad().Cascade.All();

            //Mapiranje 1:N radnoTelo-Poseduje-SluzbenaProstorija

            References(x => x.SluzbenaProstorijaRadnoTelo).Column("IDSLUZBENAPROSTORIJART").LazyLoad();

            Map(x => x.TipZaPrikaz, "TIP");
        }
    }
    class StalniRadniOdborMapiranje : SubclassMap<StalniRadniOdbor>
    {
        public StalniRadniOdborMapiranje()
        {
            DiscriminatorValue("STALNI RADNI ODBOR");
        }
    }

    class PrivremeniOdborMapiranje : SubclassMap<PrivremeniOdbor>
    {
        public PrivremeniOdborMapiranje()
        {
            DiscriminatorValue("PRIVREMENI ODBOR");
        }
    }
    class KomisijaMapiranje : SubclassMap<Komisija>
    {
        public KomisijaMapiranje()
        {
            DiscriminatorValue("KOMISIJA");
        }
    }
    class AnketniOdborMapiranje : SubclassMap<AnketniOdbor>
    {
        public AnketniOdborMapiranje()
        {
            DiscriminatorValue("ANKETNI ODBOR");
        }
    }
}
