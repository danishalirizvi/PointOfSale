using PointOfSale.Data;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Reports.Sales.All;
using PointOfSale.UI.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.UI.Views
{
    public partial class HomePage : MetroFramework.Forms.MetroForm
    {
        LoginUser user = Context.User;

        public HomePage()
        {
            InitializeComponent();
            if (Context.User.IsAdmin == 0)
            {
                toolStripMenuItem4.Enabled = false;
            }
        }

        private void closeButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewProductTypeButtonClick(object sender, EventArgs e)
        {
            AddProductTypeForm form = new AddProductTypeForm();
            form.ShowDialog();
        }

        private void onLoad(object sender, EventArgs e)
        {
            activeUserLabel.Text = user.Username;
        }

        private void onAddNewSupplierButtonClick(object sender, EventArgs e)
        {
            AddSupplierForm form = new AddSupplierForm();
            //form.BringToFront();
            form.ShowDialog();
        }

        private void addEmploymentRoleButtonClick(object sender, EventArgs e)
        {
            AddEmploymentRoleForm form = new AddEmploymentRoleForm();
            form.ShowDialog();
        }

        private void addEmploymentStatusButtonClick(object sender, EventArgs e)
        {
            AddEmploymentStatusForm form = new AddEmploymentStatusForm();
            form.ShowDialog();
        }

        private void addWorkShiftButtonClick(object sender, EventArgs e)
        {
            AddWorkShiftForm form = new AddWorkShiftForm();
            form.ShowDialog();
        }

        private void addNewEmployeeButtonClick(object sender, EventArgs e)
        {
            AddEmployeeForm form = new AddEmployeeForm();
            form.ShowDialog();
        }

        private void addPaymentMethodButtonClick(object sender, EventArgs e)
        {
            AddPaymentMethodForm form = new AddPaymentMethodForm();
            form.ShowDialog();
        }

        private void addExpenseCategoryButtonClick(object sender, EventArgs e)
        {
            AddExpenseCatagoryForm form = new AddExpenseCatagoryForm();
            form.ShowDialog();
        }

        private void addExpenseButtonClick(object sender, EventArgs e)
        {
            AddExpenseForm form = new AddExpenseForm();
            form.ShowDialog();
        }

        private void managePaymentTypeButtonClick(object sender, EventArgs e)
        {
            ManagePaymentMethodForm form = new ManagePaymentMethodForm();
            form.ShowDialog();
        }

        private void manageProductTypesButtonClick(object sender, EventArgs e)
        {
            ManageProductTypesForm form = new ManageProductTypesForm();
            form.ShowDialog();
        }

        private void manageSupplierButtonClick(object sender, EventArgs e)
        {
            ManageSupplierForm form = new ManageSupplierForm();
            form.ShowDialog();
        }

        private void manageEmployeeButtonClick(object sender, EventArgs e)
        {
            ManageEmployeeForm form = new ManageEmployeeForm();
            form.ShowDialog();
        }

        private void manageExpenseButtonClick(object sender, EventArgs e)
        {

            ManageExpenseForm form = new ManageExpenseForm();
            form.ShowDialog();
        }

        private void manageExpenseCategoryButton(object sender, EventArgs e)
        {
            ManageExpenseCategoryForm form = new ManageExpenseCategoryForm();
            form.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleInvoiceForm form = new SaleInvoiceForm();
            form.ShowDialog();
        }

        private void addProductItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm form = new AddItemForm();
            form.ShowDialog();
        }

        private void manageLoginUserButtonClick(object sender, EventArgs e)
        {
            ManageLoginUserForm form = new ManageLoginUserForm();
            form.ShowDialog();
        }

        private void addNewCustomerButtonClick(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.ShowDialog();
        }

        private void manageCustomerButtonClick(object sender, EventArgs e)
        {
            ManageCustomerForm form = new ManageCustomerForm();
            form.ShowDialog();
        }

        private void purchaseInvoiceButtonClick(object sender, EventArgs e)
        {
            PurchaseInvoiceForm form = new PurchaseInvoiceForm();
            form.ShowDialog();
        }


        private void invoiceDeskButtonClick(object sender, EventArgs e)
        {
            InvoiceDeskForm form = new InvoiceDeskForm();
            form.ShowDialog();
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroTileSettings_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.ShowDialog();
        }

        private void metroLinkAddNewCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm form = new AddCustomerForm();
            form.ShowDialog();
        }

        private void metroTileNewInvoice_Click(object sender, EventArgs e)
        {
            SaleInvoiceForm form = new SaleInvoiceForm();
            form.ShowDialog();
        }

        private void metroLinkAddItem_Click(object sender, EventArgs e)
        {
            AddItemForm form = new AddItemForm();
            form.ShowDialog();
        }

        private void metroLinkItemList_Click(object sender, EventArgs e)
        {
            OnlyShowItemForm frm1 = new OnlyShowItemForm();
            frm1.ShowDialog();
        }

        private void metroLinkCustomerList_Click(object sender, EventArgs e)
        {
            ManageCustomerForm frm1 = new ManageCustomerForm();
            frm1.ShowDialog();
        }

        private void metroTileInvoiceMSystem_Click(object sender, EventArgs e)
        {
            InvoiceDeskForm form = new InvoiceDeskForm();
            form.ShowDialog();
        }

        private void metroTileItem_Click(object sender, EventArgs e)
        {
            AddSupplierForm form = new AddSupplierForm();
            //form.BringToFront();
            form.ShowDialog();
        }

        private void tile_addExpense_Click(object sender, EventArgs e)
        {
            AddExpenseForm form = new AddExpenseForm();
            form.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void allSalesReportMenuButtonClick(object sender, EventArgs e)
        {
            SalesForm form = new SalesForm();
            form.ShowDialog();
        }

        private void metroLinkSalesByBank_Click(object sender, EventArgs e)
        {
            PaymentMethodReportForm form = new PaymentMethodReportForm();
            form.ShowDialog();
        }

        private void metroLinkCustomerWiseSales_Click(object sender, EventArgs e)
        {
            SalesByCustomerReportForm form = new SalesByCustomerReportForm();
            form.ShowDialog();
        }

        private void metroLinkItemWiseSales_Click(object sender, EventArgs e)
        {
            SalesByItemReportForm form = new SalesByItemReportForm();
            form.ShowDialog();
        }

        private void itemReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemReportForm form = new ItemReportForm();
            form.ShowDialog();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierReportForm form = new SupplierReportForm();
            form.ShowDialog();
        }

        private void allExpenseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpenseReportFrom form = new ExpenseReportFrom();
            form.ShowDialog();
        }

        private void incomeStatementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void otherReportDropDownButton_Click(object sender, EventArgs e)
        {

        }

        private void expenseByCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExpensByCategoryReportForm form = new ExpensByCategoryReportForm();
            form.ShowDialog();
        }

        private void allSupplierPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllSuplierReportForm form = new AllSuplierReportForm();
            form.ShowDialog();
        }

        private void allSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm form = new SalesForm();
            form.ShowDialog();
        }

        private void salesByCashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentMethodReportForm form = new PaymentMethodReportForm();
            form.ShowDialog();
        }

        private void salesByCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesByCustomerReportForm form = new SalesByCustomerReportForm();
            form.ShowDialog();
        }

        private void salesByProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesByItemReportForm form = new SalesByItemReportForm();
            form.ShowDialog();
        }

        private void metroTileTools_Click(object sender, EventArgs e)
        {
            AddItemForm form = new AddItemForm();
            form.ShowDialog();
        }

        private void showAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OnlyShowItemForm form = new OnlyShowItemForm();
            form.ShowDialog();
        }

        private void newTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvoiceDeskForm form = new InvoiceDeskForm();
            form.ShowDialog();
        }

        private void metroLinkEdit_Click(object sender, EventArgs e)
        {
            ManageCustomerForm frm1 = new ManageCustomerForm();
            frm1.ShowDialog();
        }

        private void metroLinkAllExpense_Click(object sender, EventArgs e)
        {
            ExpenseReportFrom form = new ExpenseReportFrom();
            form.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            AddSalesPersonForm form = new AddSalesPersonForm();
            form.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ManageSalesPersonForm form = new ManageSalesPersonForm();
            form.ShowDialog();
        }
    }
}
