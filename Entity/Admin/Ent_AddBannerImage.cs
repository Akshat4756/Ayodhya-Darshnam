using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Admin
{
  public class Ent_AddBannerImage
  {
    public int SerialNumber { get; set; }
    public string BannerImageUrl { get; set; }
    public int BannerImageId { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
    public int InsertedBy { get; set; }
    public int UpdatedBy { get; set; }
    public int DeletedBy { get; set; }
    public string BannerImageName { get; set; }
  }
}
