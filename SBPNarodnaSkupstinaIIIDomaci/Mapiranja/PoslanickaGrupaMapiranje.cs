using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci.Mapiranja
{
    class PoslanickaGrupaMapiranje:ClassMap<PoslanickaGrupa>
    {
        public PoslanickaGrupaMapiranje()
        {
            Table("POSLANICKAGRUPA");

            //Id Poslanicke grupe
            Id(x => x.IDPoslanickeGrupe, "IDPOSLANICKEGRUPE").GeneratedBy.TriggerIdentity();

            //Mapiranje ostalih atributa
            Map(x => x.ImeGrupe, "IMEGRUPE");
            //Mapiranje veze sa narodnim poslanikom 
            HasMany(x => x.ClanKPoslanickaGrupa).KeyColumn("IDPOSLANICKEGRUPENPG").LazyLoad().Cascade.All();
            References(x => x.JePredsednikPoslanickeGrupe).Column("IDNARODNIPOSLANIKNPP").LazyLoad();
            References(x => x.JeZamenikPoslanickeGrupe).Column("IDNARODNIPOSLANIKNPZ").LazyLoad();

            //Mapiranje veze sa sluzbenom prostorijom
            HasMany(x => x.PosedujeSluzbenuProstoriju).KeyColumn("IDPOSLANICKEGRUPE").LazyLoad().Cascade.All();
        }
    }
}
