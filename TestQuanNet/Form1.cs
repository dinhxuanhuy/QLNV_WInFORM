using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQuanNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //if 
            if(txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                label2.Text = "Login Success";
                label3.Text = "Welcome to QuanNet";
            }
            else
            {
                txtpassword.Text = "";
            }
            //change text colour lable
            label2.ForeColor = Color.Green;
            label3.ForeColor = Color.Green;
            label2.Visible = true;
            label3.Visible = true;
            
        }
    }
}
