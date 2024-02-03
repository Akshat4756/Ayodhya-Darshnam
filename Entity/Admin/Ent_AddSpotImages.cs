using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Admin
{
  public class Ent_AddSpotImages
  {
    public int SpotId { get; set; }
    public string ImageTitle { get; set; }
    public string ImageLink { get; set; }
    public int InsertedBy { get; set; }
    public int SerialNumber { get; set; }
    public int SpotImageId { get; set; }
    public int UpdatedBy { get; set; }
    public int DeletedBy { get; set; }
  }
}
