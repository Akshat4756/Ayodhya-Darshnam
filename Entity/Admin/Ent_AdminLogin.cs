﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Admin
{
  public class Ent_AdminLogin
  {
    public int AdminId { get; set; }
    public string AdminName { get; set; }
    public string Password { get; set; }
    public int SessionId { get;set; }
  }
}
