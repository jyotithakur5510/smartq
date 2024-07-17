using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.data;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string currentMobileNumber = txtMobileNumber.Text;

            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();

            User existingUser = smartQDBEntities.Users.ToList()
               .Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();

            existingUser.Name = txtName.Text;

            smartQDBEntities.SaveChanges();


        }

     
       

        private void btnVerifyNumber_Click(object sender, EventArgs e)
        {
            if (txtMobileNumber.Text.Length != 10)
            {
                MessageBox.Show("Invalid MobileNumber");
                
            }
            else
            {
                string currentMobileNumber = txtMobileNumber.Text;

                SmartQDBEntities smartQDBEntities = new SmartQDBEntities();

                User existingUser = smartQDBEntities.Users.ToList()
                   .Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();

                if (existingUser == null)
                {
                    WindowsFormsApp3.data.User newUser = new WindowsFormsApp3.data.User();
                    newUser.Id = Guid.NewGuid();
                    newUser.MobileNumber = currentMobileNumber;
                    newUser.Name = "NA";


                    smartQDBEntities.Users.Add(newUser);
                    smartQDBEntities.SaveChanges();
                }
              
                User myuser  = smartQDBEntities.Users.ToList()
                    .Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();

                

                if (myuser.MobileNumber == txtMobileNumber.Text)
                {
                   
                    Random r = new Random();
                    int value = r.Next(9999);

                    myuser.OTP = value.ToString();
                    smartQDBEntities.SaveChanges();

                    MessageBox.Show("OTP Sent to your mobile number. Please check.");
                }

                
            }
            
            
        }

      

        private void btnSubmitOTP_Click(object sender, EventArgs e)
        {
            string currentMobileNumber = txtMobileNumber.Text;
            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
            User myuser = smartQDBEntities.Users.ToList()
                .Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();
            string currentOTP= txtOTP.Text;
            if(myuser.OTP == currentOTP)
            {
                MessageBox.Show("Valid OTP");
            }
            else
            {
                MessageBox.Show("Invalid OTP");
            }
        }
    }
}
