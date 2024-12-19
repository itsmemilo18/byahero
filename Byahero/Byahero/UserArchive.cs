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
    public partial class UserArchive : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.
        private bool allowPopulate = false;
        void GetUsers()
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM Archive", conn);
            // Open the connection
            conn.Open();
            // Fill the DataTable with the result of the query
            adapter.Fill(dt);
            // Bind the DataTable to the DataGridView to display user information
            dgvUserDatabase.DataSource = dt;
            dgvUserDatabase.AutoGenerateColumns = true;
            // Close the database connection
            conn.Close();

        }
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Works of the lord\\useracc.accdb";
        public UserArchive()
        {
            InitializeComponent();
            GetUsers();
            dgvUserDatabase.ClearSelection(); // Deselect any cell
            dgvUserDatabase.CurrentCell = null; // Deselect current cell
            allowPopulate = true; // Allow population after load
        }
        
        private void TransferRecord(string Archive, string useracc, int ID)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Open connection
                    connection.Open();

                    // SQL query to insert data from one table to another
                    string query = $@"
                    INSERT INTO {useracc} (ID, Firstname, Lastname, ContactNumber, emailAddress, ContactPerson, EmergencyContact, [Password], Username, [Type])
                    SELECT ID, Firstname, Lastname, ContactNumber, emailAddress, ContactPerson, EmergencyContact, [Password], Username, [Type]
                    FROM {Archive}
                    WHERE ID = @RecordId"; // Specify the record to transfer

                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Add the parameter value for record ID
                        command.Parameters.AddWithValue("@RecordId", ID);
                        // Execute the query
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private void UserArchive_Load(object sender, EventArgs e)
        {
            GetUsers();
            dgvUserDatabase.ClearSelection(); // Deselect any cell
            dgvUserDatabase.CurrentCell = null; // Deselect current cell
        }

        private void btnRestore_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(tbID.Text, out int recordId))
            {
                TransferRecord("Archive", "useracc", recordId);
            }
            // SQL query to delete a user based on their ID
            string query = "DELETE FROM Archive WHERE ID = @i";

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

        private void dgvUserDatabase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header clicks

            // Check if the clicked cell is valid
            if (dgvUserDatabase.CurrentRow != null)
            {
                // Populate textboxes with data from the selected row
                tbID.Text = dgvUserDatabase.CurrentRow.Cells[0].Value.ToString(); // User ID
                tbFN.Text = dgvUserDatabase.CurrentRow.Cells[1].Value.ToString(); // First Name
                tbFN.ForeColor = Color.Black;
                tbLN.Text = dgvUserDatabase.CurrentRow.Cells[2].Value.ToString(); // Last Name
                tbLN.ForeColor = Color.Black;
                tbContact.Text = dgvUserDatabase.CurrentRow.Cells[3].Value.ToString(); // Contact Number
                tbContact.ForeColor = Color.Black;
                tbEmail.Text = dgvUserDatabase.CurrentRow.Cells[4].Value.ToString(); // E-mail Address
                tbEmail.ForeColor = Color.Black;
                tbCP.Text = dgvUserDatabase.CurrentRow.Cells[5].Value.ToString(); // Contact Person
                tbCP.ForeColor = Color.Black;
                tbECP.Text = dgvUserDatabase.CurrentRow.Cells[6].Value.ToString(); // Emergency Contact Number
                tbECP.ForeColor = Color.Black;
                tbP.Text = dgvUserDatabase.CurrentRow.Cells[7].Value.ToString(); // Password
                tbP.ForeColor = Color.Black;
                tbU.Text = dgvUserDatabase.CurrentRow.Cells[8].Value.ToString(); // Username
                tbU.ForeColor = Color.Black;

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UserDatabase userDatabase = new UserDatabase();
            userDatabase.Show();
            this.Hide();
        }
    }
}
