using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Net;
using System.Reflection;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-QE45J00\\SQLEXPRESS;Initial Catalog=EsoftDB;Integrated Security=True");
        SqlCommand cmd;
        string sql;
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string RegNo = txtRegNo.Text;
                string firstName = txtfName.Text;
                string lastName = txtlName.Text;
                DateTime date = dateTimePicker.Value;

                string gender = string.Empty;
                if (rbMale.Checked)
                    gender = "Male";
                else if (rbFemale.Checked)
                    gender = "Femail";

                string address = txtAd.Text;
                string email = txtEm.Text;
                string mobilePhone = txtmobNo.Text;
                string homePhone = txthomNo.Text;
                string parentName = txtparName.Text;
                string nic = txtnic.Text;
                string contactNo = txtconNo.Text;

                sql = "INSERT INTO register_tbl1 (RegNo, firstName, lastName, date, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) VALUES (@regNo, @firstName, @lastName, @date, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";

                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@RegNo", RegNo);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mobilePhone", mobilePhone);
                cmd.Parameters.AddWithValue("@homePhone", homePhone);
                cmd.Parameters.AddWithValue("@parentName", parentName);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@contactNo", contactNo);
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Record added Successfully", "Register Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            con.Close();            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Suer, Do you really want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string idNo = txtRegNo.Text;
                int RegNo = int.Parse(idNo);

                string firstName = txtfName.Text;
                string lastName = txtlName.Text;
                DateTime date = dateTimePicker.Value;

                string gender = string.Empty;
                if (rbMale.Checked)
                    gender = "Male";
                else if (rbFemale.Checked)
                    gender = "Femail";

                string address = txtAd.Text;
                string email = txtEm.Text;
                string mobilePhone = txtmobNo.Text;
                string homePhone = txthomNo.Text;
                string parentName = txtparName.Text;
                string nic = txtnic.Text;
                string contactNo = txtconNo.Text;

                sql = "UPDATE register_tbl1 SET RegNo=@RegNo, firstName=@firstName, lastName=@lastName, date=@date, gender=@gender, address=@address, email=@email, mobilePhone=@mobilePhone, homePhone=@homePhone, parentName=@parentName, nic=@nic, contactNo=@contactNo WHERE RegNo = @RegNo";

                con.Open();
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@RegNo", RegNo);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@mobilePhone", mobilePhone);
                cmd.Parameters.AddWithValue("@homePhone", homePhone);
                cmd.Parameters.AddWithValue("@parentName", parentName);
                cmd.Parameters.AddWithValue("@nic", nic);
                cmd.Parameters.AddWithValue("@contactNo", contactNo);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While Adding" + ex.Message);
            }
            con.Close();
        }
            
        

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure, do you really want to delete this record...?", "Delete ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    string idNum = txtRegNo.Text;
                    int id = int.Parse(idNum);

                    sql = "DELETE FROM register_tbl1 WHERE regNo = @id";
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Deleted Successfully", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error While Adding" + ex.Message);
                }
                con.Close();
            }
            else { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtRegNo.Clear();
            txtfName.Clear();
            txtlName.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            txtAd.Clear();
            txtEm.Clear();
            txtmobNo.Clear();
            txthomNo.Clear();
            txtparName.Clear();
            txtnic.Clear();
            txtconNo.Clear();

        }
    }
}
            
        
    

    