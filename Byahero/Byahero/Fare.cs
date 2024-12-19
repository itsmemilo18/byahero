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
    public partial class Fare : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.
        private bool allowPopulate = false;
        void GetFare()
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
            dgvFare.DataSource = dt;
            dgvFare.AutoGenerateColumns = true;
            // Close the database connection
            conn.Close();

        }
        public Fare()
        {
            InitializeComponent();
            GetFare(); // Populate the DataGridView
            dgvFare.ClearSelection(); // Deselect any cell
            dgvFare.CurrentCell = null; // Deselect current cell
            allowPopulate = true; // Allow population after load
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string query = "UPDATE Fare SET Fare = ?, DiscountedFare = ? WHERE Destination = ?";

            // Create and configure the command
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", tbPrice.Text);
                cmd.Parameters.AddWithValue("?", tbDiscount.Text);
                cmd.Parameters.AddWithValue("?", tbDestination.Text);

                // Execute the update command
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(rowsAffected > 0 ? "Trip Updated Successfully" : "No Trip found");
            }

            GetFare();
        }

        private void dgvFare_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbRoute.Text = dgvFare.CurrentRow.Cells[0].Value.ToString(); // Route
            tbRoute.ForeColor = Color.Black;
            tbDestination.Text = dgvFare.CurrentRow.Cells[1].Value.ToString(); // Destination
            tbDestination.ForeColor = Color.Black;
            tbPrice.Text = dgvFare.CurrentRow.Cells[2].Value.ToString(); // Passenger Count
            tbPrice.ForeColor = Color.Black;
            tbDiscount.Text = dgvFare.CurrentRow.Cells[3].Value.ToString(); // Passenger Count
            tbDiscount.ForeColor = Color.Black;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
    }
}
