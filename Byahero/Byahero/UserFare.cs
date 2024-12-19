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
    public partial class UserFare : Form
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
        public UserFare()
        {
            InitializeComponent();
            GetFare(); // Populate the DataGridView
            dgvFare.ClearSelection(); // Deselect any cell
            dgvFare.CurrentCell = null; // Deselect current cell
            allowPopulate = true; // Allow population after load
        }

        private void pbBack_MouseClick(object sender, MouseEventArgs e)
        {
            SHomePage sHomePage = new SHomePage();
            sHomePage.Show();
            this.Close();
        }
    }
}
