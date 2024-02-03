using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using DAL;
using Entity.Admin;

namespace Project_Ayodhya_Darshan
{
  public class Bll_HomeEvents
  {
		DataAccessMethod objdal = new DataAccessMethod();
    public List<Ent_AddEvents> GetAllEvents()
    {
			try
			{
				List<Ent_AddEvents> listent = new List<Ent_AddEvents>();
				using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_User_S_Events"))
				{
					while (sdr.Read())
					{
						Ent_AddEvents entEvents = new Ent_AddEvents();
						entEvents.EventName = sdr["EventName"] as string;
						entEvents.EventId = Convert.ToInt32(sdr["EventId"]);
						entEvents.IconImage = sdr["IconImage"] as string;
						entEvents.ShortDescription = sdr["ShortDescription"] as string;
						listent.Add(entEvents);
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