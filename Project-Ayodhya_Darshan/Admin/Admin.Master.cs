using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Ayodhya_Darshan.Admin
{
  public partial class Admin : System.Web.UI.MasterPage
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (Session["SessionId"]!=null || (int)Session["SessionId"]!=0)
      {

      }
      else
      {
        Response.Redirect("~/Default.aspx");
      }
    }

    protected void btn_LogOut_Click(object sender, EventArgs e)
    {
      Session.Abandon();
      Response.Redirect("~/Default.aspx");
    }
  }
}