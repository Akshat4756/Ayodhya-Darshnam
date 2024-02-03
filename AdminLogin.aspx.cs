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
                objentAdminLogin.UserId = txtUserId.Text.ToString();
                objentAdminLogin.Password = txtPassword.Text.ToString();
                objentAdminLogin = bllLogin.GetAdminLoginDetail(objentAdminLogin);
                if (objentAdminLogin.LoginId>0)
                {
                    Session["LoginId"] = objentAdminLogin.LoginId;
                    Session["Name"] = objentAdminLogin.Name;
                    Response.Redirect("Admin/Dashboard.aspx", false);
                    Labelmsg.Text = "Login Successfull";
                }
                else
                {
                    Labelmsg.Text = "Either your username or your password is incorrect";
                    Labelmsg.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}