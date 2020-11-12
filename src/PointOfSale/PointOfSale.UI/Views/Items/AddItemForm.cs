using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Helper;

namespace PointOfSale.UI.Views
{
    public partial class AddItemForm : MetroFramework.Forms.MetroForm
    {
        public ProductManager productManager { get; set; }

        public AddItemForm()
        {
            InitializeComponent();
            productManager = new ProductManager();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
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

            //if (!string.IsNullOrEmpty(txtReorder.Text) || !Validators.isPostiveDecimalNumberOrZero(txtReorder.Text))
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "ReOrder Level not Valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtReorder.Focus();
            //    return;
            //}
            if (!string.IsNullOrEmpty(txtReorder.Text))
            {
                if (!Validators.numericOnly(txtReorder.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "ReOrder Level not Valid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReorder.Focus();
                    return;
                }
            }





            bool nameAvailable = productManager.CheckProductName(txt_ItemName.Text);
            bool codeAvailable = productManager.CheckProductCode(txtProductCode.Text);
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
                        ProductName = txt_ItemName.Text,
                        ProductCode = txtProductCode.Text,
                        UnitType = cmbUnitType.SelectedItem?.ToString(),
                        ProductType = cmbProductTypes.SelectedValue.ToString(),
                        ReOrderLevel = string.IsNullOrEmpty(txtReorder.Text.ToString()) ? 0 : Convert.ToInt32(txtReorder.Text.ToString())
                    };
                    if (chk_Active.CheckState == CheckState.Checked)
                    {
                        product.IsActive = 1;
                    }
                    else if (chk_Active.CheckState == CheckState.Unchecked)
                    {
                        product.IsActive = 0;
                    }
                    if (chk_Gift.CheckState == CheckState.Checked)
                    {
                        product.Gift = 1;
                    }
                    else if (chk_Gift.CheckState == CheckState.Unchecked)
                    {
                        product.Gift = 0;
                    }

                    productManager.SaveProduct(product);
                    MetroFramework.MetroMessageBox.Show(this, "Item Added Successfully ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_ItemName.Clear();
                    txtProductCode.Clear();
                    cmbUnitType.SelectedIndex = -1;
                    cmbProductTypes.SelectedIndex = -1;
                    txt_ItemName.Focus();
                    txtReorder.Clear();
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error Occured on Save !! Please contact administrator ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            OnlyShowItemForm frm1 = new OnlyShowItemForm();
            frm1.ShowDialog();
        }

        private void On_Load(object sender, EventArgs e)
        {
            LoadCombos();
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

    }
}
