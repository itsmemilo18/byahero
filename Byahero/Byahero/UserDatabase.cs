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
    public partial class UserDatabase : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.
        private bool isImageUploaded = false;
        private bool allowPopulate = false;
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data 	Source=D:\\Works of the lord\\useracc.accdb";
        void GetUsers()
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data 	Source=D:\\Works of the lord\\useracc.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM useracc", conn);
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
        public UserDatabase()
        {
            InitializeComponent();
        }

        private void UserDatabase_Load(object sender, EventArgs e)
        {
            ClearTextBoxes(); // Clear textboxes at the start
            GetUsers(); // Populate the DataGridView
            dgvUserDatabase.ClearSelection(); // Deselect any cell
            dgvUserDatabase.CurrentCell = null; // Deselect current cell
            allowPopulate = true; // Allow population after load
        }
        private void ClearTextBoxes()
        {
            tbID.Text = "USER ID";
            tbFN.Text = "First Name";
            tbFN.ForeColor = Color.Gray;
            tbLN.Text = "Last Name";
            tbLN.ForeColor = Color.Gray;
            tbContact.Text = "Contact Number";
            tbContact.ForeColor = Color.Gray;
            tbEmail.Text = "E-mail Address";
            tbEmail.ForeColor = Color.Gray;
            tbCP.Text = "Contact Person";
            tbCP.ForeColor = Color.Gray;
            tbECP.Text = "Emergency Contact Number";
            tbECP.ForeColor = Color.Gray;
            tbP.Text = "Password";
            tbP.ForeColor = Color.Gray;
            tbU.Text = "Username";
            tbU.ForeColor = Color.Gray;
            //pbImage.Image = null; // Clear the image as well
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // SQL query to search for users by ID or Driver name using a partial match
            string searchQuery = "SELECT * FROM useracc WHERE ID LIKE @i OR Firstname LIKE @fn OR Username LIKE @u OR Lastname LIKE @ln";

            // Create a new OleDbDataAdapter with the search query and the database connection
            adapter = new OleDbDataAdapter(searchQuery, conn);

            // Add the search parameter for ID
            adapter.SelectCommand.Parameters.AddWithValue("@i", tbSearch.Text + "%"); // For ID search

            // Add the search parameter for First name
            adapter.SelectCommand.Parameters.AddWithValue("@fn", tbSearch.Text + "%"); // For First name search

            // Add the search parameter for Username
            adapter.SelectCommand.Parameters.AddWithValue("@u", tbSearch.Text + "%"); // For Username search
            
            // Add the search parameter for Username
            adapter.SelectCommand.Parameters.AddWithValue("@ln", tbSearch.Text + "%"); // For Last name search

            dt = new DataTable(); // Create a new DataTable to hold the search results

            // Open the connection, fill the DataTable with search results, and close the connection
            conn.Open(); // Open the connection to the database
            adapter.Fill(dt); // Fill the DataTable with search results
            conn.Close(); // Close the connection to the database

            // Bind the DataTable to the DataGridView
            dgvUserDatabase.DataSource = dt;
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

        private void dgvUserDatabase_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void TransferRecord(string useracc, string Archive, int ID)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Open connection
                    connection.Open();

                    // SQL query to insert data from one table to another
                    string query = $@"
                        INSERT INTO Archive (ID, Firstname, Lastname, ContactNumber, emailAddress, ContactPerson, EmergencyContact, [Password], Username, [Type])
                        SELECT ID, Firstname, Lastname, ContactNumber, emailAddress, ContactPerson, EmergencyContact, [Password], Username, [Type]
                        FROM useracc
                        WHERE ID = @RecordId";

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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbID.Text, out int recordId))
            {
                TransferRecord("useracc", "Archive", recordId);
            }
            // SQL query to delete a user based on their ID
            string query = "DELETE FROM useracc WHERE ID = @i";

            // Create a new OleDbCommand with the query and the database connection
            cmd = new OleDbCommand(query, conn);

            // Add the user ID parameter to the command
            cmd.Parameters.AddWithValue("@i", Convert.ToInt32(tbID.Text)); // Convert the ID from the textbox to an integer

            // Open the connection, execute the command, and close the connection
            conn.Open(); // Open the connection to the database
            cmd.ExecuteNonQuery(); // Execute the delete query
            MessageBox.Show("Customer Deleted"); // Show a success message
            conn.Close(); // Close the connection to the database

            // Refresh the DataGridView to reflect changes
            GetUsers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            HomePage form2 = new HomePage();
            form2.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string query = "UPDATE useracc SET emailAddress = ? WHERE Username = ?";

            // Create and configure the command
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", tbEmail.Text);
                cmd.Parameters.AddWithValue("?", tbU.Text);

                // Execute the update command
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(rowsAffected > 0 ? "User Updated Successfully" : "No user found with the provided ID.");
            }

            GetUsers();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            UserArchive userArchive = new UserArchive();    
            userArchive.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransacHistory transacHistory = new TransacHistory();
            transacHistory.Show();
            this.Close();
        }
    }
}
