using SmarQWebForms.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SmarQWebForms
{
    public partial class ServiceMasterForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
            if(!IsPostBack)
            {

                grdService.DataSource = smartQDBEntities.Services.ToList();
                grdService.DataBind();
            }
        }

        protected void grdService_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
               
                LinkButton lnkTest = e.Row.FindControl("editLinkButton") as LinkButton;
                lnkTest.CommandArgument = e.Row.RowIndex.ToString(); // Set the command argument
                //lnkTest.Text = entity.Name; // Set the link button text
                

            }
        }

        protected void grdService_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            SmartQDBEntities smartQDBEntities = new SmartQDBEntities();
            var serviceList = smartQDBEntities.Services.ToList();
            Response.Redirect("EditService.aspx?id=" + serviceList[Convert.ToInt32(e.CommandArgument)].Id);
        }
    }
}