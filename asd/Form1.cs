using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace asd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            if (textLogin.Text == "" && textPassword.Text == "" && textConfPass.Text == "")
            {
                MessageBox.Show("Fields are empty", "Registartion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textPassword.TextLength < 8)
            {
                MessageBox.Show("Password is too short\r\n", "Must be at least 8 charachters", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textPassword.Text != textConfPass.Text)
            {
                MessageBox.Show("Passwords does not match", "Please Re-enter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textPassword.Text = "";
                textConfPass.Text = "";
                textPassword.Focus();
            }
            else if (textPassword.Text == textConfPass.Text)
            {
                con.Open();
                string register = "INSERT INTO [dbo].[User]\r\n  ([email]\r\n  ,[password])\r\n  VALUES\r\n  ('" + textLogin.Text + "'\r\n  ,'" + textPassword.Text + "')";
                cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your account has been created", "Registartion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textConfPass.Text = "";
                textLogin.Text = "";
                textPassword.Text = "";
            }





        }

        private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPassword.Checked)
            {
                textPassword.PasswordChar = '\0';
                textConfPass.PasswordChar = '\0';

            }
            else
            {
                textPassword.PasswordChar = '*';
                textConfPass.PasswordChar = '*';

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
    }
}