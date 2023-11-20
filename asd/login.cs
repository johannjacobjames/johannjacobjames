using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.VisualBasic;

namespace asd
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=USER\\SQLEXPRESS;Initial Catalog=userreg;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bRegister_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM [dbo].[User] WHERE [email] = '" + textLogin.Text + "' AND [password] = '" + textPassword.Text + "'";
            cmd = new SqlCommand(login, con);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read() == true)
            {
                MessageBox.Show("Successfull Login");
                con.Close();

            }
            else
            {
                MessageBox.Show("Invalid Email or Password, Please try again");
                textLogin.Focus();
                con.Close();

            }

        }
        
private void checkbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPassword.Checked)
            {
                textPassword.PasswordChar = '\0';


            }
            else
            {
                textPassword.PasswordChar = '*';


            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
