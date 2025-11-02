using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.School_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDisplayStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student(textBoxName.Text, int.Parse(textBoxGradeLevel.Text));

                string studentDetails = student.GetDetails();

                MessageBox.Show(studentDetails, "Student Details");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
    }
}
