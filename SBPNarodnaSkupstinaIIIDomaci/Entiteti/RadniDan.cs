using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPNarodnaSkupstinaIIIDomaci.Entiteti
{
    public class RadniDan
    {
        public virtual int IDRadniDan { get; protected set; }
        public virtual int BrojPoslanika { get; set; }
        public virtual string Vreme { get; set; }

        //Povezanost sa Sednicom
        public virtual Sednica SednicaRadniDan { get; set; }
    }
}
