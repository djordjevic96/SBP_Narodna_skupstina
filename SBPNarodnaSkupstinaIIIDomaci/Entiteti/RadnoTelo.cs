using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBPNarodnaSkupstinaIIIDomaci.Entiteti
{
    public class RadnoTelo
    {
        public virtual int IDRadnoTelo { get; protected set; }
        public virtual string Tip { get; set; }

        //Povezanost sa NarodnimPoslanikom 
        public virtual IList<NarodniPoslanik> ClanRadnoTelo { get; set; }
        public virtual NarodniPoslanik JePredsednikRadnoTelo { get; set; }
        public virtual NarodniPoslanik JeZamenikRadnoTelo { get; set; }
        public virtual String TipZaPrikaz { get; set; }

        //Povezanost sa sluzbenom prostorijom
        public virtual SluzbenaProstorija SluzbenaProstorijaRadnoTelo { get; set; }
        public RadnoTelo()
        {
            ClanRadnoTelo = new List<NarodniPoslanik>();
        }
    }
    public class StalniRadniOdbor : RadnoTelo
    {

    }
    public class PrivremeniOdbor : RadnoTelo
    {

    }
    public class Komisija : RadnoTelo
    {

    }
    public class AnketniOdbor : RadnoTelo
    {

    }
}
