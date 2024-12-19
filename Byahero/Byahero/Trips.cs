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
    public partial class Trips : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.
        private bool allowPopulate = false;
        void GetTrip()
            {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM trips", conn);
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
        public Trips()
        {
            InitializeComponent();
            GetTrip(); // Populate the DataGridView
            dgvTrips.ClearSelection(); // Deselect any cell
            dgvTrips.CurrentCell = null; // Deselect current cell
            allowPopulate = true; // Allow population after load
        }

        private void Trips_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string query = "UPDATE trips SET PassengerCount = ? WHERE Destination = ?";

            // Create and configure the command
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", tbPassCount.Text);
                cmd.Parameters.AddWithValue("?", tbDestination.Text);

                // Execute the update command
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(rowsAffected > 0 ? "Trip Updated Successfully" : "No Trip found");
            }

            GetTrip();
        }

        private void dgvTrips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbRoute.Text = dgvTrips.CurrentRow.Cells[0].Value.ToString(); // Route
            tbRoute.ForeColor = Color.Black;
            tbDestination.Text = dgvTrips.CurrentRow.Cells[1].Value.ToString(); // Destination
            tbDestination.ForeColor = Color.Black;
            tbPassCount.Text = dgvTrips.CurrentRow.Cells[2].Value.ToString(); // Passenger Count
            tbPassCount.ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
    }
}
