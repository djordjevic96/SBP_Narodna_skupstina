using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPNarodnaSkupstinaIIIDomaci.Entiteti
{
    public class SednicaJeSazvana
    {
        public virtual int IDSednicaJeSazvana { get; protected set; }

        //Strana ka NarodnomPoslaniku
        public virtual NarodniPoslanik NarodniPoslanikSednicaJeSazvana { get; set; }
        //strana ka VanrednojSednici
        public virtual Sednica VanrednaSednicaJeSazvana { get; set; }
    }
}
