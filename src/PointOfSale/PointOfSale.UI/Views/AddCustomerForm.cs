using System;
using System.Windows.Forms;
using System.Configuration;
using PointOfSale.Data.DataAccess;
using PointOfSale.UI.Helper;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Entities;
using PointOfSale.Data.Enum;

namespace PointOfSale.UI.Views
{
    public partial class AddCustomerForm : MetroFramework.Forms.MetroForm
    {
        CustomerManager customerManager;

        public AddCustomerForm()
        {
            InitializeComponent();
            customerManager = new CustomerManager();
            //employeeManager.LoadCombos(genderPicker, statusPicker, rolePicker, workShiftPicker);
        }

        private void addEmployeeButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameField.Text) || string.IsNullOrEmpty(mobileField.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Name and Mobile are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ((!Validators.numericOnly(percentField.Text)))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Discount Must be Numeric", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((string.IsNullOrEmpty(percentField.Text) ? 0 : Convert.ToDecimal(percentField.Text)) > 100)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Discount can't be greater than 100", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Customer customer = new Customer()
                    {
                        Name = nameField.Text,
                        DOB = dobDatePicker.Text.ToString(),
                        CNIC = cnicField.Text,
                        Mobile = mobileField.Text,
                        Address = addressField.Text,
                        PercentDiscount = string.IsNullOrEmpty(percentField.Text) ? 0 : Convert.ToInt32(percentField.Text),
                        IsActive = 1,
                        IsBlocked = 0
                    };

                    customerManager.AddCustomer(customer);

                    nameField.Clear();
                    cnicField.Clear();
                    mobileField.Clear();
                    addressField.Clear();
                    percentField.Clear();

                    MetroFramework.MetroMessageBox.Show(this, "Customer Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
