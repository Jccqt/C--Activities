using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeInterface;
using Employeenamespace;


namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        static PartTimeEmployee employee;
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void ComputeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (FirstNameBox.Text.Equals("") || LastNameBox.Text.Equals("") || DepartmentBox.Text.Equals("") || JobTitleBox.Text.Equals("") ||
                RateBox.Text.Equals("") || HourBox.Text.Equals(""))
                {
                    // will show a message if there is blank or empty details
                    MessageBox.Show("Please complete the empty details.", "Incomplete Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    employee = new PartTimeEmployee(FirstNameBox.Text, LastNameBox.Text, DepartmentBox.Text, JobTitleBox.Text);
                    employee.computeSalary(Convert.ToInt32(HourBox.Text.ToString()), Convert.ToDouble(RateBox.Text.ToString()));

                    FNameLabel.Text = employee.FirstName;
                    LNameLabel.Text = employee.LastName;
                    DepartmentLabel.Text = employee.Department;
                    JobLabel.Text = employee.JobTitle;
                    BasicSalaryLabel.Text = employee.getSalary().ToString();
                }
            }catch(Exception ex)
            {
                // will show a error message if the input on Rate per hour and Total worked hour include characters
                MessageBox.Show("Invalid input on Rate per hour or Total worked hour", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
