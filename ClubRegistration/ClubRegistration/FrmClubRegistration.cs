using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class FrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        private int ID, Age, count;
        private string FirstName, MiddleName, LastName, Gender, Program;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using(FrmUpdateMember updatePage = new FrmUpdateMember())
            {
                updatePage.ShowDialog();
            }
        }

        private long StudentId;

        public FrmClubRegistration()
        {
            InitializeComponent();
        }

        void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();
            DataGridClubMembers.DataSource = clubRegistrationQuery.bindingSource;
        }

        private void FrmClubRegistration_Load(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();
        }

        int RegistrationID()
        {
            return count + 1;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            clubRegistrationQuery.RegisterStudent(long.Parse(txtStudentID.Text), txtFirstName.Text,
                txtMiddleName.Text, txtLastName.Text, Convert.ToInt32(txtAge.Text), cbGender.Text, cbProgram.Text);
        }
    }
}
