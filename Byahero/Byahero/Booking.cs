using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Byahero
{
    
    public partial class Booking : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.
        private bool allowPopulate = false;
        public string username { get; set; }
        public string emailAddress { get; private set; }
        void GetTrips()
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM Fare", conn);
            // Open the connection
            conn.Open();
            // Fill the DataTable with the result of the query
            adapter.Fill(dt);
            // Bind the DataTable to the DataGridView to display user information
            dgvTrips.DataSource = dt;
            dgvTrips.AutoGenerateColumns = true;
            // Close the database connection
            conn.Close();
        }
        public Booking(SHomePage forSHomePage, string username)
        {
            InitializeComponent();
            this.username = username;
            GetTrips(); // Populate the DataGridView
            dgvTrips.ClearSelection(); // Deselect any cell
            dgvTrips.CurrentCell = null; // Deselect current cell
            allowPopulate = true; // Allow population after load
        }
        public Booking()
        {
            InitializeComponent();
            string connectionString = "Provider=Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb";
            OleDbConnection conn = new OleDbConnection(connectionString);

            // Create the query with a WHERE clause to find the specific record by username
            string query = "SELECT emailAddress FROM Users WHERE Username = @Username";  // SQL query to fetch email by username

            // Create an OleDbCommand to execute the query
            OleDbCommand cmd = new OleDbCommand(query, conn);

            // Add the parameter to avoid SQL injection
            cmd.Parameters.AddWithValue("@Username", username);


            // Open the connection
            conn.Open();

            // Execute the query and retrieve the data
            OleDbDataReader reader = cmd.ExecuteReader();

            // Check if the data exists
            if (reader.Read()) // If there's a matching record
            {
                // Retrieve the emailAddress from the reader
                string emailAddress = reader["emailAddress"].ToString();
            }
            else
            {
                MessageBox.Show("No record found for this Username.");
            }
        }

        private void dgvTrips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header clicks

            // Check if the clicked cell is valid
            if (dgvTrips.CurrentRow != null)
            {
                // Populate textboxes with data from the selected row
                tbRoute.Text = dgvTrips.CurrentRow.Cells[0].Value.ToString(); // Driver Name
                tbRoute.ForeColor = Color.Black;
                tbDestination.Text = dgvTrips.CurrentRow.Cells[1].Value.ToString(); // Plate Number
                tbDestination.ForeColor = Color.Black;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SHomePage sHomePage = new SHomePage();
            sHomePage.Show();
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Reserve reserve = new Reserve(this, tbDestination.Text, emailAddress, username);
            reserve.Show();
            this.Close();
        }
    }
}
