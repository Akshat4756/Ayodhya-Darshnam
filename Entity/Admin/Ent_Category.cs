using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Admin
{
  public class Ent_Category
  {
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string CategoryIcon { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime DeletedDate { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public int DeletedBy { get; set; }
    public bool ShowOnHomePage { get; set; }
    public int SerialNumber { get; set; }

  }
}
