﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileCreator
{
    public partial class FrmRegistration : Form
    {
    
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            frmFileName.SetFileName = $"{txtStudentNo.Text}.txt";
            string[] studentInfo = {txtStudentNo.Text,
                $"{txtLastName.Text}, {txtFirstName.Text},{txtMiddleName.Text}",
                cbProgram.Text,
                cbGender.Text,
                txtAge.Text,
                dtBirthDate.Text,
                txtContactNo.Text};

            string[] studentLabel = { "Student No: ", "Full Name: ", "Program: ", "Gender: ", "Age: ", 
                                "Birthday: ", "Contact No.: "};


            

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, frmFileName.SetFileName)))
            {
                int counter = 0;
               foreach(string info in studentInfo)
                {
                    outputFile.WriteLine(studentLabel[counter] + info);
                    counter++;
                }
            }

            MessageBox.Show("Registration Successfully!", "Successful Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Array.Clear(studentLabel, 0, studentLabel.Length);
            Array.Clear(studentInfo, 0, studentInfo.Length);
            txtStudentNo.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtAge.Clear();
            txtContactNo.Clear();
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            using (FrmStudentRecord recordPage = new FrmStudentRecord())
            {
                recordPage.ShowDialog();
            }
        }
    }
}
