using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPNarodnaSkupstinaIIIDomaci.Entiteti
{
    public class PoslanikJePredlozio
    {
        public virtual int IDPoslanikJePredlozio { get; protected set; }
        //strana ka narodnomPoslaniku
        public virtual NarodniPoslanik NarodniPosalniPoslanikJePredlozio { get; set; }

        //strana ka PravnomAktu
        public virtual PravniAkt PravniAktPoslanikJePredlozio { get; set; }
    }
}
