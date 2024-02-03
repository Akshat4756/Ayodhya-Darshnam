using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Home
{
  public class Ent_HomeSpotByCategoryID
  {
    public int SpotId { get; set; }
    public string SpotName { get; set; }
    public string ShortDescription { get; set; }
    public string IconImage { get; set; }
    public string BannerImage { get; set; }
    public int CategoryId { get; set; }
    public string Longitude { get; set; }
    public string Lattitude { get; set; }
    public bool ShowOnHomePage { get; set; }
    public string FullDescription { get; set; }
    public int SerialNumber { get; set; }
    public bool IsActive { get; set; }
    public bool IsDeleted { get; set; }
  }
}
