using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using SBPNarodnaSkupstinaIIIDomaci.Entiteti;

namespace SBPNarodnaSkupstinaIIIDomaci.Mapiranja
{
    class PoslanikJePredlozioMapiranje:ClassMap<PoslanikJePredlozio>
    {
        public PoslanikJePredlozioMapiranje()
        {
            Table("POSLANIKJEPREDLOZIO");

            //Mapiranje ID-a
            Id(x => x.IDPoslanikJePredlozio, "IDPOSLANIKJEPREDLOZIO").GeneratedBy.TriggerIdentity();

            References(x => x.NarodniPosalniPoslanikJePredlozio).Column("IDNARODNIPOSLANIKNP");
            References(x => x.PravniAktPoslanikJePredlozio).Column("IDPRAVNOGAKTA");
        }
    }
}
