﻿namespace Read_Write
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.addEmployeeBTN = new System.Windows.Forms.Button();
            this.readFilesRTB = new System.Windows.Forms.RichTextBox();
            this.findEmployeeBTN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.updateBTN = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender:";
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(89, 23);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(156, 20);
            this.firstNameTB.TabIndex = 4;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(89, 48);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(156, 20);
            this.lastNameTB.TabIndex = 5;
            // 
            // genderCB
            // 
            this.genderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCB.Location = new System.Drawing.Point(89, 73);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(156, 21);
            this.genderCB.TabIndex = 6;
            // 
            // addressTB
            // 
            this.addressTB.Location = new System.Drawing.Point(89, 98);
            this.addressTB.Multiline = true;
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(156, 71);
            this.addressTB.TabIndex = 7;
            // 
            // addEmployeeBTN
            // 
            this.addEmployeeBTN.Location = new System.Drawing.Point(160, 175);
            this.addEmployeeBTN.Name = "addEmployeeBTN";
            this.addEmployeeBTN.Size = new System.Drawing.Size(85, 30);
            this.addEmployeeBTN.TabIndex = 8;
            this.addEmployeeBTN.Text = "Add Employee";
            this.addEmployeeBTN.UseVisualStyleBackColor = true;
            this.addEmployeeBTN.Click += new System.EventHandler(this.addEmployeeBTN_Click);
            // 
            // readFilesRTB
            // 
            this.readFilesRTB.Location = new System.Drawing.Point(251, 23);
            this.readFilesRTB.Name = "readFilesRTB";
            this.readFilesRTB.Size = new System.Drawing.Size(258, 182);
            this.readFilesRTB.TabIndex = 9;
            this.readFilesRTB.Text = "";
            // 
            // findEmployeeBTN
            // 
            this.findEmployeeBTN.Location = new System.Drawing.Point(251, 211);
            this.findEmployeeBTN.Name = "findEmployeeBTN";
            this.findEmployeeBTN.Size = new System.Drawing.Size(81, 34);
            this.findEmployeeBTN.TabIndex = 10;
            this.findEmployeeBTN.Text = "Find Employee";
            this.findEmployeeBTN.UseVisualStyleBackColor = true;
            this.findEmployeeBTN.Click += new System.EventHandler(this.findEmployeeBTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\james\\Source\\Repos\\Read-Write\\Read_Write\\Read_Write\\bin";
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(338, 211);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(87, 34);
            this.updateBTN.TabIndex = 11;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(431, 211);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(78, 34);
            this.deleteBTN.TabIndex = 12;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 257);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.findEmployeeBTN);
            this.Controls.Add(this.readFilesRTB);
            this.Controls.Add(this.addEmployeeBTN);
            this.Controls.Add(this.addressTB);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Read/Write .txt Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Button addEmployeeBTN;
        private System.Windows.Forms.RichTextBox readFilesRTB;
        private System.Windows.Forms.Button findEmployeeBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button deleteBTN;
    }
}

