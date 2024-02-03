using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Home;
using Entity.Home;

namespace Project_Ayodhya_Darshan
{
  public partial class Spots : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        
        BindSpot();
      }
    }
    private void BindSpot()
    {
      List<Ent_HomeSpotByCategoryID> listspots = new List<Ent_HomeSpotByCategoryID>();
      Bll_HomeSpotByCategoryID bllspot = new Bll_HomeSpotByCategoryID();
      try
      {
        int CategoryId = Convert.ToInt32(Request.QueryString["CategoryId"]);
        listspots = bllspot.BindSpotByCategoryId(CategoryId);
        if (listspots.Count > 0)
        {
          rptTemples.DataSource = listspots;
          rptTemples.DataBind();
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }
  }
}