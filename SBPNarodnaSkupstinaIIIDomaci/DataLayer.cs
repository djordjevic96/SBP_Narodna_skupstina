using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using SBPNarodnaSkupstinaIIIDomaci.Mapiranja;

namespace SBPNarodnaSkupstinaIIIDomaci
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();

        public static ISession GetSession()
        {
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }
            return _factory.OpenSession();
        }

        public static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10.ShowSql().ConnectionString(c => c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;PERSIST SECURITY INFO=True;USER ID=S15574;Password=S15574"));


                return Fluently.Configure().Database(cfg).Mappings(m => m.FluentMappings.AddFromAssemblyOf<NarodniPoslanikMapiranje>()).BuildSessionFactory();
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
                return null;
            }
        }
    }
}
