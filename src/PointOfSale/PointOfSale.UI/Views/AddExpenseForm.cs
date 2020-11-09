using System;
using System.Windows.Forms;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Helper;

namespace PointOfSale.UI.Views
{
    public partial class AddExpenseForm : MetroFramework.Forms.MetroForm
    {
        ExpenseManager expenseManager = new ExpenseManager();
        public AddExpenseForm()
        {
            InitializeComponent();
            expenseManager.LoadCombos(expensePicker);
        }

        private void addNewExpenseButtonClick(object sender, EventArgs e)
        {
            if (expensePicker.SelectedIndex == -1 || amountField.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Expense Category and Amount are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!Validators.isPostiveDecimalNumber(amountField.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Expense Amount can be numeric only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Expense expense = new Expense()
                    {
                        Date = dateTimePicker.Text,
                        ExpenseName = expensePicker.Text,
                        Amount = Convert.ToInt32(amountField.Text),
                        Comment = commentField.Text,
                        IsActive = 1,
                        IsBlocked = 0
                    };

                    expenseManager.AddExpense(expense);

                    dateTimePicker.ResetText();
                    expensePicker.SelectedIndex = -1;
                    amountField.Clear();
                    commentField.Clear();

                    MetroFramework.MetroMessageBox.Show(this, "Expense Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

