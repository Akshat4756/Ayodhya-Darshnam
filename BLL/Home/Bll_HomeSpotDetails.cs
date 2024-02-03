using DAL;
using Entity.Home;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Home
{
  public class Bll_HomeSpotDetails
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public Ent_HomeSpot BindSpotDetails(int SpotID)
    {
      Ent_HomeSpot entspot = new Ent_HomeSpot();
      using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_User_S_SpotDetails", SpotID))
      {
        while (sdr.Read())
        {
          entspot.SpotId = Convert.ToInt32(sdr["SpotId"]);
          entspot.SpotName = sdr["SpotName"].ToString();
          entspot.IconImage = sdr["IconImage"].ToString() ;
          entspot.ShortDescription = sdr["ShortDescription"].ToString();
          entspot.FullDescription = sdr["FullDescription"].ToString();
          entspot.BannerImage = sdr["BannerImage"].ToString();
          entspot.Longitude = sdr["Longitude"].ToString();
          entspot.Lattitude = sdr["Lattitude"].ToString();
          entspot.CategoryId = Convert.ToInt32(sdr["CategoryId"]);
        }
        return entspot;
      }
    } 
  }
}
