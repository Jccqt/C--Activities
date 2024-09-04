using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class frmCalculator : Form
    {
        CalculatorClass cal;
        private double num1, num2;

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if(!txtBoxInput1.Text.Equals("") && !txtBoxInput2.Text.Equals("") && !cbOperator.Text.Equals(""))
            {
                // will calculate if there's no empty box/es

                num1 = Convert.ToDouble(txtBoxInput1.Text.ToString());
                num2 = Convert.ToDouble(txtBoxInput2.Text.ToString());

                switch (cbOperator.SelectedItem.ToString())
                {
                    case "+":
                        cal.CalculateEvent += new Formula<double>(cal.GetSum);
                        lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                        break;
                    case "-":
                        cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                        lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                        break;
                    case "*":
                        cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                        lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                        break;
                    case "/":
                        cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                        lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                        break;
                }
            }
            else
            {
                // will prompt a message if there's an empty box/es
                MessageBox.Show("Can't calculate if there's an empty box/es", "Empty input boxes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // will clear the values in textboxes, combo box, and label
            txtBoxInput1.Clear();
            txtBoxInput2.Clear();
            cbOperator.SelectedIndex = -1;
            lblDisplayTotal.Text = "";

        }

        public frmCalculator()
        {
            InitializeComponent();
            lblDisplayTotal.Text = "";
            cal = new CalculatorClass();
        }

    }
}
