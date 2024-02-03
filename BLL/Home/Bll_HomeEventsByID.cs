using DAL;
using Entity.Admin;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Home
{
  public class Bll_HomeEventsByID
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public Ent_AddEvents getEventDetails(int EventID)
    {
      using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_User_S_EventsById", EventID))
      {
        Ent_AddEvents entEvent = new Ent_AddEvents();
        while (sdr.Read())
        {
          entEvent.EventName = sdr["EventName"] as string;
          entEvent.EventId = Convert.ToInt32(sdr["EventId"]);
          entEvent.IconImage = sdr["IconImage"] as string;
          entEvent.ShortDescription = sdr["ShortDescription"] as string;
          entEvent.BannerImage = sdr["BannerImage"] as string;
          entEvent.FullDescription = sdr["FullDescription"] as string;

        }
        return entEvent;
      }
    }
  }
}
