using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entity.Admin;
using DAL;

namespace BLL.Admin
{
  public class Bll_AddSpotImages
  {
   DataAccessMethod obdal = new DataAccessMethod(); 
   public int InsertData(Ent_AddSpotImages entSpotImages)
    {
      return obdal.InsertRecord("usp_Ad_I_SpotImages", entSpotImages.SpotId, entSpotImages.ImageTitle, entSpotImages.ImageLink, entSpotImages.InsertedBy, entSpotImages.SerialNumber);
    }
    public List<Ent_AddSpotImages> BindSpotImages()
    {
      List<Ent_AddSpotImages> listent = new List<Ent_AddSpotImages>();
      try
      {
        using (SqlDataReader sdr = obdal.SelectRecordBydataReader("usp_Ad_S_SpotImages"))
        {
          while (sdr.Read())
          {
            Ent_AddSpotImages entSpotImages = new Ent_AddSpotImages();
            entSpotImages.SpotImageId = Convert.ToInt32(sdr["SpotImageId"]);
            entSpotImages.SpotId = Convert.ToInt32(sdr["SpotId"]);
            entSpotImages.ImageLink = sdr["ImageLink"] as string;
            entSpotImages.ImageTitle = sdr["ImageTitle"] as string;
            listent.Add(entSpotImages);
          }
          return listent;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public Ent_AddSpotImages SelectionForUpdateRecord(int SpotImageId)
    {
      using (SqlDataReader sdr = obdal.SelectRecordBydataReader("usp_Ad_SU_SpotImages", SpotImageId))
      {
        Ent_AddSpotImages entSImages = new Ent_AddSpotImages();
        while (sdr.Read())
        {
          entSImages.SerialNumber = Convert.ToInt32(sdr["SerialNumber"]);
          entSImages.ImageTitle = sdr["ImageTitle"] as string;
          entSImages.ImageLink = sdr["ImageLink"] as string;
        }
        return entSImages;
      }
    }
    public int UpdateData(Ent_AddSpotImages entSpotImages)
    {
      return obdal.UpdateRecord("usp_Ad_U_SpotImages",entSpotImages.SpotImageId, entSpotImages.ImageTitle, entSpotImages.ImageLink, entSpotImages.UpdatedBy, entSpotImages.SerialNumber);
    }
    public int DeleteData(Ent_AddSpotImages entSpotImages)
    {
      return obdal.DeleteRecord("usp_Ad_D_SpotImages", entSpotImages.DeletedBy, entSpotImages.SpotImageId);
    }
  }
}
