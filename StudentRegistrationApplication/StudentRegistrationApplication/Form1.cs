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
        static string genderMain = "";
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
            if (Male.Checked)
            {
                genderMain = "Male";
            }
            else
            {
                genderMain = "Female";
            }

            if(FirstNameTextBox.Text.Equals("") && LastNameTextBox.Text.Equals("") && MiddleNameTextBox.Text.Equals("")
                && ProgramsBox.Text.Equals("") && !Male.Checked && !Female.Checked && Days.Text.Equals("-Day")
                && Months.Text.Equals("-Month") && Years.Text.Equals("-Year"))
            {
                Message();

            } 
            else if(MiddleNameTextBox.Text.Equals("") && !Male.Checked && !Female.Checked && Days.Text.Equals("-Day")
                && Months.Text.Equals("-Month") && Years.Text.Equals("-Year"))
            {
                Message(FirstNameTextBox.Text, LastNameTextBox.Text, ProgramsBox.Text);
            }
            else if (!Male.Checked && !Female.Checked && Days.Text.Equals("-Day")
                && Months.Text.Equals("-Month") && Years.Text.Equals("-Year"))
            {
                Message(FirstNameTextBox.Text, MiddleNameTextBox.Text, LastNameTextBox.Text, ProgramsBox.Text);
            }
            else if (Days.Text.Equals("-Day") || Months.Text.Equals("-Month") || Years.Text.Equals("-Year"))
            {
                Message(FirstNameTextBox.Text, MiddleNameTextBox.Text, LastNameTextBox.Text, genderMain, ProgramsBox.Text);
            }
            else
            {
                Message(FirstNameTextBox.Text, MiddleNameTextBox.Text, LastNameTextBox.Text, genderMain, Days.Text, Months.Text, Years.Text, ProgramsBox.Text);
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

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();

            if(openFile.ShowDialog() == DialogResult.OK)
            {
                PictureBox.Image = Bitmap.FromFile(openFile.FileName);
            }

        }

        public void Message()
        {
            MessageBox.Show("No information added!" +
                "\nCannot register the student.");
        }// end of Message method with no parameters
        public void Message(string firstName, string lastName, string program)
        {
            MessageBox.Show($"Student Name: {FirstNameTextBox.Text} {LastNameTextBox.Text}"
                +$"\nProgram: {ProgramsBox.Text}");
        }// end of Message method with 3 parameters

        public void Message(string firstName, string middleName, string lastName, string program)
        {

            MessageBox.Show($"Student Name: {FirstNameTextBox.Text} {MiddleNameTextBox.Text} {LastNameTextBox.Text}"
               + $"\nProgram: {ProgramsBox.Text}");
        }// end of Message method with 4 parameters

        public void Message(string firstName, string middleName, string lastName, string gender, string program)
        {
            MessageBox.Show($"Student Name: {FirstNameTextBox.Text} {MiddleNameTextBox.Text} {LastNameTextBox.Text}"
                + $"\nGender: {genderMain}"
               + $"\nProgram: {ProgramsBox.Text}");
        }// end of Message method with 5 parameters

        public void Message(string firstName, string middleName, string lastName, string gender, string day, string month, string year, string program)
        {
            MessageBox.Show($"Student Name: {FirstNameTextBox.Text} {MiddleNameTextBox.Text} {LastNameTextBox.Text}"
                + $"\nGender: {genderMain}"
                +$"\nDate of Birth: {Days.Text}/{Months.Text}/{Years.Text}"
               + $"\nProgram: {ProgramsBox.Text}");
        }// end of Message method with 8 parameters
    }

}
