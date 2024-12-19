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
    public partial class HomePage : Form
    {
        int counter = 1;
        private FirstPage _HomePage;
        private string username;
        public HomePage(FirstPage homepage, string username)
        {
            InitializeComponent();
            _HomePage = homepage;
            this.username = username; // Store the username for future update
        }
        public HomePage()
        {
            InitializeComponent();
        }

        private void pbTrips_MouseClick(object sender, MouseEventArgs e)
        {
            Trips trips = new Trips();
            trips.Show();
            this.Hide();
        }

        private void pbJeeps_MouseClick(object sender, MouseEventArgs e)
        {
            JeepDatabase form2 = new JeepDatabase();
            form2.Show();
            this.Hide();
        }

        private void pbFare_MouseClick(object sender, MouseEventArgs e)
        {
            Fare fare = new Fare();
            fare.Show();
            this.Hide();
        }

        private void pbUsers_MouseClick(object sender, MouseEventArgs e)
        {
            UserDatabase form2 = new UserDatabase();
            form2.Show();
            this.Hide();
        }

        private void pbProfile_MouseClick(object sender, MouseEventArgs e)
        {
            Profile profile = new Profile(this, username, counter);
            profile.Show();
            this.Hide();
        }
    }
}
