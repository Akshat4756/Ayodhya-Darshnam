using BLL.Admin;
using Entity.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Project_Ayodhya_Darshan.Admin
{
  public partial class AddSpots : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindDropDownCategory();//calling the method 
        BindGridOfSpots();//calling the method
      }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)//btn click event
    {
      Bll_AddSpots bllSpots = new Bll_AddSpots();
      Ent_AddSpots entSpots = new Ent_AddSpots();
      try
      {
        if (ViewState["SpotId"] != null)
        {
          entSpots.SpotId = Convert.ToInt32((ViewState["SpotId"]));
          entSpots.SerialNumber = Convert.ToInt32(txt_SerialNumber.Text);
          entSpots.SpotName = txtSpotName.Text.ToString();
          entSpots.ShortDescription = txt_ShortDescription.Text.ToString();
          entSpots.IconImage = SaveIconImage(IconImageURL);
          entSpots.Lattitude = txt_Lattitude.Text.ToString();
          entSpots.Longitude = txt_Longitude.Text.ToString();
          entSpots.ShowOnHomePage = ShowOnHome(entSpots.ShowOnHomePage);//dunno how i pull this off but it literally worked lol
          entSpots.BannerImage = SaveBannerImage(BannerImageURL);
          entSpots.FullDescription = txt_FullDescription.Text.ToString();
          entSpots.SerialNumber = Convert.ToInt32(txt_SerialNumber.Text);
          entSpots.UpdatedBy = Convert.ToInt32(Session["SessionId"]);
          entSpots.CategoryId = Convert.ToInt32(ddlCategoryName.SelectedValue);
          int upd = bllSpots.UpdateSpot(entSpots);
          if (upd != 0)
          {
            Response.Write("<script>alert('Details updated Successfully')</script>");

            txt_SerialNumber.Text = null;
            txt_ShortDescription.Text = null;
            txt_Lattitude.Text = null;
            txt_Longitude.Text = null;
            rdHomePage.SelectedValue = "";
            txt_FullDescription.Text = null;
            txtSpotName.Text = null;
            BindGridOfSpots();
          }
        }
        else
        {
          entSpots.SpotName = txtSpotName.Text.ToString();
          entSpots.ShortDescription = txt_ShortDescription.Text.ToString();
          entSpots.IconImage = SaveIconImage(IconImageURL);
          entSpots.Lattitude = txt_Lattitude.Text.ToString();
          entSpots.Longitude = txt_Longitude.Text.ToString();
          entSpots.ShowOnHomePage = ShowOnHome(entSpots.ShowOnHomePage);//dunno how i pull this off but it literally worked lol
          entSpots.BannerImage = SaveBannerImage(BannerImageURL);
          entSpots.FullDescription = txt_FullDescription.Text.ToString();
          entSpots.SerialNumber = Convert.ToInt32(txt_SerialNumber.Text);
          entSpots.InsertedBy = Convert.ToInt32(Session["SessionId"]);
          entSpots.CategoryId = Convert.ToInt32(ddlCategoryName.SelectedValue);
          int ins = bllSpots.InsertSpot(entSpots);
          if (ins != 0)
          {
            Response.Write("<script>alert('Details Inserted Successfully')</script>");

            txt_SerialNumber.Text = null;
            txt_ShortDescription.Text = null;
            txt_Lattitude.Text = null;
            txt_Longitude.Text = null;
            rdHomePage.SelectedValue = "";

            txt_FullDescription.Text = null;
            txtSpotName.Text = null;
            BindGridOfSpots();
          }
        }

      }

      catch (Exception)
      {

        throw;
      }
    }



    public void BindDropDownCategory()//method to bind the dropdown of category
    {
      Bll_Category bllCategory = new Bll_Category();
      List<Ent_Category> ListentCategory = new List<Ent_Category>();
      try
      {
        ListentCategory = bllCategory.BindCategoryDropdown();
        if (ListentCategory.Count > 0)
        {
          ddlCategoryName.DataSource = ListentCategory;//we have to use list because by using this we can bring multiple values into it 
          ddlCategoryName.DataTextField = "CategoryName";
          ddlCategoryName.DataValueField = "CategoryId";
          ddlCategoryName.DataBind();
        }

        else
        {
          Response.Write("<script>alert('There was some problem in Binding of CategoryName')</script>");
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }



    private string SaveIconImage(FileUpload fileUpload)//method to get the url of image we have uploaded
    {
      string filename;
      if (fileUpload.HasFile == true)
      {
        //string productName = "";
        string ImageName = txtSpotName.Text.Trim();
        ImageName = ImageName.Replace(" ", "").Replace("&", "").Replace("?", "").Replace("/", "").Replace("'\'", "").Replace("@", "").Replace("_", "").Replace("-", "").ToString();
        filename = ImageName +"_IconImage"+ "_" + DateTime.Now.ToString("yyyyMMddHHmmtt");
        string fileExtansion = Path.GetExtension(fileUpload.FileName);
        filename = filename + fileExtansion;
        string fileurl = "~/Upload/IconImage/" + filename;
        fileUpload.SaveAs(Server.MapPath("~/Upload/IconImage/" + filename));

        return fileurl;
      }
      else
      {
        filename = "";
      }
      return filename;

    }



    private bool ShowOnHome(bool ShowOnHomePage)
    {
      Ent_AddSpots entSpot = new Ent_AddSpots();
      Bll_AddSpots bllSpot = new Bll_AddSpots();
      try
      {
        if (rdHomePage.SelectedValue == "True")
        {
          return true;
        }
        else if (rdHomePage.SelectedValue == "False")
        {
          return false;
        }
        return ShowOnHomePage;
      }
      catch (Exception)
      {

        throw;
      }
    }








    private string SaveBannerImage(FileUpload fileUpload)
    {
      string filename;
      if (fileUpload.HasFile == true)
      {
        string imagename = txtSpotName.Text.Trim();
        imagename = imagename.Replace(" ", "").Replace("&", "").Replace("?", "").Replace("/", "").Replace("'\'", "").Replace("@", "").Replace("_", "").Replace("-", "").ToString();
        filename = imagename + "_" + "BannerImage_" + DateTime.Now.ToString("yyyyMMddHHmmtt");
        string filextension = Path.GetExtension(fileUpload.FileName);
        filename = filename + filextension;
        string fileURL = "~/Upload/BannerImage/" + filename;
        fileUpload.SaveAs(Server.MapPath("~/Upload/BannerImage/" + filename));

        return fileURL;
      }
      else
      {
        filename = "";
      }
      return filename;
    }













    public void BindGridOfSpots() //Binding the grid of spots
    {
      List<Ent_AddSpots> listentspots = new List<Ent_AddSpots>();
      Bll_AddSpots bllspots = new Bll_AddSpots();
      try
      {
        listentspots = bllspots.BindSpots();
        if (listentspots.Count > 0)
        {
          GridSpot.DataSource = listentspots;
          GridSpot.DataBind();
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
      Ent_AddSpots entUpSpot = new Ent_AddSpots();
      Bll_AddSpots bllUpSpot = new Bll_AddSpots();
      try
      {

        LinkButton btnUpdate = sender as LinkButton;
        int SpotId = Convert.ToInt32(btnUpdate.CommandArgument);
        entUpSpot = bllUpSpot.SelectionForUpdate(SpotId);
        if (SpotId > 0)
        {
          txt_SerialNumber.Text = Convert.ToString(entUpSpot.SerialNumber);
          ddlCategoryName.DataValueField = entUpSpot.CategoryId.ToString();
          txtSpotName.Text = entUpSpot.SpotName.ToString();
          txt_ShortDescription.Text = entUpSpot.ShortDescription.ToString();
          txt_Lattitude.Text = entUpSpot.Lattitude.ToString();
          txt_Longitude.Text = entUpSpot.Longitude.ToString();
          if (entUpSpot.ShowOnHomePage == true)
          {
            rdHomePage.SelectedValue = "True";
          }
          else if (entUpSpot.ShowOnHomePage == false)
          {
            rdHomePage.SelectedValue = "False";
          }

          txt_FullDescription.Text = entUpSpot.FullDescription.ToString();

          ViewState["SpotId"] = SpotId;
        }
        else
        {
          Response.Write("<script>alert('Something went wrong')</script>");
          BindGridOfSpots();
          txt_SerialNumber.Text = null;
          txt_ShortDescription.Text = null;
          txt_Lattitude.Text = null;
          txt_Longitude.Text = null;
          rdHomePage.SelectedValue = "";
          txt_FullDescription.Text = null;
          txtSpotName.Text = null;
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }
    //protected void btnUpdate_Click(object sender, EventArgs e)
    //{
    //  List<Ent_AddSpots> listentUpSpot = new List<Ent_AddSpots>();
    //  Bll_AddSpots bllUpSpot = new Bll_AddSpots();
    //  try
    //  {
    //    Ent_AddSpots entUpspot = new Ent_AddSpots();
    //    LinkButton btnUpdate= sender as LinkButton;
    //    int SpotId = Convert.ToInt32(btnUpdate.CommandArgument);


    //    listentUpSpot = bllUpSpot.SelectionForUpdate(SpotId);
    //    if (listentUpSpot.Count > 0)
    //    {
    //      txtSerialNumber.Text = entUpspot.SerialNumber.ToString();

    //      txtSpotName.Text = entUpspot.SpotName.ToString(); 
    //      txt_ShortDescription.Text = entUpspot.ShortDescription.ToString();
    //      txt_Lattitude.Text = entUpspot.Lattitude.ToString();
    //      txt_Longitude.Text = entUpspot.Longitude.ToString();
    //      if (entUpspot.ShowOnHomePage == true)
    //      {
    //        rdHomePage.SelectedValue = "True";
    //      }
    //      else if (entUpspot.ShowOnHomePage == false)
    //      {
    //        rdHomePage.SelectedValue = "False";
    //      }

    //      txt_FullDescription.Text = entUpspot.FullDescription.ToString();
    //      txtSerialNumber.Text = Convert.ToString(entUpspot.SpotName);
    //    }
    //    else
    //    {
    //      Response.Write("<script>alert('Something went wrong')</script>");
    //      txtSerialNumber.Text = null;
    //      txt_ShortDescription.Text = null;
    //      txt_Lattitude.Text = null;
    //      txt_Longitude.Text = null;
    //      rdHomePage.SelectedValue = "";

    //      txt_FullDescription.Text = null;
    //      txtSpotName.Text = null;
    //    }
    //  }
    //  catch (Exception ex)
    //  {

    //    throw;
    //  }
    //}

    protected void btnDelete_Click(object sender, EventArgs e)
    {
      Ent_AddSpots entSpot = new Ent_AddSpots();
      Bll_AddSpots bllSpot = new Bll_AddSpots();
      try
      {
        LinkButton btnDelete = sender as LinkButton;
        int SpotId = Convert.ToInt32(btnDelete.CommandArgument);
        entSpot.SpotId = SpotId;
        entSpot.DeletedBy = Convert.ToInt32(Session["SessionId"]);
        int Del = bllSpot.DeleteRecord(entSpot);
        if (Del != 0)
        {
          Response.Write("<script>alert('Data Deleted Successfully')</script>");
          BindGridOfSpots();
          txt_SerialNumber.Text = null;
          txt_ShortDescription.Text = null;
          txt_Lattitude.Text = null;
          txt_Longitude.Text = null;
          rdHomePage.SelectedValue = "";

          txt_FullDescription.Text = null;
          txtSpotName.Text = null;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}