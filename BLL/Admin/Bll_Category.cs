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
using System.Diagnostics;
using System.Xml.Linq;

namespace BLL.Admin
{
 public class Bll_Category
  {
    DataAccessMethod objdal = new DataAccessMethod();
    public List<Ent_Category> BindCategoryDropdown()
    {
			List<Ent_Category> listCategory = new List<Ent_Category>();
			try
			{
				using (SqlDataReader sdr = objdal.SelectRecordBydataReader("usp_Ad_S_SpotCategoryForDropdown"))
				{
					
					while (sdr.Read())
					{
            Ent_Category objent = new Ent_Category();
            objent.CategoryId = Convert.ToInt32(sdr["CategoryId"]);
						objent.CategoryName = sdr["CategoryName"] as string;
					  listCategory.Add(objent);

          }
          return listCategory;
        }
        

      }
      catch (Exception)
			{

				throw;
			}
    }
  }
}
