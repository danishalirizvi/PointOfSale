using MetroFramework;
using PointOfSale.Data;
using PointOfSale.Data.Entities;
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
using System.Windows.Forms;

namespace PointOfSale.UI.Views
{
    public partial class ManagePaymentMethodForm : MetroFramework.Forms.MetroForm
    {
        DataTable dt;
        PaymentManager paymentManager;

        public ManagePaymentMethodForm()
        {
            InitializeComponent();
            paymentManager = new PaymentManager();
            if (Context.User.IsAdmin == 0)
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            LoadFormData();
        }

        private void LoadFormData()
        {
            List<PaymentMethod> methodCollection = paymentManager.GetAllPaymentMethods();

            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(methodCollection);

            paymentTypeDataGridView.DataSource = dt;

            paymentTypeDataGridView.AllowUserToAddRows = false;

            paymentTypeDataGridView.Columns["PaymentMethodID"].Visible = false;
            paymentTypeDataGridView.Columns["IsActive"].Visible = false;
            paymentTypeDataGridView.Columns["IsBlocked"].Visible = false;
        }

        private void onSelectionChange(object sender, EventArgs e)
        {
            if (paymentTypeDataGridView.CurrentRow != null)
            {
                methodLabel.Text = paymentTypeDataGridView.CurrentRow.Cells["Name"]?.Value.ToString();
            }
            if (methodLabel.Text == "Cash" || methodLabel.Text == "Due")
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
            else {
                bindingNavigatorDeleteItem.Enabled = true;
            }
        }

        private void deleteButtonClick(object sender, EventArgs e)
        {
            if (paymentTypeDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Delete This Payment Method", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                if (paymentTypeDataGridView.CurrentRow == null) return;

                int methodID = Convert.ToInt32(paymentTypeDataGridView.CurrentRow.Cells["PaymentMethodID"]?.Value.ToString());

                paymentManager.DeletePaymentMethod(methodID);

                LoadFormData();
            }
            else
            {
                MetroMessageBox.Show(this, "Deletion Canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}



