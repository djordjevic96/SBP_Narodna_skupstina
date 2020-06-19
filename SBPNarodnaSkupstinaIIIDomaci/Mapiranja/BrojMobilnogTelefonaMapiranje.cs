using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci.Mapiranja
{
    class BrojMobilnogTelefonaMapiranje:ClassMap<BrojMobilnogTelefona>
    {
        public BrojMobilnogTelefonaMapiranje()
        {
            Table("BROJFIKSNOGTELEFONA");

            Id(x => x.IDBrojMobilnogTelefona, "IDBROJFIKSNOGTELEFONA").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojMobilnog, "BROJFIKSNOGTELEFONA");

            //Veza sa narodnim poslanikom
            References(x => x.NarodniPoslanikMobilniTelefon).Column("IDNARODNIPOSLANIKNP").LazyLoad();
        }
    }
}
