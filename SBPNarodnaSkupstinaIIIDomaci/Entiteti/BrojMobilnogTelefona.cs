using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPNarodnaSkupstinaIIIDomaci.Entiteti
{
    public class BrojMobilnogTelefona
    {
        public virtual int IDBrojMobilnogTelefona { get; protected set; }
        public virtual int BrojMobilnog { get; set; }

        //Veza sa narodnim poslanikom
        public virtual NarodniPoslanik NarodniPoslanikMobilniTelefon { get; set; }
    }
}
