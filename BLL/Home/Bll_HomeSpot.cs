using DAL;
using Entity.Home;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Home
{
  public class Bll_HomeSpot
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public List<Ent_HomeSpot> SelectSpotForHomepage()
    {
      List<Ent_HomeSpot> listent = new List<Ent_HomeSpot>();
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_User_S_Spot"))
        {
          while (sdr.Read())
          {
            Ent_HomeSpot entHomeSpot = new Ent_HomeSpot();
            entHomeSpot.SpotId = Convert.ToInt32(sdr["SpotId"]);
            entHomeSpot.SpotName = sdr["SpotName"] as string;
            entHomeSpot.CategoryId = Convert.ToInt32(sdr["CategoryId"]);
            entHomeSpot.ShortDescription = sdr["ShortDescription"] as string;
            entHomeSpot.IconImage = sdr["IconImage"] as string;
            listent.Add(entHomeSpot);
          }
          return listent;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }  
  }
}
