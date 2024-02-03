using DAL;
using Entity.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Admin
{
  public class Bll_AddSpots
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public int InsertSpot(Ent_AddSpots entSpot)//method for record insertion 
    {
      try
      {
        return objdal.InsertRecord("usp_Ad_InsertSpot", entSpot.SpotName, entSpot.ShortDescription, entSpot.IconImage, entSpot.Lattitude, entSpot.Longitude, entSpot.ShowOnHomePage, entSpot.BannerImage, entSpot.FullDescription, entSpot.SerialNumber, entSpot.InsertedBy,entSpot.CategoryId);
      }
      catch (Exception)
      {

        throw;
      }
    }
    public List<Ent_AddSpots> BindSpots()//Method to bind the grid with the record of tbl_spot
    {
      List<Ent_AddSpots> listentspots = new List<Ent_AddSpots>();
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Ad_S_Spot"))
        {
          
          while (sdr.Read())
          {
            Ent_AddSpots entspots = new Ent_AddSpots();
            entspots.SpotId = Convert.ToInt32(sdr["SpotId"]);
            entspots.SpotName = sdr["SpotName"] as string;
            entspots.SerialNumber = Convert.ToInt32(sdr["SerialNumber"]);
            entspots.BannerImage = sdr["BannerImage"] as string;
            entspots.CategoryId = Convert.ToInt32(sdr["CategoryId"]);
            entspots.IconImage = sdr["IconImage"] as string;
            listentspots.Add(entspots);
          }
          return listentspots;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public Ent_AddSpots SelectionForUpdate(int SpotId)//method to return the list of selected spots 
    {
      
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Ad_SU_Spots", SpotId))
        {
          Ent_AddSpots entSpot = new Ent_AddSpots();
          while (sdr.Read())
          {
            entSpot.SerialNumber = Convert.ToInt32(sdr["SerialNumber"]);
            entSpot.CategoryId = Convert.ToInt32(sdr["CategoryId"]);
            entSpot.SpotName = sdr["SpotName"] as string;
            entSpot.IconImage = sdr["IconImage"] as string;
            entSpot.Longitude = sdr["Longitude"] as string;
            entSpot.Lattitude = sdr["Lattitude"] as string;
            entSpot.ShortDescription = sdr["ShortDescription"] as string;
            entSpot.FullDescription = sdr["FullDescription"] as string;
            entSpot.ShowOnHomePage = Convert.ToBoolean(sdr["ShowOnHomePage"]);
            entSpot.BannerImage = sdr["BannerImage"] as string;
          }
          return entSpot;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }


    public int UpdateSpot(Ent_AddSpots entspot)
    {
      return objdal.UpdateRecord("usp_Ad_U_Spots", entspot.SpotId,entspot.SpotName, entspot.ShortDescription,entspot.IconImage ,entspot.Lattitude, entspot.Longitude, entspot.ShowOnHomePage, entspot.BannerImage, entspot.FullDescription, entspot.SerialNumber,entspot.UpdatedBy, entspot.CategoryId );
    }


    //public List<Ent_AddSpots> SelectionForUpdate(int SpotId)//method to return the list of selected spots 
    //{
    //  List<Ent_AddSpots> listspot = new List<Ent_AddSpots>();
    //  try
    //  {
    //    using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Ad_SU_Spots", SpotId))
    //    {
    //      Ent_AddSpots entSpot = new Ent_AddSpots();
    //      while (sdr.Read())
    //      {

    //        entSpot.CategoryId = Convert.ToInt32(sdr["CategoryId"] );
    //        entSpot.SerialNumber = Convert.ToInt32(sdr["SerialNumber"]);
    //        entSpot.SpotName = sdr["SpotName"] as string;
    //        entSpot.IconImage = sdr["IconImage"] as string;
    //        entSpot.Longitude = sdr["Longitude"] as string;
    //        entSpot.Lattitude = sdr["Lattitude"] as string;
    //        entSpot.ShortDescription = sdr["ShortDescription"] as string;
    //        entSpot.FullDescription = sdr["FullDescription"] as string;
    //        entSpot.ShowOnHomePage = Convert.ToBoolean(sdr["ShowOnHomePage"]);
    //        entSpot.BannerImage = sdr["BannerImage"] as string;
    //        listspot.Add(entSpot);

    //      }
    //      return listspot;
    //    }
    //  }
    //  catch (Exception)
    //  {

    //    throw;
    //  }
    //}

   public int DeleteRecord(Ent_AddSpots entSpot)
    {
      return objdal.DeleteRecord("usp_Ad_D_Spot", entSpot.SpotId,entSpot.DeletedBy);
    }

  }
}
