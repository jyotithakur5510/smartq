using SmarQWebForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmarQWebForms
{
    public partial class TicketForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
                var serviceList = smartQDBEntities.Services.ToList();
                string mobileNumber = "8169879959";
             
                var user = smartQDBEntities.Users.Where(m => m.MobileNumber == mobileNumber).FirstOrDefault();
                var ticket=smartQDBEntities.Tickets.Where(m =>m.UserId == user.Id).FirstOrDefault();
                lblTicketNumber.InnerText=ticket.TicketNumber.ToString();

                var service = smartQDBEntities.Services.Where(m => m.Id == ticket.ServiceId).FirstOrDefault();

                lblClientName.InnerText=user.Name.ToString();

                lblServiceName.InnerText = service.ServiceName.ToString();

            }

        }
    }
}