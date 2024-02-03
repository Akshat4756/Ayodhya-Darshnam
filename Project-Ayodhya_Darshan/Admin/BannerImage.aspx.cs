using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Admin;
using Entity.Admin;

namespace Project_Ayodhya_Darshan.Admin
{
  public partial class BannerImage : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        BindGrid();
      }
    }
    public void BindGrid()
    {
      Bll_AddBannerImage bllBanner = new Bll_AddBannerImage();
      List<Ent_AddBannerImage> listentBanner = new List<Ent_AddBannerImage>();
      try
      {
        listentBanner = bllBanner.BindBanner();
        if (listentBanner.Count > 0)
        {
          GridBanner.DataSource = listentBanner;
          GridBanner.DataBind();
        }
        else
        {
          GridBanner.DataSource = null;
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
        string ImageName = txtbannerName.Text;
        ImageName = ImageName.Replace(" ", "").Replace("&", "").Replace("?", "").Replace("/", "").Replace("'\'", "").Replace("@", "").Replace("_", "").Replace("-", "").ToString();
        FileName = ImageName + "_" + DateTime.Now.ToString("yyyyMMddHHmmtt");
        string FileExtension = Path.GetExtension(fileupload.FileName);
        FileName = FileName + FileExtension;
        string ImageUrl = "~/Upload/BannerImageHead/" + FileName;
        fileupload.SaveAs(Server.MapPath("~/Upload/BannerImageHead/" + FileName));
        return ImageUrl;
      }
      else
      {
        FileName = "";
      }
      return FileName;
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
      Bll_AddBannerImage bllBanner = new Bll_AddBannerImage();
      Ent_AddBannerImage entBanner = new Ent_AddBannerImage();
      try
      {
        if (ViewState["BannerImageId"] != null)
        {
          entBanner.SerialNumber = Convert.ToInt32(txtSerialNumber.Text);
          entBanner.BannerImageName = txtbannerName.Text;
          entBanner.BannerImageUrl = SaveImage(UploadBannerImageURL);
          entBanner.BannerImageId= Convert.ToInt32(ViewState["BannerImageId"]);
          entBanner.UpdatedBy = Convert.ToInt32(Session["SessionId"]);
          int Upd = bllBanner.UpdateBanner(entBanner);
          if (Upd != 0)
          {
            Response.Write("<script>alert('BannerImage Updated Successfully')</script>");
            txtbannerName.Text = null;
            txtSerialNumber.Text = null;
            BindGrid();
          }
          else
          {
            Response.Write("<script>alert('Something Went wrong')</script>");
            txtbannerName.Text = null;
            txtSerialNumber.Text = null;
          }
        }
        else
        {
          entBanner.SerialNumber = Convert.ToInt32(txtSerialNumber.Text);
          entBanner.BannerImageName = txtbannerName.Text.ToString();
          entBanner.BannerImageUrl = SaveImage(UploadBannerImageURL);
          entBanner.InsertedBy= Convert.ToInt32(Session["SessionId"]);
          int Ins = bllBanner.InsertBanner(entBanner);
          if (Ins != 0)
          {
            Response.Write("<script>alert('BannerImage Inserted Successfully')</script>");
            txtbannerName.Text = null;
            txtSerialNumber.Text = null;
            BindGrid();
          }
          else
          {
            Response.Write("<script>alert('Something Went wrong')</script>");
            txtbannerName.Text = null;
            txtSerialNumber.Text = null;
            BindGrid();
          }
        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
      Bll_AddBannerImage bllBanner = new Bll_AddBannerImage();
      Ent_AddBannerImage entBanner = new Ent_AddBannerImage();
      try
      {
        LinkButton btnUpdate = sender as LinkButton;
        int BannerImageId = Convert.ToInt32(btnUpdate.CommandArgument);
        entBanner = bllBanner.SelectionForUpdate(BannerImageId);
        if (BannerImageId != 0)
        {
          txtbannerName.Text = entBanner.BannerImageName.ToString();
          txtSerialNumber.Text = entBanner.SerialNumber.ToString();
          ViewState["BannerImageId"] = BannerImageId;
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
      Ent_AddBannerImage entBanner = new Ent_AddBannerImage();
      Bll_AddBannerImage bllBanner = new Bll_AddBannerImage();
      try
      {
        LinkButton btnDelete = sender as LinkButton;
        int BannerImageId = Convert.ToInt32(btnDelete.CommandArgument);
        entBanner.BannerImageId = Convert.ToInt32(BannerImageId);
        entBanner.DeletedBy = Convert.ToInt32(Session["SessionId"]);
        int Del = bllBanner.DeleteBanner(entBanner);
        if (Del != 0)
        {
          Response.Write("<script>alert('BannerImage Deleted Successfully')</script>");
          BindGrid();
        }
      }
      catch (Exception ex)
      {

        throw;
      }
    }
  }
}