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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Byahero
{
    public partial class Register : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.
        public Random random = new Random();
        public string GeneratedValue { get; private set; } // Value to be shared with OTP
        private string userName;
        private string contactNumber;
        private string emergencyContact;
        private string email;
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Works of the lord\\useracc.accdb";
        public Register()
        {
            InitializeComponent();
            GeneratedValue = random.Next(100000, 999999).ToString();
        }
        private void Register_Load(object sender, EventArgs e)
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb");
            // Open the connection
            conn.Open();
            // Close the database connection
            conn.Close();
            btnRegister.Enabled = false;
        }
        private void GetUserData()
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Works of the lord\\useracc.accdb";
            string query = "SELECT Username, emailAddress, ContactNumber, EmergencyContact FROM useracc WHERE Username = @u";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@u", "exampleUsername");

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userName = reader["Username"].ToString();
                                contactNumber = reader["ContactNumber"].ToString();
                                emergencyContact = reader["EmergencyContact"].ToString();
                                email = reader["emailAddress"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the given username.");
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
        private void btnRegister_Click(object sender, EventArgs e)
        {

            // Step 1: Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbFN.Text) ||
                string.IsNullOrWhiteSpace(tbLN.Text) ||
                string.IsNullOrWhiteSpace(tbCN.Text) ||
                string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbCP.Text) ||
                string.IsNullOrWhiteSpace(tbECN.Text) ||
                string.IsNullOrWhiteSpace(tbUser.Text) ||
                string.IsNullOrWhiteSpace(tbPass.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return; // Exit the method if fields are not filled
            }

            // Flag to prevent insertion if any duplicates are found
            bool hasDuplicate = false;

            // Step 2: Check each field (Username, Email, ContactNumber, EmergencyContact) individually
            string checkQuery = "SELECT COUNT(*) FROM useracc WHERE {0} = @value";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();

                // Check Username
                using (OleDbCommand checkCmd = new OleDbCommand(string.Format(checkQuery, "Username"), conn))
                {
                    checkCmd.Parameters.AddWithValue("@value", tbUser.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username is already taken.");
                        hasDuplicate = true;
                    }
                }

                // Check Email
                using (OleDbCommand checkCmd = new OleDbCommand(string.Format(checkQuery, "emailAddress"), conn))
                {
                    checkCmd.Parameters.AddWithValue("@value", tbEmail.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Email address is already taken.");
                        hasDuplicate = true;
                    }
                }

                // Check Contact Number
                using (OleDbCommand checkCmd = new OleDbCommand(string.Format(checkQuery, "ContactNumber"), conn))
                {
                    checkCmd.Parameters.AddWithValue("@value", tbCN.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Contact number is already taken.");
                        hasDuplicate = true;
                    }
                }

                // Check Emergency Contact
                using (OleDbCommand checkCmd = new OleDbCommand(string.Format(checkQuery, "EmergencyContact"), conn))
                {
                    checkCmd.Parameters.AddWithValue("@value", tbECN.Text);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Emergency contact number is already taken.");
                        hasDuplicate = true;
                    }
                }

                conn.Close();
            }

            // Step 3: Only proceed if no duplicates were found
            if (hasDuplicate)
            {
                return; // Exit the method if any duplicates were found
            }

            // Step 4: Proceed with inserting the data if no duplicates
            string insertQuery = "INSERT INTO useracc (Firstname, Lastname, Contactnumber, emailAddress, ContactPerson, EmergencyContact, Username, [Password], Type) VALUES (@fn, @ln, @cn, @ea, @cp, @ec, @u, @p, @t)";
            using (OleDbCommand cmd = new OleDbCommand(insertQuery, conn))
            {
                // Step 5: Add parameters for insertion
                cmd.Parameters.AddWithValue("@fn", tbFN.Text);
                cmd.Parameters.AddWithValue("@ln", tbLN.Text);
                cmd.Parameters.AddWithValue("@cn", tbCN.Text);
                cmd.Parameters.AddWithValue("@ea", tbEmail.Text);
                cmd.Parameters.AddWithValue("@cp", tbCP.Text);
                cmd.Parameters.AddWithValue("@ec", tbECN.Text);
                cmd.Parameters.AddWithValue("@u", tbUser.Text);
                cmd.Parameters.AddWithValue("@p", tbPass.Text);
                cmd.Parameters.AddWithValue("@t", "Student");

                // Step 6: Open the connection, execute the insert, and close the connection
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                // Step 5: Generate a random OTP
                Random randomGenerator = new Random();
                string randomOTP = randomGenerator.Next(100000, 999999).ToString();

                // Step 6: Email setup
                string emailAddress = "jmplibunao18@gmail.com";
                string emailPassword = "obpj fzer rmyu zrzw"; // Ensure this is set correctly

                // Check if email address and password are set
                if (string.IsNullOrWhiteSpace(emailAddress) || string.IsNullOrWhiteSpace(emailPassword))
                {
                    MessageBox.Show("Email address or password is not set.");
                    return; // Exit if email credentials are not set
                }

                // Create MailAddress objects
                var fromAddress = new MailAddress(emailAddress, "Byahero");
                var toAddress = new MailAddress(tbEmail.Text); // Ensure this is correct

                // Set the subject and body
                string subject = "Your OTP from Byahero";
                string body = $"Your One-Time-Pin (OTP) is: {randomOTP} for your Byahero application. DONT SHARE YOUR PIN WITH ANYONE.";

                // Configure the SMTP client
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(emailAddress, emailPassword)
                };

                // Send the email
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                    MessageBox.Show("User registered successfully!");
                }

                // Step 7: Show the OTPForm
                OTPForm otpForm = new OTPForm(this);
                otpForm.Show(); // Display the OTP form
                this.Hide(); // Optionally close the Register form

            }
        }
            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
                btnRegister.Enabled = checkBox1.Checked;
            }

            private void btnCancel_Click(object sender, EventArgs e)
            {
                FirstPage form1 = new FirstPage();
                form1.Show();
                this.Hide();
            }

            private void linkLabel1_Click(object sender, EventArgs e)
            {
                MessageBox.Show("YOUR RESERVATION TICKET SERVES AS AN OFFICIAL FARE TICKET FOR ALL INTENTS AND PURPOSE.\r\n\r\nCHECK IN TIME: 20 minutes before scheduled departure. Failure of passengers to present themselves for carriage within such time shall result in the cancellation of their reservation and their seats shall be given to chance passengers.\r\n\r\nVALIDITY OF THIS TICKET: On the date stated herein or on the rebooked date.\r\n");
            }
        }
    }


