using Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Ayodhya_Darshan
{
  public partial class MainEvents : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindEvents();
      }
    }
    public void BindEvents()
    {
      List<Ent_AddEvents> listevents = new List<Ent_AddEvents>();
      Bll_HomeEvents bllevents = new Bll_HomeEvents();
      try
      {
        listevents = bllevents.GetAllEvents();
        if (listevents != null)
        {
          rptEvents.DataSource = listevents;
          rptEvents.DataBind(); 
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btnViewTemple_Click(object sender, EventArgs e)
    {
      LinkButton btnViewTemple = sender as LinkButton;
      int EventID = Convert.ToInt32(btnViewTemple.CommandArgument);
      Response.Redirect("EventDetails.aspx?EventID=" + EventID);
    }
  }
}