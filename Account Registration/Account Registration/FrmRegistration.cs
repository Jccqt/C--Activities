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
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            #region StudentInfoClass variables
            StudentInfoClass.FirstName = BoxFirstName.Text.ToString();
            StudentInfoClass.LastName = BoxLastName.Text.ToString();
            StudentInfoClass.MiddleName = BoxMiddleName.Text.ToString();
            StudentInfoClass.Address = BoxAddress.Text.ToString();
            StudentInfoClass.Program = BoxProgram.SelectedItem.ToString();

            // long.Parse converts string into long data type
            StudentInfoClass.Age = long.Parse(BoxAge.Text.ToString());
            StudentInfoClass.ContactNo = long.Parse(BoxContactNum.Text.ToString());
            StudentInfoClass.StudentNo = long.Parse(BoxStudentNum.Text.ToString());
            #endregion

            using (FrmConfirm ConfirmPage = new FrmConfirm())
            {
                DialogResult diag = MessageBox.Show("Please confirm the details on the next page before submitting.", "Student Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // will show the Confirm Page if the user choose "OK";
                if (diag == DialogResult.OK)
                {
                    ConfirmPage.ShowDialog();

                    // will clear the text boxes and combo boxes
                    BoxStudentNum.Clear();
                    BoxProgram.SelectedIndex = -1;
                    BoxLastName.Clear();
                    BoxFirstName.Clear();
                    BoxMiddleName.Clear();
                    BoxAddress.Clear();
                    BoxAge.Clear();
                    BoxContactNum.Clear();
                }
            }
        }
    }
}
