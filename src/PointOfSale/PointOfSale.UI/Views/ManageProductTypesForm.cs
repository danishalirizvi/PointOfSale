using System;
using System.Data;
using System.Windows.Forms;
using PointOfSale.UI.Managers;
using MetroFramework;
using PointOfSale.Data.Entities;
using System.Collections.Generic;
using PointOfSale.UI.Helper;
using PointOfSale.Data;

namespace PointOfSale.UI.Views
{
    public partial class ManageProductTypesForm : MetroFramework.Forms.MetroForm
    {
        ItemManager itemManager = new ItemManager();
        public ManageProductTypesForm()
        {
            InitializeComponent();
            if (Context.User.IsAdmin == 0)
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            itemManager.LoadProductTypesGrid(typesDataGridView);
        }

        private void deleteButtonClick(object sender, EventArgs e)
        {
            if (typesDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string type = typesDataGridView.CurrentRow.Cells["ProductType"]?.Value.ToString();

            bool status = itemManager.CheckProductDependency(type);

            if (status) {
                DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Delete ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    if (typesDataGridView.CurrentRow == null) return;

                    string productType = typesDataGridView.CurrentRow.Cells["ProductType"]?.Value.ToString();

                    itemManager.DeleteProductType(productType);

                    itemManager.LoadProductTypesGrid(typesDataGridView);
                }
                else
                {
                    MetroMessageBox.Show(this, "Deletion Canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "System have Products of this Product Type. Remove them first to proceed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void onTextChange(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            List<ProdType> types = itemManager.GetProductTypes(searchField.Text);
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);
            typesDataGridView.DataSource = dt;

            typesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            typesDataGridView.AllowUserToAddRows = false;
            typesDataGridView.Columns["IsActive"].Visible = false;
            typesDataGridView.Columns["IsBlocked"].Visible = false;
            //(typesDataGridView.DataSource as DataTable).DefaultView.RowFilter = string.Format("ProductType LIKE '%{0}%'", searchField.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (typesDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txttypeupdate.Text == "")
            {
                MetroMessageBox.Show(this, "Product Type Name Field is Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool status;

            string currentName = typesDataGridView.CurrentRow.Cells["ProductType"]?.Value.ToString();


            status = itemManager.CheckProductType(currentName, txttypeupdate.Text);

            if (status)
            {
                ProdType type = new ProdType();
                type.ProductType = txttypeupdate.Text;
                type.Description = txtDescription.Text;

                itemManager.UpdateProductType(currentName,type);

                MetroMessageBox.Show(this, "Product Type Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                itemManager.LoadProductTypesGrid(typesDataGridView);
                if (typesDataGridView.CurrentRow == null)
                {
                    txttypeupdate.Clear();
                    txtDescription.Clear();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Product Type Name Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void typesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (typesDataGridView.CurrentRow != null)
            {
                txttypeupdate.Text = typesDataGridView.CurrentRow.Cells["ProductType"]?.Value.ToString();
                txtDescription.Text = typesDataGridView.CurrentRow.Cells["Description"]?.Value.ToString();
            }
        }
    }
}
