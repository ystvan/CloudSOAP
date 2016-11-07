using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentSOAPConsumerApp.ServiceReference1;

namespace StudentSOAPConsumerApp
{
    public partial class Form1 : Form
    {
        ServiceReference1.StudentServiceClient studentClient = new StudentServiceClient();

        private string cpr;
        private string name;
        private string address;

        

        public Form1()
        {
            InitializeComponent();
            studentListView.DataSource = studentClient.GetAllStudents();
        }

        private void cprTextBox_TextChanged(object sender, EventArgs e)
        {
            cpr = cprTextBox.Text;

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            address = addressTextBox.Text;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            studentClient.AddStudent(new Student() {CprNo = cpr, Address = address, Name = name});
            studentListView.DataSource = studentClient.GetAllStudents();


        }

        
    }
}
