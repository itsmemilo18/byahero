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
using System.Net.Mail;
using System.Net;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Byahero
{
    public partial class ForgotOTP : Form
    {
        private ForPass _ForPass;
        int count = 0;
        private string username;      // To store the user's identifier
        public ForgotOTP(ForPass forPass, string username)
        {
            InitializeComponent();
            _ForPass = forPass;
            this.username = username; // Store the username for future update
        }
        public ForgotOTP()
        {
            InitializeComponent();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string randomFromForPass = _ForPass.GeneratedValue;
            do
            {
                if (tbOTP.Text != randomFromForPass)
                {
                    MessageBox.Show("OTP successful!");
                    NewPass NewPass = new NewPass(username);
                    NewPass.Show();
                    this.Close();
                    break;
                }
                else
                {
                    MessageBox.Show("OTP incorrect. Please double check the OTP in your e-mail!");
                    count++;
                }
                MessageBox.Show("Maximum attempt for OTP has been reached. System will now close. Please try again in 3 minutes.");
                System.Windows.Forms.Application.Exit();
            } while (count != 3);
        }
    }
}
