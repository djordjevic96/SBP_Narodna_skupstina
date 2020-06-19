using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci.Mapiranja
{
    class SednicaJeSazvanaMapiranje:ClassMap<SednicaJeSazvana>
    {
        public SednicaJeSazvanaMapiranje()
        {
            Table("SEDNICAJESAZVANA");

            //Mapiranje ID-a
            Id(x => x.IDSednicaJeSazvana, "IDSEDNICAJESAZVANA").GeneratedBy.TriggerIdentity();

            References(x => x.NarodniPoslanikSednicaJeSazvana).Column("IDNARODNIPOSLANIKNP");
            References(x => x.VanrednaSednicaJeSazvana).Column("IDSEDNICE");
        }
    }
}
