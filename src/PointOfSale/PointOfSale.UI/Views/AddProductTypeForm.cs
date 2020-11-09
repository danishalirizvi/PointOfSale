using System;
using System.Windows.Forms;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Managers;

namespace PointOfSale.UI.Views
{
    public partial class AddProductTypeForm : MetroFramework.Forms.MetroForm
    {

        ItemManager itemManager = new ItemManager();
        public AddProductTypeForm()
        {
            InitializeComponent();
        }

        private void addTypeButtonClick(object sender, EventArgs e)
        {
            if (ItemNameField.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Product Type Name Field is Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                ProdType type = new ProdType();
                type.ProductType = ItemNameField.Text;
                type.Description = DescriptionField.Text;

                bool status = itemManager.AddProductType(type);

                if (status)
                {
                    ItemNameField.Clear();
                    DescriptionField.Clear();
                    MetroFramework.MetroMessageBox.Show(this, "Product Type Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Product Type Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
