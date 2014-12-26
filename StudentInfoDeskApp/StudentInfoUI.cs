using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoDeskApp
{
    public partial class StudentInfoUI : Form
    {
        Student aStudent = new Student();
        public StudentInfoUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string sName = Convert.ToString(nameTextBox.Text);
            string sDeptName = deptTextBox.Text;
            string sEmail = emailTextBox.Text;
            string sContact = contactTextBox.Text;
            string sAddress = addressTextBox.Text;
            MessageBox.Show("Information Save");
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            aStudent.id = Convert.ToInt32(idTextBox.Text);
            aStudent.name = nameTextBox.Text;
            aStudent.dept = nameTextBox.Text;
            aStudent.email = nameTextBox.Text;
            aStudent.contact = nameTextBox.Text;
            aStudent.address = nameTextBox.Text;
            
            ClearStudentInfoTextBox();
            MessageBox.Show("Student Information: " + "\nId: " + aStudent.id +
                "\nName: " + aStudent.name + "\nDepartment: " + aStudent.dept +
                "\nEmail: " + aStudent.email + "\nContact: " + aStudent.contact +
                "\nAddress" + aStudent.address);
        }

        private void ClearStudentInfoTextBox()
        {
            idTextBox.Text = "";
            nameTextBox.Text = "";
            deptTextBox.Text = "";
            emailTextBox.Text = "";
            contactTextBox.Text = "";
            addressTextBox.Text = "";
        }
    }
}
