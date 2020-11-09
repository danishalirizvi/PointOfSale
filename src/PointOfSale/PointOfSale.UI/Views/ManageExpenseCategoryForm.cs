using MetroFramework;
using PointOfSale.Data;
using PointOfSale.UI.Managers;
using System;
using System.Windows.Forms;

namespace PointOfSale.UI.Views
{
    public partial class ManageExpenseCategoryForm : MetroFramework.Forms.MetroForm
    {
        ExpenseManager expenseManager = new ExpenseManager();
        public ManageExpenseCategoryForm()
        {
            InitializeComponent();
            if (Context.User.IsAdmin == 0)
            {
                bindingNavigatorDeleteItem.Enabled = false;
            }
        }

        private void onLoad(object sender, System.EventArgs e)
        {
            expenseManager.LoadCategoryGrid(categoryDataGridView);
        }

        private void deleteButtonClicked(object sender, System.EventArgs e)
        {
            if (categoryDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Delete ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                if (categoryDataGridView.CurrentRow == null) return;

                string category = categoryDataGridView.CurrentRow.Cells["ExpenseName"]?.Value.ToString();

                expenseManager.DeleteExpenseCategory(category);

                expenseManager.LoadCategoryGrid(categoryDataGridView);

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Deletion Canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void onTextChange(object sender, EventArgs e)
        {
            expenseManager.LoadCategoryGrid(categoryDataGridView,searchField.Text);
        }
    }
}
