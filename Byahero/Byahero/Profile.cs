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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Byahero
{
    public partial class Profile : Form
    {
        private bool isImageUploaded = false;
        private bool allowPopulate = false;
        private string username;
        public int counter { get; set; }
        public Profile(SHomePage forsHomePage, string username, int counter)
        {
            InitializeComponent();
            this.username = username; // Store the username for future update
            this.counter = counter;
        }
        public Profile(HomePage forsHomePage, string username, int counter)
        {
            InitializeComponent();
            this.username = username; // Store the username for future update
            this.counter = counter;
        }
        public Profile()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                FirstPage form2 = new FirstPage();
                form2.Show();
                this.Hide();
            }
            else
            {
                // User chose not to logout, do nothing
            }
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            // Your connection string
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Works of the lord\\useracc.accdb";

            // Query to get the row data
            string query = "SELECT ID, Firstname, Lastname, ContactNumber, emailAddress, Username, [Password]  FROM useracc WHERE Username = @u";

            // Using the connection and command to retrieve data
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create the command and assign the query
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add parameter to prevent SQL injection
                        command.Parameters.AddWithValue("@u", username);

                        // Execute the query and read the data
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // If a record is found
                            {
                                tbID.Text = reader["ID"].ToString(); // Populate first textbox
                                tbFN.Text = reader["Firstname"].ToString(); // Populate second textbox
                                tbLN.Text = reader["Lastname"].ToString(); // Populate third textbox
                                tbCN.Text = reader["ContactNumber"].ToString();
                                tbEmail.Text = reader["emailAddress"].ToString();
                                tbU.Text = reader["Password"].ToString();
                                tbP.Text = reader["Username"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the given ID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbID.Text) ||    // Profile ID
                string.IsNullOrWhiteSpace(tbFN.Text) ||    // First Name
                string.IsNullOrWhiteSpace(tbLN.Text) ||     // Last Name
                string.IsNullOrWhiteSpace(tbCN.Text) ||    // Contact Number
                string.IsNullOrWhiteSpace(tbEmail.Text) ||      // E-Mail Address
                string.IsNullOrWhiteSpace(tbU.Text) ||          // Username
                string.IsNullOrWhiteSpace(tbP.Text))            // Password
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            string connectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb";

            // Correct query for OleDb, using '?' placeholders
            string query = "UPDATE useracc SET Firstname = ?, Lastname = ?, ContactNumber = ?, emailAddress = ?, [Password] = ?, Username = ? WHERE Username = ?";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // Add parameters in the correct order as per the query
                        cmd.Parameters.AddWithValue("?", tbFN.Text);
                        cmd.Parameters.AddWithValue("?", tbLN.Text);
                        cmd.Parameters.AddWithValue("?", tbCN.Text);
                        cmd.Parameters.AddWithValue("?", tbEmail.Text);
                        cmd.Parameters.AddWithValue("?", tbU.Text);
                        cmd.Parameters.AddWithValue("?", tbP.Text);
                        cmd.Parameters.AddWithValue("?", username); // Username to identify the user

                        // Open the connection
                        conn.Open();

                        // Execute the query and get the number of affected rows
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any row was affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No matching user found, password not updated.");
                        }
                        username = tbP.Text;
                    }
            }
            Profile_Load(this, EventArgs.Empty);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(counter == 1)
            {
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Close();
            }
            else
            {
                SHomePage shomePage = new SHomePage(this, username);
                shomePage.Show();
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

