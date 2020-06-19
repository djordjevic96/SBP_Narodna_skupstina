using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci.Mapiranja
{
    class SluzbenaProstorijaMapiranje:ClassMap<SluzbenaProstorija>
    {
        public SluzbenaProstorijaMapiranje()
        {
            Table("SLUZBENAPROSTORIJA");

            Id(x => x.IDSluzbenaProstorija, "IDSP").GeneratedBy.TriggerIdentity();
            Map(x => x.BrojSprata, "BROJSPRATA");
            Map(x => x.BrojProstorije, "BROJPROSTORIJE");

            //Mapiranje teloPoseduje
            HasOne(x => x.DodeljenaSluzbenaProstorija).PropertyRef(x => x.SluzbenaProstorijaRadnoTelo);


            //Mapiranje veze 1:N - SluzbenaProstorija-poseduje-PoslanickaGrupa
            References(x => x.PosedujeSluzbenaProstorija).Column("IDPOSLANICKEGRUPE").LazyLoad();
        }
    }
}
