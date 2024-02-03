using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Entity.Admin;
using BLL.Admin;
using DAL;

namespace BLL.Admin
{
  public class Bll_AddEvents
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public int InsertEvents(Ent_AddEvents entEvent)
    {
      return objdal.InsertRecord("usp_Ad_I_MainEvents", entEvent.SerialNumber, entEvent.EventName, entEvent.BannerImage, entEvent.IconImage, entEvent.ShortDescription, entEvent.FullDescription, entEvent.ShowOnHomePage, entEvent.InsertedBy);
    }
    public int UpdateEvent(Ent_AddEvents entEvent)
    {
      return objdal.UpdateRecord("usp_Ad_U_MainEvents", entEvent.EventId, entEvent.SerialNumber, entEvent.EventName, entEvent.BannerImage, entEvent.IconImage, entEvent.ShortDescription, entEvent.FullDescription, entEvent.ShowOnHomePage, entEvent.UpdatedBy);
    }
    public int DeleteEvent(Ent_AddEvents entEvent)
    {
      return objdal.DeleteRecord("usp_Ad_D_MainEvents", entEvent.EventId, entEvent.DeletedBy);
    }
    public Ent_AddEvents SelectionForUpdate(int EventId)
    {
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Ad_SU_MainEvents", EventId))
        {
          Ent_AddEvents entEvent = new Ent_AddEvents();
          while (sdr.Read())
          {
            entEvent.SerialNumber = Convert.ToInt32(sdr["SerialNumber"]);
            entEvent.EventName = sdr["EventName"] as string;
            entEvent.IconImage = sdr["EventName"] as string;
            entEvent.BannerImage = sdr["BannerImage"] as string;
            entEvent.ShortDescription = sdr["ShortDescription"] as string;
            entEvent.FullDescription = sdr["FullDescription"] as string;
            entEvent.ShowOnHomePage = Convert.ToBoolean(sdr["ShowOnHomePage"]);
          }
          return entEvent;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    public List<Ent_AddEvents> BindGrid()
    {
      List<Ent_AddEvents> listent = new List<Ent_AddEvents>();
      try
      {
        using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Ad_S_MainEvents"))
        {
         
          while (sdr.Read())
          {
            Ent_AddEvents entEvent = new Ent_AddEvents();
            entEvent.SerialNumber = Convert.ToInt32(sdr["SerialNumber"]);
            entEvent.EventName = sdr["EventName"] as string;
            entEvent.IconImage = sdr["IconImage"] as string;
            entEvent.BannerImage = sdr["BannerImage"] as string;
            entEvent.EventId = Convert.ToInt32(sdr["EventId"]);
            listent.Add(entEvent);
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
