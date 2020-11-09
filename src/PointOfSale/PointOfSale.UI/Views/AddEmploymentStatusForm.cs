using System;
using System.Windows.Forms;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Entities;

namespace PointOfSale.UI.Views
{
    public partial class AddEmploymentStatusForm : MetroFramework.Forms.MetroForm
    {
        EmployeeManager employeeManager = new EmployeeManager();
        public AddEmploymentStatusForm()
        {
            InitializeComponent();
        }

        private void addEmploymentRoleButtonClick(object sender, EventArgs e)
        {
            EmploymentStatus employmentstatus = new EmploymentStatus()
            {
                EmploymentStatusName= nameField.Text,
                Description = descriptionField.Text,
                IsActive = 1,
                IsBlocked = 0
            };

            bool status = employeeManager.AddEmploymentStatus(employmentstatus);

            if (status)
            {
                nameField.Clear();
                descriptionField.Clear();
                MetroFramework.MetroMessageBox.Show(this, "Employment Status Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Employment Status Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
