using PointOfSale.Data.DataAccess;
using PointOfSale.Data.Entities;
using System.Configuration;
using MetroFramework.Controls;
using System;
using PointOfSale.UI.Helper;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PointOfSale.UI.Managers
{
    public class EmployeeManager
    {
        EmployeeDao employeeDao = new EmployeeDao(LoadConnectionString());
        DataTable dt;
        public static string LoadConnectionString()
        {
            var provider = ConfigurationManager.AppSettings["DatabaseProvider"];
            return ConfigurationManager.ConnectionStrings[provider].ConnectionString;
        }

        public void LoadLoginUsersGrid(DataGridView loginUserDataGridView)
        {
            dt = new DataTable();
            List<LoginUser> types = employeeDao.getAllLoginUsers();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            loginUserDataGridView.DataSource = dt;

            //employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            loginUserDataGridView.AllowUserToAddRows = false;

            loginUserDataGridView.Columns["IsActive"].Visible = false;
            loginUserDataGridView.Columns["IsBlocked"].Visible = false;
            loginUserDataGridView.Columns["MaxPasswordLength"].Visible = false;
            loginUserDataGridView.Columns["MinPasswordLength"].Visible = false;
            loginUserDataGridView.Columns["AllowedAttempt"].Visible = false;
            loginUserDataGridView.Columns["InvalidAttempt"].Visible = false;
            loginUserDataGridView.Columns["ExpiryDate"].Visible = false;
            loginUserDataGridView.Columns["EmployeeID"].Visible = false;
            loginUserDataGridView.Columns["Password"].Visible = false;
        }

        public void LoadSalesPersonGrid(DataGridView salesPersonDataGridView)
        {
            dt = new DataTable();
            List<SalesPerson> salePerson = employeeDao.getAllSalePersons();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(salePerson);

            salesPersonDataGridView.DataSource = dt;

            salesPersonDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            salesPersonDataGridView.AllowUserToAddRows = false;
        }

        public void DeleteSalesPerson(int salesPersonID)
        {
            employeeDao.deleteSalesPerson(salesPersonID);
        }

        public void AddSalesPerson(SalesPerson salesperson)
        {
            employeeDao.addSalesPerson(salesperson);
        }

        public bool AddLoginUser(LoginUser user)
        {
            LoginUser l = employeeDao.getLoginUsers(user.Username);

            if (l == null)
            {
                employeeDao.addLoginUser(user);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Employment Role Start
        public bool AddEmploymentRole(EmploymentRole role)
        {

            EmploymentRole r = employeeDao.getEmploymentRole(role);

            if (r == null)
            {
                employeeDao.addEmploymentRole(role);
                return true;
            }
            else
            {
                return false;
            }
        }


        //Employment Role End

        //Employment Status Start
        public bool AddEmploymentStatus(EmploymentStatus employmentstatus)
        {
            EmploymentStatus s = employeeDao.getEmploymentStatus(employmentstatus);

            if (s == null)
            {
                employeeDao.addEmploymentStatus(employmentstatus);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void UpdateSalesPerson(SalesPerson salePerson)
        {
            employeeDao.updateSalesPerson(salePerson);
        }

        public void LoadSalesPersonGrid(DataGridView salesPersonDataGridView, string text)
        {
            dt = new DataTable();
            List<SalesPerson> salePerson = employeeDao.getAllSalePersons(text);
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(salePerson);

            salesPersonDataGridView.DataSource = dt;

            //employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            salesPersonDataGridView.AllowUserToAddRows = false;
        }

        //Employment Status End

        //Work Shift Start
        public bool AddWorkShift(WorkShift shift)
        {
            WorkShift w = employeeDao.getWorkShift(shift);

            if (w == null)
            {
                employeeDao.addWorkShift(shift);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteEmployee(int employeeID)
        {
            employeeDao.deleteEmployee(employeeID);
        }

        public void DeleteLoginUser(int userID)
        {
            employeeDao.deleteLoginUser(userID);
        }

        //Work Shift End

        //comboboxes data loading
        //public void LoadCombos(MetroComboBox genderPicker, MetroComboBox statusPicker, MetroComboBox rolePicker, MetroComboBox workShiftPicker)
        //{
        //    genderPicker.SelectedIndex = -1;

        //    List<EmploymentStatus> statusCollection = employeeDao.getEmploymentStatusList();
        //    ListtoDataTableConverter converter = new ListtoDataTableConverter();
        //    DataTable dt = converter.ToDataTable(statusCollection);
        //    statusPicker.DataSource = dt;
        //    statusPicker.ValueMember = "EmploymentStatusID";
        //    statusPicker.DisplayMember = "EmploymentStatusName";
        //    statusPicker.SelectedIndex = -1;

        //    List<EmploymentRole> roleCollection = employeeDao.getEmploymentRoleList();
        //    converter = new ListtoDataTableConverter();
        //    dt = converter.ToDataTable(roleCollection);
        //    rolePicker.DataSource = dt;
        //    rolePicker.ValueMember = "RoleTypeID";
        //    rolePicker.DisplayMember = "RoleName";
        //    rolePicker.SelectedIndex = -1;

        //    List<WorkShift> shiftCollection = employeeDao.getWorkShiftList();
        //    converter = new ListtoDataTableConverter();
        //    dt = converter.ToDataTable(shiftCollection);
        //    workShiftPicker.DataSource = dt;
        //    workShiftPicker.ValueMember = "WorkShiftID";
        //    workShiftPicker.DisplayMember = "WorkShiftName";
        //    workShiftPicker.SelectedIndex = -1;
        //}


        //add new Employee
        public void AddEmployee(Employee employee) {
            employeeDao.addEmployee(employee);
        }



        //manage employees
        public void LoadEmployeesGrid(DataGridView employeeDataGridView)
        {
            dt = new DataTable();
            List<Employee> employees = employeeDao.getAllEmployees();
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(employees);

            employeeDataGridView.DataSource = dt;

            //employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            employeeDataGridView.AllowUserToAddRows = false;
            employeeDataGridView.Columns["IsActive"].Visible = false;
            employeeDataGridView.Columns["IsBlocked"].Visible = false;
            employeeDataGridView.Columns["EmploymentStatusID"].Visible = false;
            employeeDataGridView.Columns["EmploymentRoleTypeID"].Visible = false;
            employeeDataGridView.Columns["WorkShiftID"].Visible = false;
            employeeDataGridView.Columns["EmploymentStatusName"].Visible = false;
            employeeDataGridView.Columns["RoleName"].Visible = false;
            employeeDataGridView.Columns["WorkShiftName"].Visible = false;

        }

        public bool UpdateLoginUser(LoginUser user)
        {
            LoginUser l = employeeDao.getLoginUsers(user.Username);

            if (l == null)
            {
                employeeDao.updateLoginUser(user);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LoadEmployeesGrid(DataGridView employeeDataGridView, string text)
        {
            dt = new DataTable();
            List<Employee> employees = employeeDao.getAllEmployees(text);
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(employees);

            employeeDataGridView.DataSource = dt;

            //employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            employeeDataGridView.AllowUserToAddRows = false;
            employeeDataGridView.Columns["IsActive"].Visible = false;
            employeeDataGridView.Columns["IsBlocked"].Visible = false;
            employeeDataGridView.Columns["EmploymentStatusID"].Visible = false;
            employeeDataGridView.Columns["EmploymentRoleTypeID"].Visible = false;
            employeeDataGridView.Columns["WorkShiftID"].Visible = false;
            employeeDataGridView.Columns["EmploymentStatusName"].Visible = false;
            employeeDataGridView.Columns["RoleName"].Visible = false;
            employeeDataGridView.Columns["WorkShiftName"].Visible = false;
        }

        public void LoadLoginUsersGrid(DataGridView loginUserDataGridView, string text)
        {
            dt = new DataTable();
            List<LoginUser> types = employeeDao.getAllLoginUsers(text);
            ListtoDataTableConverter converter = new ListtoDataTableConverter();
            dt = converter.ToDataTable(types);

            loginUserDataGridView.DataSource = dt;

            //employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            loginUserDataGridView.AllowUserToAddRows = false;

            loginUserDataGridView.Columns["IsActive"].Visible = false;
            loginUserDataGridView.Columns["IsBlocked"].Visible = false;
            loginUserDataGridView.Columns["MaxPasswordLength"].Visible = false;
            loginUserDataGridView.Columns["MinPasswordLength"].Visible = false;
            loginUserDataGridView.Columns["AllowedAttempt"].Visible = false;
            loginUserDataGridView.Columns["InvalidAttempt"].Visible = false;
            loginUserDataGridView.Columns["ExpiryDate"].Visible = false;
            loginUserDataGridView.Columns["EmployeeID"].Visible = false;
            loginUserDataGridView.Columns["Password"].Visible = false;
        }

        public void UpdateEmployee(Employee employee)
        {
            employeeDao.updateEmployee(employee);
        }
    }
}
