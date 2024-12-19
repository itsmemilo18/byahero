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
    public partial class JeepDatabase : Form
    {
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.
        DataTable dt; // DataTable: Stores data in-memory, can be bound to controls like DataGridView.
        private bool isImageUploaded = false;
        private bool allowPopulate = false;
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\Works of the lord\\useracc.accdb";

        void GetUsers()
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb");
            // Initialize the DataTable to hold user data
            dt = new DataTable();
            // Set up an adapter to run the query and fetch the user data
            adapter = new OleDbDataAdapter("SELECT * FROM jeepney", conn);
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

        public JeepDatabase()
        {
            InitializeComponent();
        }
        

        private void dgvJeep_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ClearTextBoxes(); // Clear textboxes at the start
            GetUsers(); // Populate the DataGridView
            dgvJeep.ClearSelection(); // Deselect any cell
            dgvJeep.CurrentCell = null; // Deselect current cell
            allowPopulate = true; // Allow population after load
            dgvJeep.Columns["Photo"].Visible = false;
        }
        private void ClearTextBoxes()
        {
            tbID.Text = "USER ID";
            tbDriver.Text = "Driver Name";
            tbDriver.ForeColor = Color.Gray;
            tbPlate.Text = "Plate Number";
            tbPlate.ForeColor = Color.Gray;
            tbPass.Text = "Passenger Count";
            tbPass.ForeColor = Color.Gray;
            tbContact.Text = "Contact Number";
            tbContact.ForeColor = Color.Gray;
            tbRoute.Text = "From";
            tbRoute.ForeColor = Color.Gray;
            tbDestination.Text = "To";
            tbDestination.ForeColor = Color.Gray;
            pbImage.Image = null; // Clear the image as well
            btnSave.Enabled = true;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage form2 = new HomePage();
            // Show Form2 (as a non-modal dialog)
            form2.Show();
            this.Close();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbDriver.Text == "Driver Name") // Replace with placeholder text
            {
                tbDriver.Text = "";
                tbDriver.ForeColor = Color.Black;
            }
        }

        private void tbDriver_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDriver.Text))
            {
                tbDriver.Text = "Driver Name";
                tbDriver.ForeColor = Color.Gray;
            }
        }

        private void tbPlate_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPlate.Text == "Plate Number")
            {
                tbPlate.Text = "";
                tbPlate.ForeColor = Color.Black;
            }
        }

        private void tbPlate_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPlate.Text))
            {
                tbPlate.Text = "Plate Number"; 
                tbPlate.ForeColor = Color.Gray; 
            }
        }

        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPass.Text))
            {
                tbPass.Text = "Passenger Count"; 
                tbPass.ForeColor = Color.Gray; 
            }
        }

        private void tbPass_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbPass.Text == "Passenger Count") 
            {
                tbPass.Text = "";
                tbPass.ForeColor = Color.Black; 
            }
        }

        private void tbContact_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbContact.Text == "Contact Number")
            {
                tbContact.Text = "";
                tbContact.ForeColor = Color.Black;
            }
        }

        private void tbContact_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbContact.Text))
            {
                tbContact.Text = "Contact Number";
                tbContact.ForeColor = Color.Gray;
            }
        }
        private void tbRoute_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbRoute.Text == "From")
            {
                tbRoute.Text = "";
                tbRoute.ForeColor = Color.Black;
            }
        }
        private void tbRoute_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbRoute.Text))
            {
                tbRoute.Text = "From";
                tbRoute.ForeColor = Color.Gray;
            }
        }

        private void tbDestination_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (tbDestination.Text == "To")
            {
                tbDestination.Text = "";
                tbDestination.ForeColor = Color.Black;
            }
        }
        private void tbDestination_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbDestination.Text))
            {
                tbDestination.Text = "To";
                tbDestination.ForeColor = Color.Gray;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbDriver.Text) ||
                string.IsNullOrWhiteSpace(tbPlate.Text) ||
                string.IsNullOrWhiteSpace(tbPass.Text) ||
                string.IsNullOrWhiteSpace(tbContact.Text) ||
                string.IsNullOrWhiteSpace(tbRoute.Text) ||
                string.IsNullOrWhiteSpace(tbDestination.Text) ||
                pbImage.Image == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Prepare SQL insert command
            string query = "INSERT INTO jeepney (Drivername, Platenumber, Passengercount, Contactnumber, Route, Destination, Photo ) VALUES (@dn, @pn, @pc, @cn, @r, @d, @i)";
            cmd = new OleDbCommand(query, conn);

            // Add parameters
            cmd.Parameters.AddWithValue("@dn", tbDriver.Text);
            cmd.Parameters.AddWithValue("@pn", tbPlate.Text);
            cmd.Parameters.AddWithValue("@pc", tbPass.Text);  // Keep as string, since it's short text
            cmd.Parameters.AddWithValue("@cn", tbContact.Text);
            cmd.Parameters.AddWithValue("@r", tbRoute.Text);
            cmd.Parameters.AddWithValue("@d", tbDestination.Text);

            // Handle image
            using (MemoryStream ms = new MemoryStream())
            {
                pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                cmd.Parameters.AddWithValue("@i", ms.ToArray());
            }

            // Execute command with error handling
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Inserted Successfully");
            }
            catch (OleDbException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }

            // Refresh DataGridView
            GetUsers();

        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to allow users to select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the file filter to only show image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jfif;*.jpeg;*.png;*.bmp";

            // Show the dialog and check if the user selected a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the selected image into the PictureBox (pbImage)
                pbImage.Image = new Bitmap(openFileDialog.FileName);

                isImageUploaded = true; // Set the flag to true when an image is uploaded

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dgvJeep_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = false;
            if (e.RowIndex < 0) return; // Ignore header clicks

            // Check if the clicked cell is valid
            if (dgvJeep.CurrentRow != null)
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

                // Handle the Photo column as before
                if (dgvJeep.CurrentRow.Cells["Photo"].Value != DBNull.Value)
                {
                    byte[] imgData = (byte[])dgvJeep.CurrentRow.Cells["Photo"].Value;
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        pbImage.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else
                {
                    pbImage.Image = null; // Clear the PictureBox
                }
            }
        }

        private void dgvJeep_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            btnSave.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbDriver.Text) ||    // Driver Name
                string.IsNullOrWhiteSpace(tbPlate.Text) ||    // Plate Number
                string.IsNullOrWhiteSpace(tbPass.Text) ||     // Passenger Count
                string.IsNullOrWhiteSpace(tbContact.Text) ||    // Contact Number
                string.IsNullOrWhiteSpace(tbRoute.Text) ||      // Route
                string.IsNullOrWhiteSpace(tbDestination.Text))       // Destination
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Determine SQL query based on whether an image is uploaded
            string query = isImageUploaded
                ? "UPDATE jeepney SET Drivername=@dn, Platenumber=@pn, Passengercount=@pc, Contactnumber=@cn, Photo=@i, Route=@r, Destination=@d WHERE ID=@id"
                : "UPDATE jeepney SET Drivername=@dn, Platenumber=@pn, Passengercount=@pc, Contactnumber=@cn, Route=@r, Destination=@d WHERE ID=@id";

            // Create and configure the command
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@dn", tbDriver.Text); // First Name
                cmd.Parameters.AddWithValue("@pn", tbPlate.Text); // Last Name
                cmd.Parameters.AddWithValue("@pc", tbPass.Text);   // Username
                cmd.Parameters.AddWithValue("@cn", tbContact.Text);   // Password
                cmd.Parameters.AddWithValue("@r", tbRoute.Text);      // Route 
                cmd.Parameters.AddWithValue("@d", tbDestination.Text);      // Destination

                // Add image parameter if uploaded
                if (isImageUploaded && pbImage.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbImage.Image.Save(ms, pbImage.Image.RawFormat);
                        cmd.Parameters.AddWithValue("@i", ms.ToArray());
                    }
                }
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbID.Text));
                // Execute the update command
                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show(rowsAffected > 0 ? "User Updated Successfully" : "No user found with the provided ID.");
            }

            // Reset flag and refresh DataGridView
            isImageUploaded = false;
            GetUsers();

        }
        
        private void TransferRecord(string jeepney, string JeepneyArchive, int ID)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    // Open connection
                    connection.Open();

                    // SQL query to insert data from one table to another
                    string query = $@"
                    INSERT INTO {JeepneyArchive} (ID, Drivername, Platenumber, Passengercount, Contactnumber, Route, Destination, Photo)
                    SELECT ID, Drivername, Platenumber, Passengercount, Contactnumber, Route, Destination, Photo 
                    FROM {jeepney}
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbID.Text, out int recordId))
            {
                TransferRecord("jeepney", "JeepneyArchive", recordId);
            }
            // SQL query to delete a user based on their ID
            string query = "DELETE FROM jeepney WHERE ID = @i";

            // Create a new OleDbCommand with the query and the database connection
            cmd = new OleDbCommand(query, conn);

            // Add the user ID parameter to the command
            cmd.Parameters.AddWithValue("@i", Convert.ToInt32(tbID.Text)); // Convert the ID from the textbox to an integer

            // Open the connection, execute the command, and close the connection
            conn.Open(); // Open the connection to the database
            cmd.ExecuteNonQuery(); // Execute the delete query
            MessageBox.Show("Customer Deleted"); // Show a success message
            conn.Close(); // Close the connection to the database

            //Refresh the DataGridView to reflect changes 
            GetUsers();
        }

        private void tbS_TextChanged(object sender, EventArgs e)
        {
            // SQL query to search for users by ID or Driver name using a partial match
            string searchQuery = "SELECT * FROM jeepney WHERE ID LIKE @i OR Drivername LIKE @dn OR Route LIKE @r OR Destination LIKE @t";

            // Create a new OleDbDataAdapter with the search query and the database connection
            adapter = new OleDbDataAdapter(searchQuery, conn);

            // Add the search parameter for ID
            adapter.SelectCommand.Parameters.AddWithValue("@i", tbS.Text + "%"); // For ID search

            // Add the search parameter for Driver name
            adapter.SelectCommand.Parameters.AddWithValue("@dn", tbS.Text + "%"); // For Driver name search

            // Add the search parameter for Driver name
            adapter.SelectCommand.Parameters.AddWithValue("@r", tbS.Text + "%"); // For Driver name search

            // Add the search parameter for Driver name
            adapter.SelectCommand.Parameters.AddWithValue("@t", tbS.Text + "%"); // For Driver name search

            dt = new DataTable(); // Create a new DataTable to hold the search results

            // Open the connection, fill the DataTable with search results, and close the connection
            conn.Open(); // Open the connection to the database
            adapter.Fill(dt); // Fill the DataTable with search results
            conn.Close(); // Close the connection to the database

            // Bind the DataTable to the DataGridView
            dgvJeep.DataSource = dt;

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            JeepArchive jeepArchive = new JeepArchive();
            jeepArchive.Show();
            this.Hide();
        }
    }
}
