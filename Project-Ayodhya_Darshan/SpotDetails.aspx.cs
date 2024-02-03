using BLL.Home;
using Entity.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Ayodhya_Darshan
{
  public partial class SpotDetails : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindSpotDetails();
      }
    }
    public void BindSpotDetails()
    {
      Bll_HomeSpotDetails blldetails = new Bll_HomeSpotDetails();
      Ent_HomeSpot entspot = new Ent_HomeSpot();
      try
      {
        int SpotID = Convert.ToInt32(Request.QueryString["SpotId"]);
        entspot= blldetails.BindSpotDetails(SpotID);
        if (entspot.SpotId!=0||!(entspot.SpotId.Equals(null)))
        {
          BannerImage.ImageUrl = entspot.BannerImage;
          IconImage.ImageUrl = entspot.IconImage;
          lblFullDescription.Text = entspot.FullDescription;
          lblShortDescription.Text = entspot.ShortDescription;
          lblSpotName.Text = entspot.SpotName;
        }

      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}