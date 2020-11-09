using PointOfSale.Data.DataAccess;
using PointOfSale.Data.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.UI.Managers
{
    public class PaymentManager : BaseManager
    {

        PaymentDao paymentDao;

        public PaymentManager() {
            paymentDao = new PaymentDao(ConnectionString);
        }       

        public bool AddPaymentMethod(PaymentMethod method)
        {
            PaymentMethod m = paymentDao.getPaymentMethod(method);

            if (m == null)
            {
                paymentDao.addPaymentMethod(method);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<PaymentMethod> GetAllPaymentMethods() {

            List<PaymentMethod> methods = paymentDao.getAllPaymentMethods();

            return methods;
        }

        public void DeletePaymentMethod(int methodID)
        {
            paymentDao.deletePaymentMethod(methodID);
        }
    }
}
