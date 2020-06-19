using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPNarodnaSkupstinaIIIDomaci.Entiteti
{
    public class BrojFiksnogTelefona
    {
        public virtual int IDBrojFiksnogTelefona { get; protected set; }
        public virtual int BrojFiksnog { get; set; }
        //KaNarodnomPoslaniku
        public virtual NarodniPoslanik NarodniPoslanikBrojFiksnogTelefona { get; set; }
    }
}
