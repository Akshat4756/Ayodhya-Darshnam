using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Admin;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL.Admin
{
  public class Bll_AdminLogin
  {
    DataAccessMethod objDal = new DataAccessMethod();
    public Ent_AdminLogin GetAdminLoginDetail(string AdminName, string Password)
    {
      try
      {
        Ent_AdminLogin objentLogin = new Ent_AdminLogin();
        using (SqlDataReader sdr = objDal.SelectRecordBydataReader("usp_Ad_AdminLogin", AdminName, Password))
        {
          while (sdr.Read())
          {
            objentLogin.SessionId = Convert.ToInt32(sdr["SessionId"]);
            objentLogin.AdminId = Convert.ToInt32(sdr["AdminId"]);
          }
          return objentLogin;
        }
      }
      catch (Exception)
      {
        throw;
      }
    }
  }
}
