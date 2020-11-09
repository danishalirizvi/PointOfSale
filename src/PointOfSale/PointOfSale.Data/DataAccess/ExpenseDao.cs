using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.Data.Entities;
using System.Data;
using System.Data.SQLite;
using Dapper;
using PointOfSale.Data.Params;

namespace PointOfSale.Data.DataAccess
{
    public class ExpenseDao
    {
        private string _connectionstring = string.Empty;
        public ExpenseDao(string connectionString)
        {
            _connectionstring = connectionString;
        }

        public ExpenseCategory getExpenseCategory(ExpenseCategory category)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.QueryFirstOrDefault<ExpenseCategory>
                    (@"SELECT * FROM ExpenseCategory WHERE lower(ExpenseName) = @ExpenseName and IsActive = 1 and IsBlocked = 0"
                    , new { ExpenseName = category.ExpenseName.ToLower() });
                return output;
            }
        }

        public List<ExpenseCategory> getAllExpenceCategories()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<ExpenseCategory>
                    (@"SELECT * FROM ExpenseCategory where IsActive = 1 and IsBlocked = 0");
                return output?.ToList();
            }
        }

        public void deleteExpenseCategory(string category)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"DELETE FROM ExpenseCategory WHERE ExpenseName = @ExpenseName"
                        , new { ExpenseName = category });
            }
        }

        public List<Expense> getExpenseByCategory(ReportParams param)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Expense>
                    (@"SELECT * from Expense where
                        strftime('%d-%m-%Y %H:%M:%S', Date)>=@FromDate
                        and strftime('%d-%m-%Y %H:%M:%S', Date)<=@ToDate and ExpenseName = @ExpenseName",
                        new { FromDate = param.FromDate, ToDate = param.ToDate, ExpenseName = param.ExpenseName});
                return output?.ToList();
            }
        }

        public void addExpenseCategory(ExpenseCategory category)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.ExecuteScalar
                    (@"INSERT INTO ExpenseCategory(ExpenseName, Description, IsActive, IsBlocked)
                                        VALUES(@ExpenseName, @Description, @IsActive, @IsBlocked)"
                    , new { ExpenseName = category.ExpenseName, Description = category.Description, IsActive = category.IsActive, IsBlocked = category.IsBlocked });
            }
        }

        public List<ExpenseCategory> getAllExpenceCategories(string text)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<ExpenseCategory>
                    (@"SELECT * FROM ExpenseCategory  where ExpenseName LIKE '%" + text + "%' and IsActive = 1 and IsBlocked = 0");
                return output?.ToList();
            }
        }

        public void deleteExpense(int expenseID)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"UPDATE Expense SET IsActive = 0 where ExpenseID = @ExpenseID"
                    , new { ExpenseID = expenseID });
            }
        }

        public void addExpense(Expense expense)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"INSERT INTO Expense(ExpenseName, Amount, Comment, Date, IsActive, IsBlocked)
                                        VALUES(@ExpenseName, @Amount, @Comment, @Date, @IsActive, @IsBlocked)"
                    , new
                    {
                        ExpenseName = expense.ExpenseName,
                        Amount = expense.Amount,
                        Comment = expense.Comment,
                        Date = expense.Date,
                        IsActive = expense.IsActive,
                        IsBlocked = expense.IsBlocked
                    });
            }
        }

        public void updateExpense(Expense expense)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                con.Execute(@"UPDATE Expense SET ExpenseName = @ExpenseName, Amount = @Amount, Comment = @Comment
                            , Date = @Date where ExpenseID = @ExpenseID"
                        , new
                        {
                            ExpenseName = expense.ExpenseName,
                            Amount = expense.Amount,
                            Comment = expense.Comment,
                            Date = expense.Date,
                            ExpenseID = expense.ExpenseID
                        });
            }
        }

        public List<Expense> getAllExpenses(string text)
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Expense>
                    (@"SELECT * FROM Expense where ExpenseName LIKE '%" + text + "%' and IsActive = 1 and IsBlocked = 0");
                return output?.ToList();
            }
        }

        public List<Expense> getAllExpenses()
        {
            using (IDbConnection con = new SQLiteConnection(_connectionstring))
            {
                var output = con.Query<Expense>
                    (@"SELECT * FROM Expense where IsActive = 1 and IsBlocked = 0");
                return output?.ToList();
            }
        }
    }
}
