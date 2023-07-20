using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Suer, Do you really want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string pass = txtpassword.Text;

            if (username == "Admin" && pass == "Admin@123")
            {
                MessageBox.Show("Login Success !","Login", MessageBoxButtons.OK);
                this.Hide();
                Form2 ss = new Form2();
                ss.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials,please check Username and Password and try again","Invalid Login Details", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }
    }
}
