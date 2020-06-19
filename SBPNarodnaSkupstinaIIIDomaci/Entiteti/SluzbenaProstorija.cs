using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPNarodnaSkupstinaIIIDomaci.Entiteti
{
    public class SluzbenaProstorija
    {
        public virtual int IDSluzbenaProstorija { get; protected set; }
        public virtual int BrojSprata { get; set; }
        public virtual int BrojProstorije { get; set; }

        //Povezanost sa PoslanickomGrupom 
        public virtual PoslanickaGrupa PosedujeSluzbenaProstorija { get; set; }

        //Povezanost sa radnim telom 
        public virtual RadnoTelo DodeljenaSluzbenaProstorija { get; set; }
    }
}
