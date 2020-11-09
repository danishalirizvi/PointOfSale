using System;
using System.Windows.Forms;
using PointOfSale.Data.Entities;
using PointOfSale.UI.Managers;

namespace PointOfSale.UI.Views
{
    public partial class AddEmploymentRoleForm : MetroFramework.Forms.MetroForm
    {
        EmployeeManager employeeManager = new EmployeeManager();
        public AddEmploymentRoleForm()
        {
            InitializeComponent();
        }

        private void addEmploymentRoleButtonClick(object sender, EventArgs e)
        {
            EmploymentRole role = new EmploymentRole()
            {
                RoleName = nameField.Text,
                BasicSalary = Int32.Parse(salaryField.Text),
                Description = descriptionField.Text,
                IsActive = 1,
                IsBlocked = 0
            };

            bool status = employeeManager.AddEmploymentRole(role);

            if (status)
            {
                nameField.Clear();
                salaryField.Clear();
                descriptionField.Clear();
                MetroFramework.MetroMessageBox.Show(this, "Employment Role Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Employment Role Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
