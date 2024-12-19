using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;


namespace Byahero
{
    public partial class FirstPage : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        private int loginAttempts = 0; // Counter for login attempts

        public FirstPage()
        {
            InitializeComponent();
        }

        private void tbU_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbU.Text == "Username") // Replace with your placeholder text
            {
                tbU.Text = "";
                tbU.ForeColor = Color.Black; // Optional: change text color
            }

        }
        private void tbU_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbU.Text))
            {
                tbU.Text = "Username"; // Replace with your placeholder text
                tbU.ForeColor = Color.Gray; // Optional: change text color to indicate placeholder
            }
        }

        private void tbP_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbP.Text == "Password") // Replace with your placeholder text
            {
                tbP.Text = "";
                tbP.ForeColor = Color.Black; // Optional: change text color
            }
        }

        private void tbP_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbP.Text))
            {
                tbP.Text = "Password"; // Replace with your placeholder text
                tbP.ForeColor = Color.Gray; // Optional: change text color to indicate placeholder
            }
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb");

            // SQL query to check if the username and password match
            string query = "SELECT [Type] FROM useracc WHERE Username = @username AND [Password] = @password";

            // Create and configure the command
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", tbU.Text);
            cmd.Parameters.AddWithValue("@password", tbP.Text);

            // Open the connection
            conn.Open();
            // Execute the query and get the result
            object result = cmd.ExecuteScalar();

            if (result != null)
            {
                // The user exists, and we have retrieved the Type
                string userType = result.ToString();

                // Check the user type and open the corresponding form
                this.Hide();

                if (userType == "Admin")
                {
                    HomePage form2 = new HomePage(this, tbU.Text);  // Admin Form
                    form2.Show();
                }
                else if (userType == "Student")
                {
                    SHomePage form3 = new SHomePage(this, tbU.Text);  // Student Form
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("Unrecognized user type.");
                    this.Show(); // Show the login form again if type is unrecognized
                }
            }

            else
            {
                // Increment the login attempts and show an error message
                loginAttempts++;
                MessageBox.Show("Invalid username or password.");

                if (loginAttempts >= 3)
                {
                    // Close the application if 3 failed login attempts
                    System.Windows.Forms.Application.Exit();
                }
            }

            // Close the connection
            conn.Close();
        }

        private void tbU_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbU_Click(object sender, EventArgs e)
        {
            if (tbU.Text == "Username")
            {
                tbU.Text = "";
                tbU.ForeColor = Color.Black;
            }
        }

        private void tbU_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbU.Text))
            {
                tbU.Text = "Username";
                tbU.ForeColor = Color.Gray;
            }
        }

        private void tbP_Click(object sender, EventArgs e)
        {
            if (tbP.Text == "Password")
            {
                tbP.Text = "";
                tbP.ForeColor = Color.Black;
            }
        }

        private void tbP_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbP.Text))
            {
                tbP.Text = "Password";
                tbP.ForeColor = Color.Gray;
            }
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void linkFP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForPass forPass = new ForPass();
            forPass.Show();
            this.Hide();
        }
    }




}
