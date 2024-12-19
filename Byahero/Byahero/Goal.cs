using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Goal : Form
    {
        private string date;
        private string time;
        private string username;
        private int price;
        private string destination;
        public Random random = new Random();
        public string GeneratedValue { get; private set; }
        OleDbConnection conn;// OleDbConnection: Manages database connection.
        OleDbCommand cmd; // OleDbCommand: Executes SQL commands (e.g., INSERT, UPDATE).
        OleDbDataAdapter adapter;// OleDbDataAdapter: Connects database and DataTable, retrieves and updates data.

        public Goal(Payment forReserve, string date, string time, string username, int Price, string destination)
        {
            InitializeComponent();
            this.date = date;
            this.time = time;
            GeneratedValue = random.Next(000000, 999999).ToString();
            this.username = username;
            this.price = Price;
            this.destination = destination;
            conn = new OleDbConnection("Provider= Microsoft.ACE.OleDb.12.0;Data Source=D:\\Works of the lord\\useracc.accdb");
        }

        public Goal()
        {
            InitializeComponent();
        }

        private void Goal_Load(object sender, EventArgs e)
        {
            labelDate.Text = date;
            labelTime.Text = time;
            labelRefN.Text = GeneratedValue;
            string query = "INSERT INTO TransacHistory (TransacName, TransacDate, TransacTime, TransacPrice, TransacRoute) VALUES (@tn, @td, @tt, @tp, @tr)";
            cmd = new OleDbCommand(query, conn);

            // Add parameters
            cmd.Parameters.AddWithValue("@tn", username);
            cmd.Parameters.AddWithValue("@td", date);
            cmd.Parameters.AddWithValue("@tt", time);  // Keep as string, since it's short text
            cmd.Parameters.AddWithValue("@tp", price);
            cmd.Parameters.AddWithValue("@tr", destination);

            conn.Open();
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
