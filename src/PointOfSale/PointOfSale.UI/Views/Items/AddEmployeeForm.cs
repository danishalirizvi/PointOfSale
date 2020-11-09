using System;
using System.Windows.Forms;
using System.Configuration;
using PointOfSale.Data.DataAccess;
using PointOfSale.UI.Helper;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Entities;

namespace PointOfSale.UI.Views
{
    public partial class AddEmployeeForm : MetroFramework.Forms.MetroForm
    {
        EmployeeDao employeeDao;
        EmployeeManager employeeManager;

        public AddEmployeeForm()
        {
            InitializeComponent();
            employeeManager = new EmployeeManager();
            employeeDao = new EmployeeDao(LoadConnectionString());
            //employeeManager.LoadCombos(genderPicker, statusPicker, rolePicker, workShiftPicker);
        }

        public static string LoadConnectionString()
        {
            var provider = ConfigurationManager.AppSettings["DatabaseProvider"];
            return ConfigurationManager.ConnectionStrings[provider].ConnectionString;
        }

        private void addEmployeeButtonClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameField.Text) || string.IsNullOrEmpty(primaryField.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Name and Primary Mobile are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!Validators.numericOnly(salaryField.Text))
                {
                    MetroFramework.MetroMessageBox.Show(this, "Salary Must be Numeric", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Employee employee = new Employee()
                    {
                        Name = nameField.Text,
                        DOB = dobDatePicker.Text.ToString(),
                        Gender = genderPicker.SelectedItem?.ToString(),
                        FatherName = fatherNameField.Text,
                        CNIC = cnicField.Text,
                        PrimaryMobile = primaryField.Text,
                        SecondaryMobile = secondaryField.Text,
                        Email = emailField.Text,
                        Address = addressField.Text,
                        JoiningDate = joiningDatePicker.Text.ToString(),
                        //EmploymentStatusID = Int32.Parse(statusPicker.SelectedValue.ToString()),
                        //EmploymentRoleTypeID = Int32.Parse(rolePicker.SelectedValue.ToString()),
                        //WorkShiftID = Int32.Parse(workShiftPicker.SelectedValue.ToString()),
                        IsActive = 1,
                        IsBlocked = 0,
                        BloodGroup = bloodGroupField.Text
                    };
                    if (salaryField.Text != "")
                    {
                        employee.Salary = Int32.Parse(salaryField.Text);
                    }

                    employeeManager.AddEmployee(employee);

                    nameField.Clear();
                    dobDatePicker.ResetText();
                    genderPicker.SelectedIndex = -1;
                    fatherNameField.Clear();
                    cnicField.Clear();
                    primaryField.Clear();
                    secondaryField.Clear();
                    emailField.Clear();
                    addressField.Clear();
                    salaryField.Clear();
                    //joiningDatePicker.ResetText();
                    //statusPicker.ResetText();
                    //rolePicker.ResetText();
                    workShiftPicker.ResetText();
                    bloodGroupField.Clear();

                    MetroFramework.MetroMessageBox.Show(this, "Employee Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
