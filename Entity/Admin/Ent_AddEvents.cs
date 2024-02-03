using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Admin
{
  public class Ent_AddEvents
  {
    public int EventId { get; set; }
    public string EventName { get; set; }
    public string BannerImage { get; set; }
    public string IconImage { get; set; }
    public string ShortDescription { get; set; }
    public string FullDescription { get; set; }
    public int SerialNumber { get; set; }
    public bool  ShowOnHomePage{get;set;}
    public int InsertedBy { get; set; }
    public int UpdatedBy { get; set; }
    public int DeletedBy { get; set; }
  }
}
