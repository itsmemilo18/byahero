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
    public partial class TransacHistory : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.
        private bool allowPopulate = false;
        public TransacHistory()
        {
            InitializeComponent();
        }
        void GetTransacHistory()
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM TransacHistory", conn);
            // Open the connection
            conn.Open();
            // Fill the DataTable with the result of the query
            adapter.Fill(dt);
            // Bind the DataTable to the DataGridView to display user information
            dgvTransacHistory.DataSource = dt;
            dgvTransacHistory.AutoGenerateColumns = true;
            // Close the database connection
            conn.Close();

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            UserDatabase userDatabase = new UserDatabase();
            userDatabase.Show();
            this.Close();
        }

        private void TransacHistory_Load(object sender, EventArgs e)
        {
            GetTransacHistory();
            dgvTransacHistory.ClearSelection(); // Deselect any cell
            dgvTransacHistory.CurrentCell = null; // Deselect current cell
            allowPopulate = true; // Allow population after load
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // SQL query to search for users by ID or Driver name using a partial match
            string searchQuery = "SELECT * FROM TransacHistory WHERE TransacName LIKE @tn OR TransacDate LIKE @td OR TransacTime LIKE @tt OR TransacRoute LIKE @tr";

            // Create a new OleDbDataAdapter with the search query and the database connection
            adapter = new OleDbDataAdapter(searchQuery, conn);

            // Add the search parameter for ID
            adapter.SelectCommand.Parameters.AddWithValue("@tn", tbSearch.Text + "%"); // For Name search

            // Add the search parameter for First name
            adapter.SelectCommand.Parameters.AddWithValue("@td", tbSearch.Text + "%"); // For Date search

            // Add the search parameter for Username
            adapter.SelectCommand.Parameters.AddWithValue("@tt", tbSearch.Text + "%"); // For Time search

            // Add the search parameter for Username
            adapter.SelectCommand.Parameters.AddWithValue("@tr", tbSearch.Text + "%"); // For Route search

            dt = new DataTable(); // Create a new DataTable to hold the search results

            // Open the connection, fill the DataTable with search results, and close the connection
            conn.Open(); // Open the connection to the database
            adapter.Fill(dt); // Fill the DataTable with search results
            conn.Close(); // Close the connection to the database

            // Bind the DataTable to the DataGridView
            dgvTransacHistory.DataSource = dt;
        }
    }
}
