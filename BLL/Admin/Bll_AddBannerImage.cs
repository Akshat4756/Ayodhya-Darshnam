using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DAL;
using Entity.Admin;

namespace BLL.Admin
{
  public class Bll_AddBannerImage
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public int InsertBanner(Ent_AddBannerImage entBanner)
    {
      try
      {
        return objdal.InsertRecord("usp_Ad_I_Banner", entBanner.BannerImageUrl, entBanner.SerialNumber, entBanner.InsertedBy,entBanner.BannerImageName);
      }
      catch (Exception ex)
      {

        throw;
      }
    }
    public List<Ent_AddBannerImage> BindBanner()
    {
      List<Ent_AddBannerImage> listentBanner = new List<Ent_AddBannerImage>();
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Ad_S_Banner"))
        {
          while (sdr.Read())
          {
            Ent_AddBannerImage entBanner = new Ent_AddBannerImage();
            entBanner.SerialNumber = Convert.ToInt32(sdr["SerialNumber"]);
            entBanner.BannerImageId = Convert.ToInt32(sdr["BannerImageId"]);
            entBanner.BannerImageUrl = sdr["BannerImageUrl"] as string;
            entBanner.BannerImageName = sdr["BannerImageName"] as string;
            listentBanner.Add(entBanner);
          }
          return listentBanner;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public Ent_AddBannerImage SelectionForUpdate(int BannerImageId)
    {
      Ent_AddBannerImage entBanner = new Ent_AddBannerImage();
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Ad_SU_Banner", BannerImageId))
        {
          while (sdr.Read())
          {
            entBanner.SerialNumber = Convert.ToInt32(sdr["SerialNumber"]);
            entBanner.BannerImageName = sdr["BannerImageName"] as string;
            entBanner.BannerImageUrl = sdr["BannerImageUrl"] as string;
          }
          return entBanner;
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }
    public int UpdateBanner (Ent_AddBannerImage entBanner )
    {
      try
      {
        return objdal.UpdateRecord("usp_Ad_U_Banner", entBanner.BannerImageId, entBanner.BannerImageUrl, entBanner.SerialNumber, entBanner.UpdatedBy, entBanner.BannerImageName);
      }
      catch (Exception ex)
      {

        throw;
      }
    }
    public int DeleteBanner(Ent_AddBannerImage entBanner)
    {
      try
      {
        return objdal.DeleteRecord("usp_Ad_D_Banner", entBanner.BannerImageId, entBanner.DeletedBy);
      }
      catch (Exception ex)
      {

        throw;
      }
    }
  }
}
