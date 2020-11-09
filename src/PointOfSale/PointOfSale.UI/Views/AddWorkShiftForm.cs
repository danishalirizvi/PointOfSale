using System;
using System.Windows.Forms;
using PointOfSale.UI.Managers;
using PointOfSale.Data.Entities;

namespace PointOfSale.UI.Views
{
    public partial class AddWorkShiftForm : MetroFramework.Forms.MetroForm
    {
        EmployeeManager employeeManager = new EmployeeManager();
        public AddWorkShiftForm()
        {
            InitializeComponent();
        }

        private void addWorkShiftButtonClick(object sender, EventArgs e)
        {
            WorkShift shift = new WorkShift()
            {
                WorkShiftName = nameField.Text,
                Description = descriptionField.Text,
                ShiftStartTime = startTimePicker.Value.ToString(),
                ShiftEndTime = endTimePicker.Value.ToString(),
                IsActive = 1,
                IsBlocked = 0
            };

            bool status = employeeManager.AddWorkShift(shift);

            if (status)
            {
                nameField.Clear();
                descriptionField.Clear();
                MetroFramework.MetroMessageBox.Show(this, "Work Shift Added Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Work Shift Already Exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
