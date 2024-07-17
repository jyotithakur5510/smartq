using SmarQWebForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmarQWebForms
{
    public partial class EditService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Guid serviceid = new Guid(Request.QueryString["id"].ToString());
                SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
                
                var service = smartQDBEntities.Services.Where(m => m.Id == serviceid).FirstOrDefault(); 
                txtServiceName.Value=service.ServiceName;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)

        {
            Guid serviceid = new Guid(Request.QueryString["id"].ToString());
            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();

            var service = smartQDBEntities.Services.Where(m => m.Id == serviceid).FirstOrDefault();
            service.ServiceName = txtServiceName.Value;
            smartQDBEntities.SaveChanges();
            Response.Redirect("ServiceMasterForm.aspx");
        }
    }
}