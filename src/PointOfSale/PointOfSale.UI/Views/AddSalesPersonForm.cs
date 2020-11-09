using System;
using System.Windows.Forms;
using System.Configuration;
using PointOfSale.Data.DataAccess;
using PointOfSale.UI.Helper;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Entities;

namespace PointOfSale.UI.Views
{
    public partial class AddSalesPersonForm : MetroFramework.Forms.MetroForm
    {
        EmployeeManager employeeManager;

        public AddSalesPersonForm()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
        }

        public static string LoadConnectionString()
        {
            var provider = ConfigurationManager.AppSettings["DatabaseProvider"];
            return ConfigurationManager.ConnectionStrings[provider].ConnectionString;
        }

        private void addSalesPersoneButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameField.Text) || string.IsNullOrEmpty(mobileField.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Name and Mobile are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SalesPerson salesperson = new SalesPerson()
                {
                    Name = nameField.Text,
                    CNIC = cnicField.Text,
                    Phone = mobileField.Text
                };

                employeeManager.AddSalesPerson(salesperson);

                nameField.Clear();
                cnicField.Clear();

                mobileField.Clear();
                MetroFramework.MetroMessageBox.Show(this, "Sales Person Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
