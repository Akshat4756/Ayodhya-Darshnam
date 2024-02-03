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
  public partial class Default : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindSpot();
        BindCarousel();
      }
    }
    private void BindSpot()
    {
      List<Ent_HomeSpot> listSpot = new List<Ent_HomeSpot>();
      Bll_HomeSpot bllSpot = new Bll_HomeSpot();
      try
      {
        listSpot = bllSpot.SelectSpotForHomepage();
        if (listSpot.Where(Spot => Spot.CategoryId == 1).ToList().Count > 0)
        {
          rptTemple.DataSource = listSpot.Where(Spot => Spot.CategoryId == 1).ToList();
          rptTemple.DataBind();
        }
        if (listSpot.Where(Spot => Spot.CategoryId == 2).ToList().Count > 0)
        {
          rptPlace.DataSource = listSpot.Where(Spot => Spot.CategoryId == 2).ToList();
          rptPlace.DataBind();
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public void BindCarousel()
    {
      List<Ent_HomeCarouselBanner> listBanner = new List<Ent_HomeCarouselBanner>();
      Bll_HomeCarouselBanner bllBanner = new Bll_HomeCarouselBanner();
      try
      {
        listBanner = bllBanner.BindCarousel();
        if (listBanner.Count > 0)
        {
          rptCarousel.DataSource = listBanner;
          rptCarousel.DataBind();
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }

    protected void btnViewPlaces_Click(object sender, EventArgs e)
    {

      int CategoryId = 2;
      Response.Redirect(string.Format("Spots.aspx?CategoryId={0}", CategoryId));
    }

    protected void btnViewTemple_Click(object sender, EventArgs e)
    {

      int CategoryId = 1;
      Response.Redirect(string.Format("Spots.aspx?CategoryId={0}", CategoryId));
    }
  }
}