using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity.Home;

namespace BLL.Home
{
  public class Bll_HomeSpotByCategoryID
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public List<Ent_HomeSpotByCategoryID> BindSpotByCategoryId(int CategoryId)
    {
      List<Ent_HomeSpotByCategoryID> listspot = new List<Ent_HomeSpotByCategoryID>();
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_User_S_SpotbasedOnCategoryID", CategoryId))
        {
          while (sdr.Read())
          {
            Ent_HomeSpotByCategoryID entspot = new Ent_HomeSpotByCategoryID();
            entspot.SpotId = Convert.ToInt32(sdr["SpotId"]);
            entspot.SpotName = sdr["SpotName"] as string;
            entspot.CategoryId = Convert.ToInt32(sdr["CategoryId"]);
            entspot.ShortDescription = sdr["ShortDescription"] as string;
            entspot.IconImage = sdr["IconImage"] as string;
            listspot.Add(entspot);
          }
          return listspot;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}
