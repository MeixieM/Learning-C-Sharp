using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheWindowForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            //this code is being executed when this form is loaded/launch

            //try/catch code that calls database connection

            //this is where you particularly set an initial value
            //this.Text = "Inventory Management System";

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //to call a form you need to instantiate
            AddStudentForm regForm = new AddStudentForm();

            //regForm.txtFullName.Text = "Alex Fernan";
            //regForm.txtStudentNo.Text = "2022-0001";




            if(regForm.ShowDialog() == DialogResult.OK)
            {
                txtResult.Text = "Student No: " + regForm.txtFullName.Text + Environment.NewLine + "FullName: " + regForm.txtStudentNo.Text; 
            }
        }
    }
}
