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
using PointOfSale.Data.Entities;
using PointOfSale.UI.Managers;

namespace PointOfSale.UI.Views
{
    public partial class AddExpenseCatagoryForm : MetroFramework.Forms.MetroForm
    {
        ExpenseManager expenseManager = new ExpenseManager();
        public AddExpenseCatagoryForm()
        {
            InitializeComponent();
        }

        private void addExpenseCategoryButtonClick(object sender, EventArgs e)
        {
            if (expenseField.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "Expense Category Name is Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ExpenseCategory category = new ExpenseCategory()
                {
                    ExpenseName = expenseField.Text,
                    Description = descriptionField.Text,
                    IsActive = 1,
                    IsBlocked = 0
                };

                bool status = expenseManager.AddExpenseCategory(category);

                if (status)
                {
                    expenseField.Clear();
                    descriptionField.Clear();
                    MetroFramework.MetroMessageBox.Show(this, "Expense Category Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Expense Category Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
