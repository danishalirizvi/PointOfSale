using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.UI.Helper
{
    public static class Validators
    {
        public static bool numericOnly(string input)
        {
            foreach (char c in input)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }

        public static bool isPostiveNumber(string input)
        {
            int output;
            int.TryParse(input, out output);
            if (output == 0) return false;

            else if (Convert.ToInt32(input) <= 0) return false;
            return true;
        }


        public static bool isPostiveDecimalNumber(string input)
        {
            decimal output;
            decimal.TryParse(input, out output);
            if (output == 0) return false;

            else if (Convert.ToDecimal(input) <= 0) return false;
            return true;
        }

        public static string GetStandardDate(string date)
        {
            DateTime dt;
            DateTime.TryParse(date, out dt);
            if (dt != null)
            {
                return dt.ToString("yyyy-MM-dd");
            }

            else return date;
        }


        public static string GetStandardDateTime(string date)
        {
            DateTime dt;
            DateTime.TryParse(date, out dt);
            if (dt != null)
            {
                return dt.ToString("yyyy-MM-dd HH:mm:ss");
            }

            else return date;
        }



        public static string GetStandardDateTime(DateTime date)
        {
            return date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string GetStandardDate(DateTime date)
        {
            return date.ToString("yyyy-MM-dd");
        }
    }
}
