using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci.Mapiranja
{
    class BrojFiksnogTelefonaMapiranje:ClassMap<BrojFiksnogTelefona>
    {
        public BrojFiksnogTelefonaMapiranje()
        {
            Table("BROJFIKSNOGTELEFONA");

            Id(x => x.IDBrojFiksnogTelefona, "IDBROJFIKSNOGTELEFONA").GeneratedBy.TriggerIdentity();

            Map(x => x.BrojFiksnog, "BROJFIKSNOGTELEFONA");

            //Veza sa narodnim poslanikom 
            References(x => x.NarodniPoslanikBrojFiksnogTelefona).Column("IDNARODNIPOSLANIKNP").LazyLoad();
        }
    }
}
