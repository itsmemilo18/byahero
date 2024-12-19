using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Byahero
{
    public partial class Reserve : Form
    {
        private string date;
        private string time;
        private Booking _ForBooking;
        private string destination;
        private string username;
        
        public Reserve(Booking forBooking, string destination, string emailAddress, string username)
        {
            InitializeComponent();
            _ForBooking = forBooking;
            this.destination = destination; // Store the username for future update
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.CustomFormat = "HH:mm";  // Time only
            dtpTime.ShowUpDown = true;  // Show only up/down for time
            this.username = username;
        }
        public Reserve()
        {
            InitializeComponent();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
            this.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            //Handle synchronization (optional)
            dtpDate.ValueChanged += (senderValueChanged, eventArgse) =>
            {
                dtpTime.Value = dtpTime.Value.Date.Add(dtpDate.Value.TimeOfDay);
            };
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            string time = dtpTime.Value.ToString("HH:mm");
            Payment payment = new Payment(this, date, time, destination, username);
            payment.Show();
            this.Close();
        }
    }
}
