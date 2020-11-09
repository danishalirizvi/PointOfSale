using PointOfSale.Data.DataAccess;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace PointOfSale.UI.Managers
{
    public class ExpenseManager
    {
        ExpenseDao expenseDao = new ExpenseDao(LoadConnectionString());

        

        DataTable dt;

        public static string LoadConnectionString()
        {
            var provider = ConfigurationManager.AppSettings["DatabaseProvider"];
            return ConfigurationManager.ConnectionStrings[provider].ConnectionString;
        }

        public void LoadCombos(ComboBox expensePicker)
        {
            List<ExpenseCategory> expenseCategories = expenseDao.getAllExpenceCategories();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            DataTable dt = converter.ToDataTable(expenseCategories);
            expensePicker.DataSource = dt;
            expensePicker.ValueMember = "ExpenseName";
            expensePicker.DisplayMember = "ExpenseName";
            expensePicker.SelectedIndex = -1;
        }

        public void DeleteExpenseCategory(string category)
        {
            expenseDao.deleteExpenseCategory(category);
        }

        public bool AddExpenseCategory(ExpenseCategory category)
        {
            ExpenseCategory c = expenseDao.getExpenseCategory(category);

            if (c == null)
            {
                expenseDao.addExpenseCategory(category);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadCategoryGrid(DataGridView categoryDataGridView, string text)
        {
            dt = new DataTable();
            List<ExpenseCategory> types = expenseDao.getAllExpenceCategories(text);
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            categoryDataGridView.DataSource = dt;

            categoryDataGridView.AllowUserToAddRows = false;
            categoryDataGridView.Columns["IsActive"].Visible = false;
            categoryDataGridView.Columns["IsBlocked"].Visible = false;
        }

        public void AddExpense(Expense expense)
        {
            expenseDao.addExpense(expense);
        }

        public void DeleteExpense(int expenseID)
        {
            expenseDao.deleteExpense(expenseID);
        }

        public void LoadExpensesGrid(DataGridView expenseDataGridView)
        {
            dt = new DataTable();
            List<Expense> types = expenseDao.getAllExpenses();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            expenseDataGridView.DataSource = dt;

            //employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            expenseDataGridView.AllowUserToAddRows = false;

            expenseDataGridView.Columns["IsActive"].Visible = false;
            expenseDataGridView.Columns["IsBlocked"].Visible = false;
        }



        public void LoadCategoryGrid(DataGridView categoryDataGridView)
        {
            dt = new DataTable();
            List<ExpenseCategory> types = expenseDao.getAllExpenceCategories();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            categoryDataGridView.DataSource = dt;

            categoryDataGridView.AllowUserToAddRows = false;
            categoryDataGridView.Columns["IsActive"].Visible = false;
            categoryDataGridView.Columns["IsBlocked"].Visible = false;
        }

        public void UpdateExpense(Expense expense)
        {
            expenseDao.updateExpense(expense);
        }

        public void LoadExpensesGrid(DataGridView expenseDataGridView, string text)
        {
            dt = new DataTable();
            List<Expense> types = expenseDao.getAllExpenses(text);
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            expenseDataGridView.DataSource = dt;

            //employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            expenseDataGridView.AllowUserToAddRows = false;

            expenseDataGridView.Columns["IsActive"].Visible = false;
            expenseDataGridView.Columns["IsBlocked"].Visible = false;
        }
    }
}
