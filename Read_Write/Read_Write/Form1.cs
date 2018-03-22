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
        public Form1()
        {
            InitializeComponent();
        }

        private void addEmployeeBTN_Click(object sender, EventArgs e)
        { 
            
            //will write a file for each employee
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Employees\\" + firstNameTB.Text + " "
                    + lastNameTB.Text + ".txt"))
            {                             
                sw.WriteLine(label1.Text + " " + firstNameTB.Text);
                sw.WriteLine(label2.Text + " " + lastNameTB.Text);
                sw.WriteLine(label3.Text + " " + genderCB.Text);
                sw.WriteLine(label4.Text + " " + addressTB.Text); 
            }

            StreamReader sr = new StreamReader(Application.StartupPath + "\\Employees\\" + firstNameTB.Text + " "
                    + lastNameTB.Text + ".txt");

            readFilesRTB.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
