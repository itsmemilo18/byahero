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
using System.Net.Mail;
using System.Net;
using static System.Net.WebRequestMethods;

namespace Byahero
{
    
    public partial class NewPass : Form
    {
        private string username;
        public NewPass(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        public NewPass()
        {
            InitializeComponent();
        }
        private void UpdateUserPassword()
        {
            string connectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb";

            // Correct query for OleDb, using '?' placeholders
            string query = "UPDATE useracc SET [Password] = ? WHERE Username = ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // Add parameters in the correct order as per the query
                        cmd.Parameters.AddWithValue("?", textBoxNewPassword.Text); // New password entered by the user
                        cmd.Parameters.AddWithValue("?", username); // Username to identify the user

                        // Open the connection
                        conn.Open();

                        // Execute the query and get the number of affected rows
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any row was affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No matching user found, password not updated.");
                        }
                    }
                }
                catch (OleDbException ex)
                {
                    // Catch any OleDbException and display the detailed error message
                    MessageBox.Show("OleDbException: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // General exception handling
                    MessageBox.Show("General exception: " + ex.Message);
                }
            }
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(textBoxNewPassword.Text == tbRNewP.Text)
            {
                UpdateUserPassword();
                FirstPage firstPage = new FirstPage();
                firstPage.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Passwords don't match"); 
            }    

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FirstPage form1 = new FirstPage();
            form1.Show();
            this.Hide();
        }
    }
}
