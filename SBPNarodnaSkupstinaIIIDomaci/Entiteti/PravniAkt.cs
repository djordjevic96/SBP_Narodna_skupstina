using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPNarodnaSkupstinaIIIDomaci.Entiteti
{
    public class PravniAkt
    {
        public virtual int IDPravnogAkta { get; protected set; }
        public virtual int BrojBiraca { get; set; }
        public virtual string TipAPravniAkt { get; set; }
        public virtual string TipPredlogaPravniAkt { get; set; }


        //Povezivanje sa narodnim poslanikom : NarodniPoslanik-PolanikJePredlozio-PravniAkt
        public virtual IList<PoslanikJePredlozio> NarodniPoslanikPravniAkt { get; set; }
        public PravniAkt()
        {
            NarodniPoslanikPravniAkt = new List<PoslanikJePredlozio>();
        }
    }
    public class Tumacenje : PravniAkt
    {

    }
    public class Zakon : PravniAkt
    {

    }
    public class Preporuke : PravniAkt
    {

    }
    public class Odluke : PravniAkt
    {

    }
    public class Deklaracije : PravniAkt
    {

    }
}
