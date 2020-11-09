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

namespace PointOfSale.UI.Views
{
    public partial class ShowItemForm : MetroFramework.Forms.MetroForm
    {
        public ShowItemForm()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }

        private void ShowItemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productDatabaseDataSet.Products' table. You can move, or remove it, as needed.
            //this.productsTableAdapter.Fill(this.productDatabaseDataSet.Products);
            
            

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void productsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            

        }

        private void productsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
           

        }

        private void txt_SearchProductName_TextChanged(object sender, EventArgs e)
        {
           
        }
        
        private void metroTile1_Click(object sender, EventArgs e)
        {
            OnlyShowItemForm frm1 = new OnlyShowItemForm();
            frm1.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //Form1 frm1 = new Form1();
            //frm1.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            //SupplierForm frm1 = new SupplierForm();
            //frm1.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            //CurrentStockForm frm1 = new CurrentStockForm();
            //frm1.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            //CustomerForm frm1 = new CustomerForm();
            //frm1.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            
        }

        private void productsBindingNavigatorSaveItem_Click_3(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.productDatabaseDataSet);

        }
    }
}
