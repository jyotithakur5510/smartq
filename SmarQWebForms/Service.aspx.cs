using SmarQWebForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmarQWebForms
{
    public partial class Service : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
                    SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
                    var serviceList = smartQDBEntities.Services.ToList();
                chkServiceList.DataSource = serviceList;
                chkServiceList.DataTextField = "ServiceName";
                chkServiceList.DataValueField = "Id";
                chkServiceList.DataBind();
            }
        }
    }
}