using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.UI.Managers
{
    public class BaseManager
    {
        public string ConnectionString { get; set; }

        public BaseManager() {
            ConnectionString = LoadConnectionString();
        }
        public static string LoadConnectionString()
        {
            var provider = ConfigurationManager.AppSettings["DatabaseProvider"];
            return ConfigurationManager.ConnectionStrings[provider].ConnectionString;
        }
    }
}
