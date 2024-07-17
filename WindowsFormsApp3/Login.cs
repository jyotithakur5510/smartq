using System
    ;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.data;
using WindowsFormsApp3.jyoti;

namespace WindowsFormsApp3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOTP_Click(object sender, EventArgs e)
        {   
            string currentMobileNumber = txtMobileNumber.Text;

            if (currentMobileNumber.Length != 10)
            {
                MessageBox.Show("this is not a valid mobile number");
            }

            SmartQDBEntities smartQDBEntities= new SmartQDBEntities();
            var currentUser = smartQDBEntities.Users.ToList().Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();
            
            Random rand = new Random();
            int value = rand.Next(10000);

            currentUser.OTP = value.ToString();
            smartQDBEntities.SaveChanges();
        }

        private void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            string currentMobileNumber = txtMobileNumber.Text;


            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
            User currentUser = smartQDBEntities.Users.ToList().Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();

            string currentOTP = txtOTP.Text;

            if (currentUser.OTP == txtOTP.Text)
            {
                MessageBox.Show("Login Successful");
            }
            else
            {
                MessageBox.Show("Invalid Login");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnRegisterNow_Click(object sender, EventArgs e)
        {
            Form3 ticketForm = new Form3();
            ticketForm.ShowDialog();
        }

      
    }
}
