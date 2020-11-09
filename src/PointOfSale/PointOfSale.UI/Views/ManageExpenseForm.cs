using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;
using PointOfSale.UI.Managers;
using MetroFramework;
using PointOfSale.UI.Helper;
using PointOfSale.Data.Entities;
using PointOfSale.Data;

namespace PointOfSale.UI.Views
{
    public partial class ManageExpenseForm : MetroFramework.Forms.MetroForm
    {
        ExpenseManager expenseManager = new ExpenseManager();

        public ManageExpenseForm()
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
            expenseManager.LoadCombos(expensePicker);
            expenseManager.LoadExpensesGrid(expenseDataGridView);
        }

        private void onSelectionChange(object sender, EventArgs e)
        {
            if (expenseDataGridView.CurrentRow != null)
            {
                expensePicker.SelectedValue = expenseDataGridView.CurrentRow.Cells["ExpenseName"]?.Value.ToString();
                amountField.Text = expenseDataGridView.CurrentRow.Cells["Amount"]?.Value.ToString();
                commentsField.Text = expenseDataGridView.CurrentRow.Cells["Comment"]?.Value.ToString();
                //datePicker.Text = expenseDataGridView.CurrentRow.Cells["Date"]?.Value.ToString();
            }
        }

        private void deleteButtonClick(object sender, EventArgs e)
        {
            if (expenseDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            
            DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Delete ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                if (expenseDataGridView.CurrentRow == null) return;

                int expenseID = Convert.ToInt32(expenseDataGridView.CurrentRow.Cells["ExpenseID"]?.Value.ToString());

                if (expenseID == 0) return;

                expenseManager.DeleteExpense(expenseID);

                expenseManager.LoadExpensesGrid(expenseDataGridView);

                emptyGridCheck();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Deletion Canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void emptyGridCheck()
        {
            if (expenseDataGridView.RowCount == 0)
            {
                expensePicker.SelectedIndex = -1;
                amountField.Clear();
                commentsField.Clear();
            }
        }

        private void updateButtonClicked(object sender, EventArgs e)
        {
            if (expenseDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (expensePicker.SelectedIndex == -1 || amountField.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Expense Category and Amount are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!Validators.numericOnly(amountField.Text))
                {
                    MetroMessageBox.Show(this, "Expense Amount can be numeric only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Expense expense = new Expense()
                    {
                        ExpenseID = Convert.ToInt32(expenseDataGridView.CurrentRow.Cells["ExpenseID"]?.Value.ToString()),
                        Date = datePicker.Text,
                        ExpenseName = expensePicker.Text,
                        Amount = Convert.ToInt32(amountField.Text),
                        Comment = commentsField.Text,
                        IsActive = 1,
                        IsBlocked = 0
                    };

                    expenseManager.UpdateExpense(expense);

                    expenseManager.LoadExpensesGrid(expenseDataGridView);

                    MetroMessageBox.Show(this, "Expense Details Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void onTextChange(object sender, EventArgs e)
        {
            expenseManager.LoadExpensesGrid(expenseDataGridView,searchField.Text);
            emptyGridCheck();
        }
    }
}
