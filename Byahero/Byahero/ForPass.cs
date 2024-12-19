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
    public partial class ForPass : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        public Random random = new Random();
        public string GeneratedValue { get; private set; }
        
        public ForPass()
        {
            InitializeComponent();
            GeneratedValue = random.Next(100000, 999999).ToString();
            
        }

        private void ForPass_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Establish the connection string to connect to the Access database
            using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb"))
            {
                // SQL query to check if the username and email match
                string query = "SELECT COUNT(*) FROM useracc WHERE Username = @username AND emailAddress = @email";

                // Create and configure the command
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    // Use parameterized query to prevent SQL injection
                    cmd.Parameters.AddWithValue("@username", tbU.Text); // Username
                    cmd.Parameters.AddWithValue("@email", tbE.Text); // Email

                    try
                    {
                        // Open the connection
                        conn.Open();

                        // Execute the query and check if any record exists
                        int result = (int)cmd.ExecuteScalar();

                        // If result is greater than 0, data exists
                        if (result > 0)
                        {
                            // Generate a random OTP
                            Random randomGenerator = new Random();
                            string randomOTP = randomGenerator.Next(100000, 999999).ToString();

                            // Email setup
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
                            var toAddress = new MailAddress(tbE.Text); // Ensure this is correct

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
                                MessageBox.Show("E-Mail sent successfully!");
                            }
                            ForgotOTP forgotOTP = new ForgotOTP(this, tbU.Text);
                            forgotOTP.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("User does not exist.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }


        }
    }
}
