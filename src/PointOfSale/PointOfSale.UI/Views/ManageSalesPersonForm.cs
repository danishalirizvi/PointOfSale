using MetroFramework;
using PointOfSale.Data;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Helper;
using PointOfSale.UI.Managers;
using System;
using System.Windows.Forms;

namespace PointOfSale.UI.Views
{
    public partial class ManageSalesPersonForm : MetroFramework.Forms.MetroForm
    {
        EmployeeManager employeeManager = new EmployeeManager();
        public ManageSalesPersonForm()
        {
            InitializeComponent();
            if (Context.User.IsAdmin == 0)
            {
                bindingNavigatorDeleteItem.Enabled = false;
                employeeBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            employeeManager.LoadSalesPersonGrid(salesPersonDataGridView);
        }

        private void onSelectionChange(object sender, EventArgs e)
        {
            if (salesPersonDataGridView.CurrentRow != null)
            {
                nameField.Text = salesPersonDataGridView.CurrentRow.Cells["Name"]?.Value.ToString();
                cnicField.Text = salesPersonDataGridView.CurrentRow.Cells["CNIC"]?.Value.ToString();
                mobileField.Text = salesPersonDataGridView.CurrentRow.Cells["Phone"]?.Value.ToString();
            }
        }

        private void deleteButtonClick(object sender, EventArgs e)
        {
            if (salesPersonDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Delete ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                int salesPersonID = Convert.ToInt32(salesPersonDataGridView.CurrentRow.Cells["SalesPersonID"]?.Value.ToString());

                employeeManager.DeleteSalesPerson(salesPersonID);

                employeeManager.LoadSalesPersonGrid(salesPersonDataGridView);

                emptyGridCheck();

            }
            else
            {
                MetroMessageBox.Show(this, "Deletion Canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void emptyGridCheck()
        {
            if (salesPersonDataGridView.RowCount == 0)
            {
                nameField.Clear();
                cnicField.Clear();
                mobileField.Clear();
            }
        }

        private void updateButoonClick(object sender, EventArgs e)
        {
            if (salesPersonDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(nameField.Text) || string.IsNullOrEmpty(mobileField.Text))
            {
                MetroMessageBox.Show(this, "Name and Mobile are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SalesPerson salePerson = new SalesPerson()
                {
                    SalesPersonID = Convert.ToInt32(salesPersonDataGridView.CurrentRow.Cells["SalesPersonID"]?.Value.ToString()),
                    Name = nameField.Text,
                    CNIC = cnicField.Text,
                    Phone = mobileField.Text,
                    IsActive = 1
                };

                employeeManager.UpdateSalesPerson(salePerson);

                employeeManager.LoadSalesPersonGrid(salesPersonDataGridView);

                MetroFramework.MetroMessageBox.Show(this, "Employee Details Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void onTextChange(object sender, EventArgs e)
        {
            employeeManager.LoadSalesPersonGrid(salesPersonDataGridView, searchField.Text);
            emptyGridCheck();
        }
    }
}