using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPNarodnaSkupstinaIIIDomaci.Entiteti
{
    public class PoslanickaGrupa
    {
        public virtual int IDPoslanickeGrupe { get; protected set; }
        public virtual string ImeGrupe { get; set; }

        //Povezanost sa NarodnimPoslanikom
        public virtual IList<NarodniPoslanik> ClanKPoslanickaGrupa { get; set; }
        public virtual NarodniPoslanik JePredsednikPoslanickeGrupe { get; set; }
        public virtual NarodniPoslanik JeZamenikPoslanickeGrupe { get; set; }

        //povezanost sa Sluzbenom prostorijom veza 1:N
        public virtual IList<SluzbenaProstorija> PosedujeSluzbenuProstoriju { get; set; }

        public PoslanickaGrupa()
        {
            ClanKPoslanickaGrupa = new List<NarodniPoslanik>();
            PosedujeSluzbenuProstoriju = new List<SluzbenaProstorija>();
        }
    }
}
