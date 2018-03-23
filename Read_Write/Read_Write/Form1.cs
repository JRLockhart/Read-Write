using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Read_Write
{
    public partial class Form1 : Form
    {

        private string filename;

        public Form1()
        {
            InitializeComponent();
        }

        private void addEmployeeBTN_Click(object sender, EventArgs e)
        { 
            
            //will write a file for each employee
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Employees\\" + firstNameTB.Text + "_"
                    + lastNameTB.Text + ".txt"))
            {                             
                sw.WriteLine(label1.Text + " " + firstNameTB.Text);
                sw.WriteLine(label2.Text + " " + lastNameTB.Text);
                sw.WriteLine(label3.Text + " " + genderCB.Text);
                sw.WriteLine(label4.Text + " " + addressTB.Text); 
            }


            //Will read the file that was saved to the directory
            StreamReader sr = new StreamReader(Application.StartupPath + "\\Employees\\" + firstNameTB.Text + "_"
                    + lastNameTB.Text + ".txt");

            readFilesRTB.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void findEmployeeBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            
            //set to the folder where employees are saved
            openFileDialog1.InitialDirectory = @"C:\MyFolder\Default\";
            openFileDialog1.Title = "Search for Employee";

            //pop open a message box if file doesn't exist
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.ShowReadOnly = true;

            
            //populate the read files text box with txt file content
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string name = openFileDialog1.FileName;
                readFilesRTB.Clear();
                readFilesRTB.Text += File.ReadAllText(name) + "\n";

                filename = name;

            }
        }

        //allow user to update the information in the rich text box
        private void updateBTN_Click(object sender, EventArgs e)
        {
            //first check to see if text exists
            if (string.IsNullOrEmpty(readFilesRTB.Text))
            {
                MessageBox.Show("There is nothing to update");
            }
            else
            {
                //save to the current file
                File.WriteAllText(filename, readFilesRTB.Text);
            }
        }   

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(readFilesRTB.Text))
            {
                MessageBox.Show("There is nothing to delete");
            }
            else
            {
                //delete the current file
                File.Delete(filename);
                readFilesRTB.Clear();
            }
        }
    }
}
