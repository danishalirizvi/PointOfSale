using PointOfSale.Data;
using PointOfSale.Data.DataAccess;
using PointOfSale.Data.Entities;
using PointOfSale.Data.Params;
using System.Configuration;

namespace PointOfSale.UI.Managers
{
    public class LoginManager
    {
        UserDao userDao = new UserDao(LoadConnectionString());

        public static string LoadConnectionString()
        {
            var provider = ConfigurationManager.AppSettings["DatabaseProvider"];
            return ConfigurationManager.ConnectionStrings[provider].ConnectionString;
        }


        public bool LoginValidation(LoginParam param) {

            LoginUser user = userDao.getLoginUser(param);

            if (user != null) {
                Context.User = user;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
