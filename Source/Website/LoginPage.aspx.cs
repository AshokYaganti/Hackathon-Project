using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ServiceReference1;
public partial class LoginPage : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string EmailID = TextBox1.Text;
        string Password = TextBox2.Text;

        string EmailID11 = string.Empty;
        string Password11 = string.Empty;
        string firsttime = string.Empty;


        if (EmailID.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Email ID')</script>", false);
        }
        else if (Password.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Password')</script>", false);
        }
        else
        {
            ds1 = obj.GetDetails(EmailID);


            if (ds1 != null && ds1.Tables[0].Rows.Count > 0)
            {
                EmailID11 = ds1.Tables[0].Rows[0]["EmailID"].ToString();
                Password11 = ds1.Tables[0].Rows[0]["Password"].ToString();
                firsttime = ds1.Tables[0].Rows[0]["firsttime"].ToString();
            }


            if ((EmailID == EmailID11) && (Password == Password11) && (firsttime=="no"))
            {
                Session["emailid"] = EmailID;
                Session["loggedin"] = "created";
                Response.Redirect("UserHome.aspx");
            }
            else if ((EmailID == EmailID11) && (Password == Password11) && (firsttime=="yes"))
            {
                Session["emailid"] = EmailID;
                Session["loggedin"] = "created";
                Response.Redirect("ChangePassword.aspx");
            }
                
           
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Email ID or Password incorrect')</script>", false);
                //Response.Redirect(ResolveUrl("login.aspx"));
            }
        }


    }
}