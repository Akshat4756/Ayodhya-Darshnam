using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BLL.Admin;
using Entity.Admin;
using System.IO;
using System.Runtime.InteropServices;

namespace Project_Ayodhya_Darshan.Admin
{
  public partial class AddSpotImages : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindSpotImages();
      }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
      Ent_AddSpotImages entSpotImages = new Ent_AddSpotImages();
      Bll_AddSpotImages bllSpotImages = new Bll_AddSpotImages();
      try
      {
        if (ViewState["SpotImageId"]!=null)
        {
          entSpotImages.SpotImageId = Convert.ToInt32(ViewState["SpotImageId"]);
          entSpotImages.SerialNumber = Convert.ToInt32(txtSerialNumber.Text);
          entSpotImages.ImageTitle = txtImageIitle.Text.ToString();
          entSpotImages.ImageLink = SaveImage(SpotImageURL);
          
          entSpotImages.UpdatedBy = Convert.ToInt32(Session["SessionId"]);
          int Upd = bllSpotImages.UpdateData(entSpotImages);
          if (Upd != 0)
          {
            Response.Write("<script>alert('Updated successfully')</script>");
            txtImageIitle.Text = null;
            txtSerialNumber.Text = null;
            BindSpotImages();
            
          }
        }
        else
        {
          int SpotId = Convert.ToInt32(Request.QueryString["Id"]);
          entSpotImages.SpotId = SpotId;
          entSpotImages.ImageTitle = txtImageIitle.Text.ToString();
          entSpotImages.SerialNumber = Convert.ToInt32(txtSerialNumber.Text);
          entSpotImages.InsertedBy = Convert.ToInt32(Session["SessionId"]);
          entSpotImages.ImageLink = SaveImage(SpotImageURL);
          int ins = bllSpotImages.InsertData(entSpotImages);
          if (ins != 0)
          {
            Response.Write("<script>alert('Image inserted successfully')</script>");
            BindSpotImages();
            Response.Flush();

          }
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    private string SaveImage(FileUpload fileupload)
    {

      string FileName;
      if (fileupload.HasFile == true)
      {
        string ImageName = txtImageIitle.Text;
        ImageName = ImageName.Replace(" ", "").Replace("&", "").Replace("?", "").Replace("/", "").Replace("'\'", "").Replace("@", "").Replace("_", "").Replace("-", "").ToString();
        FileName = ImageName + "_" + DateTime.Now.ToString("yyyyMMddHHmmtt");
        string FileExtension = Path.GetExtension(fileupload.FileName);
        FileName = FileName + FileExtension;
        string ImageUrl = "~/Upload/SpotImages/" + FileName;
        fileupload.SaveAs(Server.MapPath("~/Upload/SpotImages/" + FileName));
        return ImageUrl;
      }
      else
      {
        FileName = "";
      }
      return FileName;
    }
    public void BindSpotImages()
    {
      List<Ent_AddSpotImages> listent = new List<Ent_AddSpotImages>();
      Bll_AddSpotImages bllSpotImages = new Bll_AddSpotImages();
      try
      {
        listent = bllSpotImages.BindSpotImages();
        if (listent.Count > 0)
        {
          GridSpotImages.DataSource = listent;
          GridSpotImages.DataBind();
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
      Ent_AddSpotImages entSpotImage = new Ent_AddSpotImages();
      Bll_AddSpotImages bllSpotImage = new Bll_AddSpotImages();
      try
      {
        LinkButton btn_Update = sender as LinkButton;
        int SpotImageId = Convert.ToInt32(btn_Update.CommandArgument);
        entSpotImage = bllSpotImage.SelectionForUpdateRecord(SpotImageId);
        if (SpotImageId > 0)
        {
          txtImageIitle.Text = entSpotImage.ImageTitle.ToString();
          txtSerialNumber.Text = entSpotImage.SerialNumber.ToString();
          ViewState["SpotImageId"] = SpotImageId;
          reqSpotImageURL.Enabled = false;
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
      Bll_AddSpotImages bllSpotImages = new Bll_AddSpotImages();
      Ent_AddSpotImages entSpotImages = new Ent_AddSpotImages();
      try
      {
        LinkButton btn_Delete = sender as LinkButton;
        entSpotImages.SpotImageId = Convert.ToInt32(btn_Delete.CommandArgument);
        entSpotImages.DeletedBy = Convert.ToInt32(Session["SessionId"]);
        int Del = bllSpotImages.DeleteData(entSpotImages); 
        if (Del != 0)
        {
          Response.Write("<script>alert('Image deleted successfully')</script>");
          BindSpotImages();
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}