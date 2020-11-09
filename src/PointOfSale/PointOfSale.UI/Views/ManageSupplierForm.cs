using System;
using System.Data;
using System.Windows.Forms;
using PointOfSale.UI.Managers;
using MetroFramework;
using PointOfSale.Data.Entities;
using PointOfSale.Data;

namespace PointOfSale.UI.Views
{
    public partial class ManageSupplierForm : MetroFramework.Forms.MetroForm
    {
        SupplierManager supplierManager = new SupplierManager();
        public ManageSupplierForm()
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
            supplierManager.LoadSuppliersGrid(supplierDataGridView);
        }

        private void onSelectionChange(object sender, EventArgs e)
        {
            populateFields();
        }

        private void populateFields()
        {
            nameField.Text = supplierDataGridView.CurrentRow.Cells["Name"]?.Value.ToString();
            cnicField.Text = supplierDataGridView.CurrentRow.Cells["CNIC"]?.Value.ToString();
            companyField.Text = supplierDataGridView.CurrentRow.Cells["CompanyName"]?.Value.ToString();
            primaryField.Text = supplierDataGridView.CurrentRow.Cells["PrimaryMobile"]?.Value.ToString();
            secondaryField.Text = supplierDataGridView.CurrentRow.Cells["SecondaryMobile"]?.Value.ToString();
            emailField.Text = supplierDataGridView.CurrentRow.Cells["Email"]?.Value.ToString();
            addressField.Text = supplierDataGridView.CurrentRow.Cells["Address"]?.Value.ToString();
        }

        private void deleteButtonClicked(object sender, EventArgs e)
        {
            if (supplierDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Delete ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                if (supplierDataGridView.CurrentRow == null) return;

                int supplierID = Convert.ToInt32(supplierDataGridView.CurrentRow.Cells["SupplierID"]?.Value.ToString());

                supplierManager.DeleteSupplier(supplierID);

                supplierManager.LoadSuppliersGrid(supplierDataGridView);

                emprtyGridCheck();
            }
            else
            {
                MetroMessageBox.Show(this, "Deletion Canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void emprtyGridCheck()
        {
            if (supplierDataGridView.RowCount == 0)
            {
                nameField.Clear();
                cnicField.Clear();
                companyField.Clear();
                primaryField.Clear();
                secondaryField.Clear();
                emailField.Clear();
                addressField.Clear();
            }
        }

        private void updateButtonClicked(object sender, EventArgs e)
        {
            if (supplierDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(nameField.Text) || string.IsNullOrEmpty(primaryField.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Name and Primary Mobile are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Supplier supplier = new Supplier()
                {
                    SupplierID = Convert.ToInt32(supplierDataGridView.CurrentRow.Cells["SupplierID"]?.Value.ToString()),
                    Name = nameField.Text,
                    CompanyName = companyField.Text,
                    CNIC = cnicField.Text,
                    Address = addressField.Text,
                    Email = emailField.Text,
                    PrimaryMobile = primaryField.Text,
                    SecondaryMobile = secondaryField.Text,
                    IsActive = 1,
                    IsBlocked = 0
                };

                supplierManager.UpdateSupplier(supplier);

                supplierManager.LoadSuppliersGrid(supplierDataGridView);

                //populateFields();

                MetroFramework.MetroMessageBox.Show(this, "Supplier Details Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void onTextChange(object sender, EventArgs e)
        {
            supplierManager.LoadSuppliersGrid(supplierDataGridView,searchField.Text);
            emprtyGridCheck();
            //(supplierDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("Name LIKE '%{0}%'", searchField.Text);
        }
    }
}
