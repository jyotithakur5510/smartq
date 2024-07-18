using SmarQWebForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmarQWebForms
{
    public partial class DeleteService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Guid serviceid = new Guid(Request.QueryString["id"].ToString());
                SmartQDBEntities smartQDBEntities = new SmartQDBEntities();

                var service = smartQDBEntities.Services.Where(m => m.Id == serviceid).FirstOrDefault();
                //txtServiceName.Value = service.ServiceName;
            }
        }
    }
}