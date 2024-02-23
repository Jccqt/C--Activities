using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region all grades will convert from String to decimal type
            decimal englishGrade = Convert.ToDecimal(textBox2.Text);
            decimal mathGrade = Convert.ToDecimal(textBox3.Text);
            decimal scienceGrade = Convert.ToDecimal(textBox4.Text);
            decimal filipinoGrade = Convert.ToDecimal(textBox5.Text);
            decimal historyGrade = Convert.ToDecimal(textBox6.Text);
            #endregion

            decimal averageGrade = (englishGrade + mathGrade + scienceGrade + filipinoGrade + historyGrade) / 5;
            label8.Visible = true;
            label9.Visible = true;
            string result = averageGrade >= 75.00m ? $"Student Passed\nThe general average of {textBox1.Text} is {averageGrade}" 
                : $"Student Failed\nThe general average of {textBox1.Text} is {averageGrade}";

            string face = averageGrade >= 75.00m ? "Congrats :)"
                : "Bawi next time :(";

            label8.Text = result;
            label9.Text = face;
        }
    }
}
