using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ServiceReference1;
public partial class ChangePassword : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();

        string newpassword = string.Empty;
        string confirmpassword = string.Empty;
        string EmailID = Convert.ToString(Session["emailid"]);

        newpassword = TextBox3.Text;
        confirmpassword = TextBox4.Text;
        string password11 = "MustChangeThisPassword";
        bool passcheck = password11.Equals(newpassword);

        bool pass = newpassword.Equals(confirmpassword);


        if (newpassword.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter new Password')</script>", false);
        }
        else if ((newpassword.Length < 6) || (newpassword.Length > 15))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Password Range should be 6-15 characters' )</script>", false);

        }
        else if (passcheck.Equals(true))
        {

            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('You have Entered Default Password' )</script>", false);
        }
        else if (confirmpassword.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Confirm password Password')</script>", false);
        }
        else if (pass.Equals(false))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Check Confirm Password' )</script>", false);

        }
        else
        {

            string firsttime = "no";
            int result = obj.UpdatePassword(EmailID, newpassword,firsttime);

            if (result > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Password has been Updated Successfully');window.location='UserHome.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Password Was not Updated')</script>", false);
                Response.Redirect(ResolveUrl("LoginPage.aspx"));
            }
        }
    }
}
            
          

