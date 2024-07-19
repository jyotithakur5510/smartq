using SmarQWebForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace SmarQWebForms
{
    public partial class RegistrationForm : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtOTP.Disabled = true;
                btnSubmitOTP.Disabled=true;
            }
        }

        protected void btnSubmit_ServerClick(object sender, EventArgs e)
        {
            if (txtMobileNumber.Value.Length != 10)
            {
                //MessageBox.Show("Invalid MobileNumber");

            }
            else
            {
                string currentMobileNumber = txtMobileNumber.Value;

                SmartQDBEntities smartQDBEntities = new SmartQDBEntities();

                User existingUser = smartQDBEntities.Users.ToList()
                   .Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();

                if (existingUser == null)
                {
                    User newUser = new User();
                    newUser.Id = Guid.NewGuid();
                    newUser.MobileNumber = currentMobileNumber;
                    newUser.Name = "NA";


                    smartQDBEntities.Users.Add(newUser);
                    smartQDBEntities.SaveChanges();
                }

                User myuser = smartQDBEntities.Users.ToList()
                    .Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();



                if (myuser.MobileNumber == txtMobileNumber.Value)
                {

                    Random r = new Random();
                    int value = r.Next(9999);

                    myuser.OTP = value.ToString();
                    smartQDBEntities.SaveChanges();

                    txtOTP.Disabled = false;
                    btnSubmitOTP.Disabled = false;

                    txtMobileNumber.Disabled = true;
                    btnSendOTP.Disabled = true;
                }

            }
        }

        protected void btnSubmitOTP_ServerClick(object sender, EventArgs e)
        {
            string currentMobileNumber = txtMobileNumber.Value;
            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
            User myuser = smartQDBEntities.Users.ToList()
                .Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();
            string currentOTP = txtOTP.Value;
            if (myuser.OTP == currentOTP)
            {
                Response.Write("alert('User is Valid')");
            }
            else
            {
                
                Response.Write("alert('Invalid OTP')");

            }

        }

        


       
       
        protected void btnSendOTP_ServerClick1(object sender, EventArgs e)
        {
            if (txtMobileNumber.Value.Length != 10)
            {
                //MessageBox.Show("Invalid MobileNumber");

            }
            else
            {
                string currentMobileNumber = txtMobileNumber.Value;

                SmartQDBEntities smartQDBEntities = new SmartQDBEntities();

                User existingUser = smartQDBEntities.Users.ToList()
                   .Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();

                if (existingUser == null)
                {
                    User newUser = new User();
                    newUser.Id = Guid.NewGuid();
                    newUser.MobileNumber = currentMobileNumber;
                    newUser.Name = "NA";


                    smartQDBEntities.Users.Add(newUser);
                    smartQDBEntities.SaveChanges();
                }

                User myuser = smartQDBEntities.Users.ToList()
                    .Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();



                if (myuser.MobileNumber == txtMobileNumber.Value)
                {

                    Random r = new Random();
                    int value = r.Next(9999);

                    myuser.OTP = value.ToString();
                    smartQDBEntities.SaveChanges();

                    txtOTP.Disabled = false;
                    btnSubmitOTP.Disabled = false;

                    txtMobileNumber.Disabled = true;
                    btnSendOTP.Disabled = true;

                }
            }
        }

        protected void btnregister_ServerClick(object sender, EventArgs e)
        {
            string currentMobileNumber = txtMobileNumber.Value;

            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();

            User existingUser = smartQDBEntities.Users.ToList()
               .Where(m => m.MobileNumber == currentMobileNumber).FirstOrDefault();

            existingUser.Name = txtName.Value;

            smartQDBEntities.SaveChanges();
        }
    }
}