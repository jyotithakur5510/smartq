using SmarQWebForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmarQWebForms
{
    public partial class LoginForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

     

        protected void btnSendOTP_Click(object sender, EventArgs e)
        {
            string currentMobileNumber = txtMobileNumber.Value;

            if (currentMobileNumber.Length != 10)
            {
                //MessageBox.Show("this is not a valid mobile number");
                
            }

            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
            var currentUser = smartQDBEntities.Users.ToList().Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();

            Random rand = new Random();
            int value = rand.Next(10000);

            currentUser.OTP = value.ToString();
            smartQDBEntities.SaveChanges();


        }

        protected void btnVerifyOTP_Click(object sender, EventArgs e)
        {
            string currentMobileNumber = txtMobileNumber.Value;


            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
            User currentUser = smartQDBEntities.Users.ToList().Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();

            string currentOTP = txtOTP.Value;

            if (currentUser.OTP == txtOTP.Value)
            {
                //MessageBox.Show("Login Successful");
            }
            else
            {
                //MessageBox.Show("Invalid Login");
            }
        }

       

        
    }
}