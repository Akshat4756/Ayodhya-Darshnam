using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Ayodhya_Darshan
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_2_MorePlaces_Click(object sender, EventArgs e)
        {
            Response.Redirect("Places_To_Visit.aspx");
        }

       

        protected void btn2MoreTemple_Click(object sender, EventArgs e)
        {
            Response.Redirect("TemplesToVisit.aspx");
        }
    }
}