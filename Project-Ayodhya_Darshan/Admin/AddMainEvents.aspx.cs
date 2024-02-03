using BLL.Admin;
using Entity.Admin;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Ayodhya_Darshan.Admin
{
  public partial class AddMainEvents : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      Bindgrid();

    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
      Ent_AddEvents entEvent = new Ent_AddEvents();
      Bll_AddEvents bllEvent = new Bll_AddEvents();
      try
      {
        LinkButton btnUpdate = sender as LinkButton;
        int EventId = Convert.ToInt32(btnUpdate.CommandArgument);
        entEvent = bllEvent.SelectionForUpdate(EventId);
        if (EventId != 0)
        {
          txtEventName.Text = entEvent.EventName;
          txtSerialNumber.Text =entEvent.SerialNumber.ToString();
          txt_FullDescription.Text =entEvent.FullDescription;
          txt_ShortDescription.Text = entEvent.ShortDescription;
          if (entEvent.ShowOnHomePage == true)
          {
            Rbl_ShowOnHompage.SelectedValue = "True";
          }
          else if(entEvent.ShowOnHomePage == false)
          {
            Rbl_ShowOnHompage.SelectedValue="False";  
          }
          ViewState["EventId"] = EventId;
          reqIconImageURL.Enabled = false;
          rqrBannerImageUrl.Enabled = false;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
      Ent_AddEvents entEvent = new Ent_AddEvents();
      Bll_AddEvents bllEvent = new Bll_AddEvents();
      try
      {
        LinkButton btnUpdate = sender as LinkButton;
        entEvent.EventId = Convert.ToInt32(btnUpdate.CommandArgument);
        entEvent.DeletedBy = Convert.ToInt32(Session["SessionId"]);
        int Del = bllEvent.DeleteEvent(entEvent);
        if (Del != 0)
        {
          Response.Write("<script>alert('Details Deleted Successfully')</script>");
          txtEventName.Text = null;
          txtSerialNumber.Text = null;
          txt_FullDescription.Text = null;
          txt_ShortDescription.Text = null;
          Rbl_ShowOnHompage.SelectedValue = null;
          Bindgrid();
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
    private void Bindgrid()
    {
      List<Ent_AddEvents> listentEvent = new List<Ent_AddEvents>();
      Bll_AddEvents bllEvent = new Bll_AddEvents();
      try
      {
        listentEvent = bllEvent.BindGrid();
        if (listentEvent.Count > 0)
        {
          GridEvent.DataSource = listentEvent;
          GridEvent.DataBind();
        }
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
        string imagename = txtEventName.Text.Trim();
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
    private string SaveIconImage(FileUpload fileUpload)//method to get the url of image we have uploaded
    {
      string filename;
      if (fileUpload.HasFile == true)
      {
        //string productName = "";
        string ImageName = txtEventName.Text.Trim();
        ImageName = ImageName.Replace(" ", "").Replace("&", "").Replace("?", "").Replace("/", "").Replace("'\'", "").Replace("@", "").Replace("_", "").Replace("-", "").ToString();
        filename = ImageName + "_IconImage" + "_" + DateTime.Now.ToString("yyyyMMddHHmmtt");
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
    public bool ShowOnHome(bool showonhomepage)
    {
      Ent_AddEvents entEvent = new Ent_AddEvents();
      Bll_AddEvents bllEvent = new Bll_AddEvents();
      try
      {
        if (Rbl_ShowOnHompage.SelectedValue=="True")
        {
          return true;
        }
        else if (Rbl_ShowOnHompage.SelectedValue == "False")
        {
          return false;
        }
        return showonhomepage;
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
      Ent_AddEvents entEvents = new Ent_AddEvents();
      Bll_AddEvents bllEvents = new Bll_AddEvents();
      try
      {
        if (ViewState["EventId"] != null)
        {
          entEvents.EventId = Convert.ToInt32(ViewState["EventId"]);
          entEvents.SerialNumber = Convert.ToInt32(txtSerialNumber.Text.Trim());
          entEvents.EventName = txtEventName.Text.Trim().ToString();
          entEvents.BannerImage = SaveBannerImage(UploadBannerImageURL);
          entEvents.IconImage = SaveIconImage(IconImageURL);
          entEvents.ShortDescription = txt_ShortDescription.Text.Trim().ToString();
          entEvents.FullDescription = txt_FullDescription.Text.Trim().ToString();
          entEvents.ShowOnHomePage = ShowOnHome(entEvents.ShowOnHomePage);
          entEvents.UpdatedBy = Convert.ToInt32(Session["SessionId"]);
          int upd = bllEvents.UpdateEvent(entEvents);
          if (upd != 0)
          {
            Response.Write("<script>alert('Details Updated Successfully')</script>");
            txtEventName.Text = null;
            txtSerialNumber.Text = null;
            txt_FullDescription.Text = null;
            txt_ShortDescription.Text = null;
            Rbl_ShowOnHompage.SelectedValue = null;
            Bindgrid();
          }
        }
        else
        {
          entEvents.SerialNumber = Convert.ToInt32(txtSerialNumber.Text.Trim());
          entEvents.EventName = txtEventName.Text.Trim().ToString();
          entEvents.BannerImage = SaveBannerImage(UploadBannerImageURL);
          entEvents.IconImage = SaveIconImage(IconImageURL);
          entEvents.ShortDescription = txt_ShortDescription.Text.Trim().ToString();
          entEvents.FullDescription = txt_FullDescription.Text.Trim().ToString();
          entEvents.ShowOnHomePage = ShowOnHome(entEvents.ShowOnHomePage);
          entEvents.InsertedBy = Convert.ToInt32(Session["SessionId"]);
          int Ins = bllEvents.InsertEvents(entEvents);
          if (Ins != 0)
          {
            Response.Write("<script>alert('Details Inserted Successfully')</script>");
            txtEventName.Text = null;
            txtSerialNumber.Text = null;
            txt_FullDescription.Text = null;
            txt_ShortDescription.Text = null;
            Rbl_ShowOnHompage.SelectedValue = null;
            Bindgrid();
          }
        }
       
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}