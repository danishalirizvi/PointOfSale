using System;
using System.Windows.Forms;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Entities;

namespace PointOfSale.UI.Views
{
    public partial class AddPaymentMethodForm : MetroFramework.Forms.MetroForm
    {
        PaymentManager paymentManager = new PaymentManager();
        public AddPaymentMethodForm()
        {
            InitializeComponent();
        }

        private void addPaymentMethodButtonClick(object sender, EventArgs e)
        {
            if (nameField.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Method Name is Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                PaymentMethod method = new PaymentMethod()
                {
                    Name = nameField.Text,
                    Description = descriptionField.Text,
                    IsActive = 1,
                    IsBlocked = 0
                };

                bool status = paymentManager.AddPaymentMethod(method);

                if (status)
                {
                    nameField.Clear();
                    descriptionField.Clear();
                    MetroFramework.MetroMessageBox.Show(this, "Payment Method Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Payment Method Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
