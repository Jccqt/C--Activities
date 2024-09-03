using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;

        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;
        public FrmConfirm()
        {
            InitializeComponent();
            
            #region Delegate Initialization
            DelProgram = StudentInfoClass.GetProgram;
            DelLastName = StudentInfoClass.GetLastName;
            DelFirstName = StudentInfoClass.GetFirstName;
            DelMiddleName = StudentInfoClass.GetMiddleName;
            DelAddress = StudentInfoClass.GetAddress;

            DelNumAge = StudentInfoClass.GetAge;
            DelNumContactNo = StudentInfoClass.GetContactNo;
            DelStudNo = StudentInfoClass.GetStudentNo;
            #endregion

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            TxtStudentNum.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            TxtProgram.Text = DelProgram(StudentInfoClass.Program);
            TxtLastName.Text = DelLastName(StudentInfoClass.LastName);
            TxtFirstName.Text = DelFirstName(StudentInfoClass.FirstName);
            TxtMiddleName.Text = DelMiddleName(StudentInfoClass.MiddleName);
            TxtAge.Text = DelNumAge(StudentInfoClass.Age).ToString();
            TxtContactNum.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            TxtAddress.Text = DelAddress(StudentInfoClass.Address);
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Student successfully registered!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
