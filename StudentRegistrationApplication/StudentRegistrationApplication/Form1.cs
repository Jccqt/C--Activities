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

            // will add months 
            for(int i = 1; i <= 12; i++)
            {
                Months.Items.Add(i);
            }

            // will add number of days to the days box except if February
            for (int i = 1; i <= 31; i++)
            {
                Days.Items.Add(i);
            }

            
        }

        private void Register_Click(object sender, EventArgs e)
        {   

            // will give warning if Last Name Box is empty
            if (LastNameTextBox.Text.Equals(""))
            {
                LastNameWarning.Visible = true;
            }

            // will give warning if First Name Box is empty
            if (FirstNameTextBox.Text.Equals(""))
            {
                FirstNameWarning.Visible = true;
            }

            // will give warning if Male and Female Box is empty
            if (!Male.Checked && !Female.Checked)
            {
                GenderWarning.Visible = true;
            }

            // will give warning if Birth date box is empty
            if (Days.Text.Equals("-Day") || Months.Text.Equals("-Month") || Years.Text.Equals("-Year"))
            {
                BirthWarning.Visible = true;
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

            if(!LastNameTextBox.Text.Equals("") && !FirstNameTextBox.Text.Equals("") && (Male.Checked || Female.Checked)
                && (!Days.Text.Equals("-Day") || !Months.Text.Equals("-Month") || !Years.Text.Equals("-Year")))
            {
                MessageBox.Show($"Student Name: {FirstNameTextBox.Text} {MiddleNameTextBox.Text} {LastNameTextBox.Text}"
                + $"\nGender: {gender}"
                + $"\nBirth Date: {Days.Text}/{Months.Text}/{Years.Text}");
            }
        } 
    }
}
