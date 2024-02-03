using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entity.Home;
using DAL;

namespace BLL.Home
{
  public class Bll_HomeCarouselBanner
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public List<Ent_HomeCarouselBanner> BindCarousel()
    {
      List<Ent_HomeCarouselBanner> listbanner = new List<Ent_HomeCarouselBanner>();
      try
      {
        using(SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_User_S_BannerImage"))
        {
          while (sdr.Read())
          {
            Ent_HomeCarouselBanner entBanner = new Ent_HomeCarouselBanner();
            entBanner.BannerImageUrl = sdr["BannerImageUrl"] as string;
            entBanner.BannerImageId = Convert.ToInt32(sdr["BannerImageId"]);
            entBanner.BannerImageName = sdr["BannerImageName"] as string;
            entBanner.SerialNumber = Convert.ToInt32(sdr["SerialNumber"]);
            listbanner.Add(entBanner);
          }
          return listbanner;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
