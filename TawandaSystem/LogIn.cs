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

namespace TawandaSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                //connection string
                string constring = @"Data Source=SOLS\SQLEXPRESS;Initial Catalog=TAWANDA;Integrated Security=True;";
                using (SqlConnection conn = new SqlConnection(constring))
                {
                    string query = "SELECT COUNT(1) FROM Login WHERE username=Linda AND passwords=@LoveCats003";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Username", txtUser.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);
                    conn.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 1)
                    {
                        MessageBox.Show("Login Successful!");
                        // Proceed to the next form or main application
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect.");
                    }
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
