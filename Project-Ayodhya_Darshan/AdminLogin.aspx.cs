using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Entity.Admin;
using BLL.Admin;

namespace Project_Ayodhya_Darshan
{
  public partial class UserLogin : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSignUp_Click1(object sender, EventArgs e)
    {
      Response.Redirect("UserSignUp.aspx");
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
       Ent_AdminLogin objentAdminLogin = new Ent_AdminLogin();
      Bll_AdminLogin bllLogin = new Bll_AdminLogin();

      try
      {
        string AdminName = txtAdminName.Text.ToString();
        string Password = txtPassword.Text.ToString();
        objentAdminLogin= bllLogin.GetAdminLoginDetail(AdminName, Password);
        if (objentAdminLogin.AdminId > 0)
        {
          Session["AdminId"] = objentAdminLogin.AdminId;
          Session["SessionId"] = objentAdminLogin.SessionId;
          Response.Redirect("/Admin/Dashboard.aspx",false);
        }
        else
        {
          Response.Write("<script>alert('Invalid Credentials')</script>");
        }

      }
      catch (Exception ex)
      {

        Response.Write("<script>alert('Invalid Credentials')</script>");
      }
    }
  }
}