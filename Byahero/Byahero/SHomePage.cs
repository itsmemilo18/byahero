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
    public partial class SHomePage : Form
    {
        int counter = 0;
        private FirstPage _SHomePage;
        private Profile _Profile;
        private string username;
        public SHomePage(FirstPage shomepage, string username)
        {
            InitializeComponent();
            _SHomePage = shomepage;
            this.username = username; // Store the username for future update
        }
        public SHomePage(Profile profile, string username)
        {
            InitializeComponent();
            this.username = username;
            _Profile = profile;

        }
        public SHomePage()
        {
            InitializeComponent();

        }
        private void SHomePage_Load(object sender, EventArgs e)
        {
            Username.Text = username;
        }

        private void pbTrips_Click(object sender, EventArgs e)
        {
            UserTrips userTrips = new UserTrips();
            userTrips.Show();
            this.Close();
        }

        private void pbTime_Click(object sender, EventArgs e)
        {
            Time time = new Time();
            time.Show();
            this.Close();
        }

        private void pbFare_Click(object sender, EventArgs e)
        {
            UserFare userFare = new UserFare();
            userFare.Show();
            this.Close();
        }

        private void pbBooking_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking(this, username);
            booking.Show();
            this.Close();
        }

        private void pbProfile_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(this, username, counter);
            profile.Show();
            this.Close();
        }
    }
}
