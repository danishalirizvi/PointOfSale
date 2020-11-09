using MetroFramework;
using PointOfSale.Data;
using PointOfSale.Data.Entities;
using PointOfSale.Data.Enum;
using PointOfSale.UI.Helper;
using PointOfSale.UI.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace PointOfSale.UI.Views
{
    public partial class ManageCustomerForm : MetroFramework.Forms.MetroForm
    {
        CustomerManager customerManager = new CustomerManager();
        public ManageCustomerForm()
        {
            InitializeComponent();
            if (Context.User.IsAdmin == 0)
            {
                bindingNavigatorDeleteItem.Enabled = false;
                expenseBindingNavigator.Enabled = false;
            }
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            customerManager.LoadCustomersGrid(customerDataGridView);
        }

        private void onSelectionChange(object sender, EventArgs e)
        {
            populateFields();
        }

        private void populateFields()
        {
            nameField.Text = customerDataGridView.CurrentRow.Cells["Name"]?.Value.ToString();
            cnicField.Text = customerDataGridView.CurrentRow.Cells["CNIC"]?.Value.ToString();
            percentField.Text = customerDataGridView.CurrentRow.Cells["PercentDiscount"]?.Value.ToString();
            primaryField.Text = customerDataGridView.CurrentRow.Cells["Mobile"]?.Value.ToString();
            //dobDatePicker.Text = customerDataGridView.CurrentRow.Cells["DOB"]?.Value.ToString();
            addressField.Text = customerDataGridView.CurrentRow.Cells["Address"]?.Value.ToString();
            txtCurrentDue.Text = customerDataGridView.CurrentRow.Cells["DueAmount"]?.Value.ToString();
        }

        private void deleteButtonClicked(object sender, EventArgs e)
        {
            if (customerDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Delete ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                if (customerDataGridView.CurrentRow == null) return;

                int customerID = Convert.ToInt32(customerDataGridView.CurrentRow.Cells["CustomerID"]?.Value.ToString());

                customerManager.DeleteSupplier(customerID);

                customerManager.LoadCustomersGrid(customerDataGridView);

                emprtyGridCheck();
            }
            else
            {
                MetroMessageBox.Show(this, "Deletion Canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void emprtyGridCheck()
        {
            if (customerDataGridView.RowCount == 0)
            {
                nameField.Clear();
                addressField.Clear();
                percentField.Clear();
                primaryField.Clear();
                cnicField.Clear();
                txtCurrentDue.Clear();
                txtDueReceived.Clear();
            }
        }

        private void updateButtonClicked(object sender, EventArgs e)
        {
            if (customerDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(nameField.Text) || string.IsNullOrEmpty(primaryField.Text))
            {
                MetroMessageBox.Show(this, "Name and Mobile are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ((!Validators.numericOnly(percentField.Text)))
                {
                    MetroMessageBox.Show(this, "Discount Must be Numeric", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if ((string.IsNullOrEmpty(percentField.Text) ? 0 : Convert.ToDecimal(percentField.Text)) > 100)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Discount can't be greater than 100", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Customer customer = new Customer()
                    {
                        CustomerID = Convert.ToInt32(customerDataGridView.CurrentRow.Cells["CustomerID"]?.Value.ToString()),
                        Name = nameField.Text,
                        DOB = dobDatePicker.Text.ToString(),
                        CNIC = cnicField.Text,
                        Mobile = primaryField.Text,
                        Address = addressField.Text,
                        PercentDiscount = string.IsNullOrEmpty(percentField.Text) ? 0 : Convert.ToInt32(percentField.Text)
                    };

                    customerManager.updateCustomer(customer);
                    customerManager.LoadCustomersGrid(customerDataGridView);

                    nameField.Clear();
                    cnicField.Clear();
                    primaryField.Clear();
                    addressField.Clear();
                    percentField.Clear();

                    MetroMessageBox.Show(this, "Customer Details Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void onTextChange(object sender, EventArgs e)
        {
            customerManager.LoadCustomersGrid(customerDataGridView, searchField.Text);
            emprtyGridCheck();
            //(supplierDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", searchField.Text);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (customerDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerID = Convert.ToInt32(customerDataGridView.CurrentRow.Cells["CustomerID"]?.Value.ToString());
            string customerName = customerDataGridView.CurrentRow.Cells["Name"]?.Value.ToString();

            if (txtDueReceived.Text == "")
            {
                MetroMessageBox.Show(this, "Paid Due Amount Field is Empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!Validators.isPostiveDecimalNumber(txtDueReceived.Text))
                {
                    MetroMessageBox.Show(this, "Enter Valid Due Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDueReceived.Clear();
                }
                else if (Convert.ToInt32(txtDueReceived.Text) > Convert.ToInt32(txtCurrentDue.Text))
                {
                    MetroMessageBox.Show(this, "Received Due Amount can't be greater then Current Due Amount", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDueReceived.Clear();
                }
                else
                {
                    DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Update Due Amount Receiving of Rs" + txtDueReceived.Text + " for " + customerName, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dr == DialogResult.Yes)
                    {
                        if (customerDataGridView.CurrentRow == null) return;

                        customerManager.ReceiveDue(Convert.ToInt32(txtDueReceived.Text), customerID);

                        customerManager.LoadCustomersGrid(customerDataGridView);
                        populateFields();
                        txtDueReceived.Clear();
                    }
                    else
                    {
                        txtDueReceived.Clear();
                        MetroMessageBox.Show(this, "Receiving Canclled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
