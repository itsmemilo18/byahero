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
    public partial class Payment : Form
    {
        // Variable to store the price
        int Price = 0;
        int count = 0;
        private Booking _ForBooking;
        private string destination;
        private string date;
        private string time;
        private string username;
        public Payment()
        {
            InitializeComponent();
        }
        public Payment(Reserve forReserve, string date, string time, string destination, string username)
        {
            InitializeComponent();
            this.date = date;
            this.time = time;
            this.destination = destination;
            this.username = username;
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve();
            reserve.Show();
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Your connection string to the Access database
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Works of the lord\\useracc.accdb";

                // Query to get the price
                string query = "SELECT DiscountedFare FROM Fare WHERE Destination = ?";

                // Using the connection and command to retrieve data
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            // Add the parameter for the query
                            command.Parameters.AddWithValue("?", destination);

                            // Execute the query and use the reader to get the data
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Store the retrieved price in the variable
                                    Price = Convert.ToInt32(reader["DiscountedFare"]);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int Amount = Convert.ToInt32(tbPay.Text);
            if (Amount >= Price)
            {
                Goal goal = new Goal(this, date, time, username, Price, destination);
                goal.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Insufficient Amount.");
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {
        
            if(!checkBox1.Checked)
            {

                // Your connection string to the Access database
                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Works of the lord\\useracc.accdb";

                // Query to get the first name of the employee
                string query = "SELECT Fare FROM Fare WHERE Destination = ?";

                // Using the connection and command to retrieve data
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        using (OleDbCommand command = new OleDbCommand(query, connection))
                        {
                            // Add the parameter for the query
                            command.Parameters.AddWithValue("?", destination);

                            // Execute the query and use the reader to get the data
                            using (OleDbDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Store the retrieved first name in the variable
                                    Price = Convert.ToInt32(reader["Fare"]);
                                }
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
