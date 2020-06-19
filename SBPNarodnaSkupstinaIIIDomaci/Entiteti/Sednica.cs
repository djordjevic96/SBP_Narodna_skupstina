using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPNarodnaSkupstinaIIIDomaci.Entiteti
{
    public class Sednica
    {
        public virtual int IDSednice { get; set; }
        public virtual int BrojZasedanja { get; set; }
        public virtual DateTime DatumPocetka { get; set; }
        public virtual DateTime? DatumKraja { get; set; }
        public virtual int BrojSaziva { get; set; }
        public virtual string TipSednice { get; set; }


        //Povezanost sa radnim Danom 
        public virtual IList<RadniDan> jeRadilaSednica { get; set; }

        public Sednica()
        {
            jeRadilaSednica = new List<RadniDan>();
        }
    }
    public class VanrednaSednica : Sednica
    {
        public virtual string IncijativaSednica { get; set; }
        public virtual IList<SednicaJeSazvana> jeSazvanaVanrednaSednica { get; set; }
        public VanrednaSednica()
        {
            jeSazvanaVanrednaSednica = new List<SednicaJeSazvana>();
        }
    }
    public class RedovnaSednica : Sednica
    {

    }
}
