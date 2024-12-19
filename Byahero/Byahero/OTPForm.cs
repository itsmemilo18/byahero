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
    public partial class OTPForm : Form
    {
        private Register _registerForm;
        public OTPForm(Register registerForm)
        {
            InitializeComponent();
            _registerForm = registerForm;
        }
        public OTPForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int count = 0;
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string randomFromRegister = _registerForm.GeneratedValue;

            do
            {
                if (tbOTP.Text != randomFromRegister)
                {
                    MessageBox.Show("OTP successful!");
                    FirstPage Firstpage = new FirstPage();
                    Firstpage.Show();
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
