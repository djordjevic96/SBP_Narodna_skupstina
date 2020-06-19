using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci.Mapiranja
{
    class RadniDanMapiranje:ClassMap<RadniDan>
    {
        public RadniDanMapiranje()
        {
            Table("RADNIDAN");

            Id(x => x.IDRadniDan, "IDRADNIDAN").GeneratedBy.TriggerIdentity();

            Map(x => x.Vreme, "VREME");
            Map(x => x.BrojPoslanika, "BROJPOSLANIKA");

            References(x => x.SednicaRadniDan).Column("IDSEDNICES").LazyLoad();
        }
    }
}
