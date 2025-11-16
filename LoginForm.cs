using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBRARY_BOOK_TRACKER
{
    public partial class LoginForm : Form
    {
        public bool LoginSuccessful { get; private set; } = false; // Tracks if login was good
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string str = "server=localhost;user=root;pwd=aadhil;database=library";

            using (MySqlConnection con = new MySqlConnection(str))
            {
                try
                {
                    con.Open();

                    string query = "SELECT COUNT(1) FROM admin_login WHERE username = @user AND password = @pass";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    // 2. Use parameters to prevent SQL Injection (VERY IMPORTANT)
                    cmd.Parameters.AddWithValue("@user", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPassword.Text);

                    // 3. Execute the query
                    //    ExecuteScalar() gets the result of the COUNT(1)
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    // 4. Check if a user was found
                    if (count == 1)
                    {
                        // User found! Set success and close.
                        this.LoginSuccessful = true;
                        this.Close();
                    }
                    else
                    {
                        // No user found with that combo
                        MessageBox.Show(
                            "Invalid username or password.",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        this.LoginSuccessful = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("A database error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.LoginSuccessful = false;
                }
            }

        }
    }
}
