using System;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.IO;
using System.Data;
using ServiceReference1;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
public partial class UploadImage : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddata();
        }
     
    }

    public void binddata()
    {
        Dictionary<int, string> sl = new Dictionary<int, string>();

        sl = obj.GetCategory();
        DropDownList1.Items.Add(new ListItem("Select Category", "0"));

        DropDownList1.DataSource = sl;
        DropDownList1.DataValueField = "Key";
        DropDownList1.DataTextField = "Value";
        DropDownList1.DataBind();
        DropDownList1.Items.Add(new ListItem("...other...", "other"));
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        //try
        //{

        byte[] raw;
        string categoryname = Convert.ToString(DropDownList1.SelectedItem);
        DateTime date = DateTime.Now;
        string tagname = TextBox2.Text;
        if (categoryname == "Select Category")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Kindly Select Categoryname' )</script>", false);
        }
        else if (categoryname == "...other...")
        {
            string categoryname11 = TextBox1.Text;
            if (categoryname11.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Categoryname' )</script>", false);
            }
            else if (tagname.Length == 0)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Image Tagname' )</script>", false);
            }
            else
            {

                if ((FileUpload1.FileName != ""))
                {
                   

                    string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
                    if (((extension == ".jpg") || ((extension == ".gif") || (extension == ".png"))))
                    {
                        string EmailID = Convert.ToString(Session["emailid"]);

                        string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);

                        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Gallery/") + fileName);

                        FileStream fs = new FileStream(Server.MapPath("~/Gallery/") + fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);


                        raw = new byte[fs.Length];
                        fs.Read(raw, 0, Convert.ToInt32(fs.Length));

                        int result = obj.InsertImageDetails(EmailID, categoryname11, tagname, raw, date);
                       

                        if (result > 0)
                        {
                            int result11 = obj.UpdateCategory(categoryname11);
                            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Image has been uploaded Successfully');window.location='UploadImage.aspx';", true);
                        }
                        else
                        {
                            string script = "<script>alert('Error Adding Data')</script>";
                            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Error", script);
                        }
                    }
                    else
                    {

                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Only Jpg,gif or Png files are permitted' )</script>", false);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Kindly Select the file' )</script>", false);
                }

            }
        }
        else
        {
            Label1.Visible = false;
            TextBox1.Visible = false;

            if ((FileUpload1.FileName != ""))
            {


                string extension = Path.GetExtension(FileUpload1.PostedFile.FileName);
                if (((extension == ".jpg") || ((extension == ".gif") || (extension == ".png"))))
                {

                    string EmailID = Convert.ToString(Session["emailid"]);

                    string fileName = Path.GetFileName(FileUpload1.PostedFile.FileName);

                    FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Gallery/") + fileName);

                    FileStream fs = new FileStream(Server.MapPath("~/Gallery/") + fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);

                    raw = new byte[fs.Length];
                    fs.Read(raw, 0, Convert.ToInt32(fs.Length));

                    int result = obj.InsertImageDetails(EmailID, categoryname, tagname, raw, date);


                    if (result > 0)
                    {

                        ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Image has been uploaded Successfully');window.location='UploadImage.aspx';", true);
                    }

                    else
                    {

                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Image Was not Uploaded' )</script>", false);
                       
                    }

                }
                else
                {

                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Only Jpg,gif or Png files are permitted' )</script>", false);


                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Kindly Select the file' )</script>", false);
            }

            //}
            //catch (Exception e1)
            //{

            //}
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string categoryname = DropDownList1.SelectedValue;

        if (categoryname == "other")
        {
            Label1.Visible = true;
            TextBox1.Visible = true;
        }
        else
        {
            Label1.Visible = false;
            TextBox1.Visible = false;
        }
    }
}