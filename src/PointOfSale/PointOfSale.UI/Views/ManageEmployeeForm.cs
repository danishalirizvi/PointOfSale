using MetroFramework;
using PointOfSale.Data;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Helper;
using PointOfSale.UI.Managers;
using System;
using System.Windows.Forms;

namespace PointOfSale.UI.Views
{
    public partial class ManageEmployeeForm : MetroFramework.Forms.MetroForm
    {
        EmployeeManager employeeManager = new EmployeeManager();
        public ManageEmployeeForm()
        {
            InitializeComponent();
            if (Context.User.IsAdmin == 0)
            {
                bindingNavigatorDeleteItem.Enabled = false;
                employeeBindingNavigatorSaveItem.Enabled = false;
            }
        }

        private void onFormLoad(object sender, EventArgs e)
        {
            employeeManager.LoadEmployeesGrid(employeeDataGridView);
        }

        private void onSelectionChange(object sender, EventArgs e)
        {
            if (employeeDataGridView.CurrentRow != null)
            {
                nameField.Text = employeeDataGridView.CurrentRow.Cells["Name"]?.Value.ToString();
                fatherField.Text = employeeDataGridView.CurrentRow.Cells["FatherName"]?.Value.ToString();
                //dobPicker.Value = DateTime.Parse(employeeDataGridView.CurrentRow.Cells["DOB"]?.Value.ToString());
                genderPicker.Text = employeeDataGridView.CurrentRow.Cells["Gender"]?.Value.ToString();
                cnicField.Text = employeeDataGridView.CurrentRow.Cells["CNIC"]?.Value.ToString();
                bloodGroupField.Text = employeeDataGridView.CurrentRow.Cells["BloodGroup"]?.Value.ToString();
                primaryField.Text = employeeDataGridView.CurrentRow.Cells["PrimaryMobile"]?.Value.ToString();
                secondaryField.Text = employeeDataGridView.CurrentRow.Cells["SecondaryMobile"]?.Value.ToString();
                emailField.Text = employeeDataGridView.CurrentRow.Cells["Email"]?.Value.ToString();
                addressField.Text = employeeDataGridView.CurrentRow.Cells["Address"]?.Value.ToString();
                salaryField.Text = employeeDataGridView.CurrentRow.Cells["Salary"]?.Value.ToString();
                //joinDatePicker.Value = DateTime.Parse(employeeDataGridView.CurrentRow.Cells["JoiningDate"]?.Value.ToString());
                //employmentStatusPicker.Text = employeeDataGridView.CurrentRow.Cells["EmploymentStatusID"]?.Value.ToString();
                //employmentRolePicker.Text = employeeDataGridView.CurrentRow.Cells["EmploymentRoleTypeID"]?.Value.ToString();
                //workShiftPicker.Text = employeeDataGridView.CurrentRow.Cells["WorkShiftID"]?.Value.ToString();
                
            }
        }

        private void deleteButtonClick(object sender, EventArgs e)
        {
            if (employeeDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MetroMessageBox.Show(this, "Do you Really Want to Delete ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                if (employeeDataGridView.CurrentRow == null) return;

                int employeeID = Convert.ToInt32(employeeDataGridView.CurrentRow.Cells["EmployeeID"]?.Value.ToString());

                employeeManager.DeleteEmployee(employeeID);

                employeeManager.LoadEmployeesGrid(employeeDataGridView);

                emptyGridCheck();
                
            }
            else
            {
                MetroMessageBox.Show(this, "Deletion Canceled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void emptyGridCheck()
        {
            if (employeeDataGridView.RowCount == 0)
            {
                nameField.Clear();
                fatherField.Clear();
                //dobPicker.Value = DateTime.Parse(employeeDataGridView.CurrentRow.Cells["DOB"]?.Value.ToString());
                genderPicker.SelectedIndex = -1;
                cnicField.Clear();
                bloodGroupField.Clear();
                primaryField.Clear();
                secondaryField.Clear();
                emailField.Clear();
                addressField.Clear();
                salaryField.Clear();
            }
        }

        private void updateButoonClick(object sender, EventArgs e)
        {
            if (employeeDataGridView.CurrentRow == null)
            {
                MetroMessageBox.Show(this, "No Row Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(nameField.Text) || string.IsNullOrEmpty(primaryField.Text))
            {
                MetroMessageBox.Show(this, "Name and Primary Mobile are Mandatory", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!Validators.numericOnly(salaryField.Text))
                {
                    MetroMessageBox.Show(this, "Salary Must be Numeric", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Employee employee = new Employee()
                    {
                        EmployeeID = Convert.ToInt32(employeeDataGridView.CurrentRow.Cells["EmployeeID"]?.Value.ToString()),
                        Name = nameField.Text,
                        DOB = dobPicker.Text.ToString(),
                        Gender = genderPicker.SelectedItem?.ToString(),
                        FatherName = fatherField.Text,
                        CNIC = cnicField.Text,
                        PrimaryMobile = primaryField.Text,
                        SecondaryMobile = secondaryField.Text,
                        Email = emailField.Text,
                        Address = addressField.Text,
                        Salary = Convert.ToInt32(salaryField.Text),
                        JoiningDate = joinDatePicker.Text.ToString(),
                        //EmploymentStatusID = Int32.Parse(statusPicker.SelectedValue.ToString()),
                        //EmploymentRoleTypeID = Int32.Parse(rolePicker.SelectedValue.ToString()),
                        //WorkShiftID = Int32.Parse(workShiftPicker.SelectedValue.ToString()),
                        IsActive = 1,
                        IsBlocked = 0,
                        BloodGroup = bloodGroupField.Text
                    };

                    employeeManager.UpdateEmployee(employee);

                    employeeManager.LoadEmployeesGrid(employeeDataGridView);

                    MetroFramework.MetroMessageBox.Show(this, "Employee Details Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void onTextChange(object sender, EventArgs e)
        {
            employeeManager.LoadEmployeesGrid(employeeDataGridView,searchField.Text);
            emptyGridCheck();
        }
    }
}
