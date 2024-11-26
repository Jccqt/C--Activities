using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace ClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        ClubRegistrationQuery clubRegistrationQuery = new ClubRegistrationQuery();
        ArrayList StudentID = new ArrayList();
        public FrmUpdateMember()
        {
            InitializeComponent();
        }

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {
            StudentID.Clear();
            cbStudentID.Items.Clear();

            clubRegistrationQuery.GetStudentIDList(StudentID);

            for(int i = 0; i < StudentID.Count; i++)
            {
                cbStudentID.Items.Add(StudentID[i]);
            }
        }

        private void cbStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            clubRegistrationQuery.GetStudentInfo(cbStudentID.Text);

            txtFirstName.Text = clubRegistrationQuery._FirstName;
            txtMiddleName.Text = clubRegistrationQuery._MiddleName;
            txtLastName.Text = clubRegistrationQuery._LastName;
            txtAge.Text = clubRegistrationQuery._Age.ToString();
            cbGender.Text = clubRegistrationQuery._Gender;
            cbProgram.Text = clubRegistrationQuery._Program;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult saveNewInformation = MessageBox.Show("Are you sure you want to update student information?",
                "Save New Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(saveNewInformation == DialogResult.Yes)
            {
                clubRegistrationQuery._FirstName = txtFirstName.Text;
                clubRegistrationQuery._MiddleName = txtMiddleName.Text;
                clubRegistrationQuery._LastName = txtLastName.Text;
                clubRegistrationQuery._Age = Convert.ToInt32(txtAge.Text);
                clubRegistrationQuery._Gender = cbGender.Text;
                clubRegistrationQuery._Program = cbProgram.Text;

                clubRegistrationQuery.UpdateInformation(cbStudentID.Text);
                MessageBox.Show("Update Successfully!");
                this.Dispose();
            }
            else
            {

            }
        }
    }
}
