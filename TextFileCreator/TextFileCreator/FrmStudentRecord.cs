using System;
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
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();
            string docPath = openFileDialog1.FileName;

            using (StreamReader reader = File.OpenText(docPath))
            {
                string getText = "";
                while ((getText = reader.ReadLine()) != null)
                {
                    lvShowText.Items.Add(getText);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if(lvShowText.Items.Count == 0)
            {
                DialogResult emptyFile = MessageBox.Show("There is no file attached on the record", "No File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Successfully Uploaded!");
                lvShowText.Clear();
            }
        }
    }
}
