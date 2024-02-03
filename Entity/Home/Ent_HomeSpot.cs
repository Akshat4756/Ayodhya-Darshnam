using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Home
{
  public class Ent_HomeSpot
  {
    public int SpotId { get; set; }
    public string SpotName { get; set; }
    public int CategoryId { get; set; }
    public string ShortDescription { get; set; }
    public string IconImage { get; set; }
    public string FullDescription { get; set; }
    public string BannerImage { get; set; }
    public string Longitude { get; set; }
    public string Lattitude { get; set; }
  }
}
