using System;
using System.Windows.Forms;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Entities;

namespace PointOfSale.UI.Views
{
    public partial class AddSupplierForm : MetroFramework.Forms.MetroForm
    {
        SupplierManager supplierManager = new SupplierManager();
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void addSupplierButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameField.Text) || string.IsNullOrEmpty(primaryMobileField.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Name and Primary Mobile are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Supplier supplier = new Supplier()
                {
                    Name = nameField.Text,
                    CompanyName = companyField.Text,
                    CNIC = cnicField.Text,
                    Address = addressField.Text,
                    Email = emailField.Text,
                    PrimaryMobile = primaryMobileField.Text,
                    SecondaryMobile = secondaryMobileField.Text,
                    IsActive = 1,
                    IsBlocked = 0
                };

                supplierManager.addNewSupplier(supplier);

                nameField.Clear();
                companyField.Clear();
                cnicField.Clear();
                addressField.Clear();
                emailField.Clear();
                primaryMobileField.Clear();
                secondaryMobileField.Clear();

                MetroFramework.MetroMessageBox.Show(this, "Supplier Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
