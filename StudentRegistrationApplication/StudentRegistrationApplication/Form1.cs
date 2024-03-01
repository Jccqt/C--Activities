using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for(int i = 1900; i <= 2024; i++)
            {
                Years.Items.Add(i);
            }

            string[] months = {"January", "February", "March", "April", "May", "June", "July", "August",
                                "September", "October", "November", "December"};

            // will add items to Months combo box
            foreach(string month in months)
            {
                Months.Items.Add(month);
            }

            ArrayList programs = new ArrayList();
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");

            // will add items to ProgramsBox
            foreach(string program in programs)
            {
                ProgramsBox.Items.Add(program);
            }
        } // end of Form1 method

        private void Register_Click(object sender, EventArgs e)
        {   

            // will give warning if Last Name Box is empty
            if (LastNameTextBox.Text.Equals(""))
            {
                LastNameWarning.Visible = true;
            }
            else
            {
                LastNameWarning.Visible = false;
            }

            // will give warning if First Name Box is empty
            if (FirstNameTextBox.Text.Equals(""))
            {
                FirstNameWarning.Visible = true;
            }
            else
            {
                FirstNameWarning.Visible = false;
            }

            // will give warning if Male and Female Box is empty
            if (!Male.Checked && !Female.Checked)
            {
                GenderWarning.Visible = true;
            }
            else
            {
                GenderWarning.Visible = false;
            }

            // will give warning if Birth date box is empty
            if ((Days.Text.Equals("-Day") || Months.Text.Equals("-Month") || Years.Text.Equals("-Year"))
                || (Days.Text.Equals("") || Months.Text.Equals("") || Years.Text.Equals("")))
            {
                BirthWarning.Visible = true;
            }
            else
            {
                BirthWarning.Visible = false;
            }

            // will give warning if Programs box is empty
            if (ProgramsBox.Text.Equals(""))
            {
                ProgramsBoxWarning.Visible = true;
            }
            else
            {
                ProgramsBoxWarning.Visible = false;
            }

            string gender = "";
            if (Male.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
            
            // will only print the message if there's no visible warning
            if(LastNameWarning.Visible == false && FirstNameWarning.Visible == false && GenderWarning.Visible == false
                && BirthWarning.Visible == false && ProgramsBoxWarning.Visible == false)
            {
                MessageBox.Show($"Student Name: {FirstNameTextBox.Text} {MiddleNameTextBox.Text} {LastNameTextBox.Text}"
                + $"\nGender: {gender}"
                + $"\nDate of Birth: {Days.Text}/{Months.Text}/{Years.Text}"
                + $"\nProgram: {ProgramsBox.Text}");
                MessageBox.Show($"{FirstNameTextBox.Text} has successfully registered!");
                
            }
        }// end of RegisterClick method

        private void Months_SelectedIndexChanged(object sender, EventArgs e)
        {
            Days.Text = ""; // will remove the text in Days box if Months text is changed

            if (Months.Text.Equals("February") && yearNum % 4 == 0)
            {   
                Days.Items.Clear(); // will clear the items of Days box

                // will add 29 items to Days box if the month is February and a leap year
                for (int i = 1; i <= 29; i++)
                {
                    Days.Items.Add(i);
                }
            }
            else if(Months.Text.Equals("February"))
            {
                Days.Items.Clear(); // will clear the items of Days box

                // will add 28 items to Days box if the month is February and not a leap year
                for (int i = 1; i <= 28; i++)
                {
                    Days.Items.Add(i);
                }
            }
            else
            {
                Days.Items.Clear(); // will clear the items of Days box

                // will add 31 items to Days box if the month is not February
                for (int i = 1; i <= 31; i++)
                {
                    Days.Items.Add(i);
                }
            }
        } // end of Months_SelectedIndexChanged method

        static int yearNum;
        private void Years_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearNum = Convert.ToInt32(Years.Text.ToString());
            Days.Text = ""; // will remove the text in Days box if Years text is changed
            Months.Text = ""; // will remove the text in Months box if Years text is changed

        } // end of Years_SelectedIndexChanged method
    }
}
