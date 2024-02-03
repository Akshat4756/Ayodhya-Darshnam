using BLL.Home;
using Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Ayodhya_Darshan
{
  public partial class EventDetails : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        int EventID = Convert.ToInt32(Request.QueryString["EventID"]);
        BindEventDetails(EventID);
      }
    }
    private void BindEventDetails(int EventID)
    {
      Ent_AddEvents entEvents = new Ent_AddEvents();
      Bll_HomeEventsByID bllevent = new Bll_HomeEventsByID();
      try
      {
        entEvents = bllevent.getEventDetails(EventID);
        if (entEvents != null)
        {
          lblEventName.Text = entEvents.EventName;
          lblFullDescription.Text = entEvents.FullDescription;  
          lblShortDescription.Text = entEvents.ShortDescription;
          IconImage.ImageUrl= entEvents.IconImage;
          BannerImage.ImageUrl=entEvents.BannerImage;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}