using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Helper;
using MetroFramework;

namespace PointOfSale.UI.Views
{
    public partial class OnlyShowItemForm : MetroFramework.Forms.MetroForm
    {

        ProductManager productManager;
        int priceSum = 0, rawPriceSum = 0;

        public OnlyShowItemForm()
        {
            InitializeComponent();
            productManager = new ProductManager();
        }

        private void CalculateTotals()
        {
            for (int i = 0; i < productsDataGridView.Rows.Count; ++i)
            {
                priceSum += Convert.ToInt32(productsDataGridView.Rows[i].Cells[9].Value) * Convert.ToInt32(productsDataGridView.Rows[i].Cells[5].Value);
                rawPriceSum += Convert.ToInt32(productsDataGridView.Rows[i].Cells[8].Value) * Convert.ToInt32(productsDataGridView.Rows[i].Cells[5].Value);
            }
            priceTotaallbl.Text = priceSum.ToString();
            rawPriceTotallbl.Text = rawPriceSum.ToString();
        }

        private void LoadCombos()
        {
            LoadProductTypes();
        }

        private void LoadProductTypes()
        {
            List<ProdType> types = productManager.GetProductTypes();
            var converter = new ListtoDataTableConverter();
            var dt = converter.ToDataTable(types);
            cmbProductTypes.DataSource = dt;
            cmbProductTypes.ValueMember = "ProductType";
            cmbProductTypes.DisplayMember = "ProductType";
            cmbProductTypes.SelectedIndex = -1;
        }

        public void LoadProductGrid()
        {
            populateGrid();
        }

        private void OnlyShowItemForm_Load(object sender, EventArgs e)
        {
            LoadCombos();

            LoadProductGrid();

            CalculateTotals();
        }

        private void txt_SrchProName_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            List<Product> product = productManager.GetProducts(txt_SrchProName.Text);
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(product);

            productsDataGridView.DataSource = dt;

            productsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            productsDataGridView.AllowUserToAddRows = false;

            productsDataGridView.Columns["IsActive"].Visible = false;
            //productsDataGridView.Columns["IsBlocked"].Visible = false;
        }

        private void productsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (productsDataGridView.CurrentRow != null)
            {
                txt_ItemName.Text = productsDataGridView.CurrentRow.Cells["ProductName"]?.Value.ToString();
                cmbProductTypes.SelectedValue = productsDataGridView.CurrentRow.Cells["ProductType"]?.Value.ToString();
                cmbUnitType.SelectedItem = productsDataGridView.CurrentRow.Cells["UnitType"]?.Value.ToString();
                txtProductCode.Text = productsDataGridView.CurrentRow.Cells["ProductCode"]?.Value.ToString();
                if (productsDataGridView.CurrentRow.Cells["IsActive"]?.Value.ToString() == "1")
                {
                    chk_Active.Checked = true;
                }
                else if (productsDataGridView.CurrentRow.Cells["IsActive"]?.Value.ToString() == "0")
                {
                    chk_Active.Checked = false;
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Delete ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                int productID = Convert.ToInt32(productsDataGridView.CurrentRow.Cells["ProductID"]?.Value.ToString());

                productManager.DeleteProduct(productID);

                populateGrid();
            }
            else
            {
                MetroMessageBox.Show(this, "Deletion Canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void populateGrid()
        {
            DataTable dt = new DataTable();
            List<Product> product = productManager.GetProducts();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(product);

            productsDataGridView.DataSource = dt;

            //productsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            productsDataGridView.AllowUserToAddRows = false;

            productsDataGridView.Columns["IsActive"].Visible = false;
            productsDataGridView.Columns["ProductID"].Visible = false;
            //productsDataGridView.Columns["IsBlocked"].Visible = false;

            emprtyGridCheck();
        }

        private void emprtyGridCheck()
        {
            if (productsDataGridView.RowCount == 0)
            {
                txt_ItemName.Clear();
                cmbProductTypes.SelectedIndex = -1;
                cmbUnitType.SelectedIndex = -1;
                txtProductCode.Clear();
                chk_Active.Checked = false;
            }
        }

        private void rawPriceTotallbl_Click(object sender, EventArgs e)
        {

        }

        private void priceTotaallbl_Click(object sender, EventArgs e)
        {

        }

        private void expenseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (productsDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_ItemName.Text.Trim() == string.Empty)
            {

                MetroFramework.MetroMessageBox.Show(this, "Item Name is Required", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ItemName.Focus();
                return;
            }

            if (cmbUnitType.Text.Trim() == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Unit is Required", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUnitType.Focus();
                return;
            }

            if (cmbProductTypes.Text.Trim() == string.Empty)
            {
                MetroFramework.MetroMessageBox.Show(this, "Item Type is Required", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUnitType.Focus();
                return;
            }

            int productID = Convert.ToInt32(productsDataGridView.CurrentRow.Cells["ProductID"]?.Value.ToString());
            string currentName = productsDataGridView.CurrentRow.Cells["ProductName"]?.Value.ToString();
            string currentCode = productsDataGridView.CurrentRow.Cells["ProductCode"]?.Value.ToString();

            bool nameAvailable, codeAvailable;

            if (currentName == txt_ItemName.Text)
            {
                nameAvailable = productManager.CheckProductName(txt_ItemName.Text, productID);
            }
            else
            {
                nameAvailable = productManager.CheckProductName(txt_ItemName.Text);
            }



            if (currentCode == txtProductCode.Text)
            {
                codeAvailable = productManager.CheckProductCode(txtProductCode.Text, productID);
            }
            else
            {
                codeAvailable = productManager.CheckProductCode(txtProductCode.Text);
            }


            if (!nameAvailable)
            {
                MetroFramework.MetroMessageBox.Show(this, "Item Name Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!codeAvailable)
            {
                MetroFramework.MetroMessageBox.Show(this, "Item Code Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Product product = new Product()
                    {
                        ProductID = productID,
                        ProductName = txt_ItemName.Text,
                        ProductCode = txtProductCode.Text,
                        UnitType = cmbUnitType.SelectedItem?.ToString(),
                        ProductType = cmbProductTypes.SelectedValue.ToString()
                    };
                    if (chk_Active.CheckState == CheckState.Checked)
                    {
                        product.IsActive = 1;
                    }
                    else if (chk_Active.CheckState == CheckState.Unchecked)
                    {
                        product.IsActive = 0;
                    }

                    productManager.UpdateProduct(product);
                    MetroFramework.MetroMessageBox.Show(this, "Item Updated Successfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    populateGrid();
                    emprtyGridCheck();

                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error Occured on Save !! Please contact administrator ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //****************************************

            //


            //if (p == null && p.ProductID == Convert.ToInt32(productsDataGridView.CurrentRow.Cells["ProductID"]?.Value.ToString()))
            //{
            //    

            //    

            //    try
            //    {
            //        
            //        MetroFramework.MetroMessageBox.Show(this, "Item Updated Successfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txt_ItemName.Clear();
            //        txtProductCode.Clear();
            //        cmbProductTypes.SelectedIndex = -1;
            //        txt_ItemName.Focus();

            //    }
            //    catch (Exception ex)
            //    {
            //        MetroMessageBox.Show(this, "Error Occured on Save !! Please contact administrator ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MetroMessageBox.Show(this, "Product Code already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //LoadProductGrid();
        }


    }
}

