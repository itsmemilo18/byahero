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

namespace Byahero
{
    public partial class JeepArchive : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Works of the lord\\useracc.accdb";
        public JeepArchive()
        {
            InitializeComponent();
            GetUsers();
        }
        void GetUsers()
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM JeepneyArchive", conn);
            // Open the connection
            conn.Open();
            // Fill the DataTable with the result of the query
            adapter.Fill(dt);
            // Bind the DataTable to the DataGridView to display user information
            dgvJeep.DataSource = dt;
            dgvJeep.AutoGenerateColumns = true;
            // Close the database connection
            conn.Close();

        }
        private void TransferRecord(string JeepneyArchive, string jeepney, int ID)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Open connection
                    connection.Open();

                    // SQL query to insert data from one table to another
                    string query = $@"
                    INSERT INTO {jeepney} (Drivername, Platenumber, Passengercount, Contactnumber, Route, Destination, Photo)
                    SELECT Drivername, Platenumber, Passengercount, Contactnumber, Route, Destination, Photo 
                    FROM {JeepneyArchive}
                    WHERE ID = @RecordId"; // Specify the record to transfer

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add the parameter value for record ID
                        command.Parameters.AddWithValue("@RecordId", ID);
                        // Execute the query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Restored successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbID.Text, out int recordId))
            {
                TransferRecord("JeepneyArchive", "jeepney", recordId);
            }
            // SQL query to delete a user based on their ID
            string query = "DELETE FROM JeepneyArchive WHERE ID = @i";

            // Create a new OleDbCommand with the query and the database connection
            cmd = new OleDbCommand(query, conn);

            // Add the user ID parameter to the command
            cmd.Parameters.AddWithValue("@i", Convert.ToInt32(tbID.Text)); // Convert the ID from the textbox to an integer

            // Open the connection, execute the command, and close the connection
            conn.Open(); // Open the connection to the database
            cmd.ExecuteNonQuery(); // Execute the delete query
            MessageBox.Show("Customer Restored"); // Show a success message
            conn.Close(); // Close the connection to the database

            //Refresh the DataGridView to reflect changes 
            GetUsers();
        }

        private void dgvJeep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate textboxes with data from the selected row
            tbID.Text = dgvJeep.CurrentRow.Cells[0].Value.ToString(); // User ID
            tbDriver.Text = dgvJeep.CurrentRow.Cells[1].Value.ToString(); // Driver Name
            tbDriver.ForeColor = Color.Black;
            tbPlate.Text = dgvJeep.CurrentRow.Cells[2].Value.ToString(); // Plate Number
            tbPlate.ForeColor = Color.Black;
            tbPass.Text = dgvJeep.CurrentRow.Cells[3].Value.ToString(); // Passenger Count
            tbPass.ForeColor = Color.Black;
            tbContact.Text = dgvJeep.CurrentRow.Cells[4].Value.ToString(); // Contact Number
            tbContact.ForeColor = Color.Black;
            tbRoute.Text = dgvJeep.CurrentRow.Cells[6].Value.ToString(); // Route
            tbRoute.ForeColor = Color.Black;
            tbDestination.Text = dgvJeep.CurrentRow.Cells[7].Value.ToString(); // Destination
            tbDestination.ForeColor = Color.Black;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            JeepDatabase jeepDatabase = new JeepDatabase();
            jeepDatabase.Show();
            this.Hide();
        }
    }
}
