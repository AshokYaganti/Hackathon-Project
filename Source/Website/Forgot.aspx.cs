using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Data;
using ServiceReference1;
public partial class Forgot : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        DataSet ds = new DataSet();
     
        string EmailID = TextBox2.Text;
       
        string pass11 = string.Empty;
        
        string EmailID11 = string.Empty;
        
        if (EmailID.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Email Address')</script>", false);
        }

        else
        {
            ds = obj.GetForgotDetails(EmailID);

            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
               
                EmailID11 = ds.Tables[0].Rows[0]["EmailID"].ToString();
                pass11 = ds.Tables[0].Rows[0]["Password"].ToString();
            }


           if (EmailID11==EmailID)
           {


               string to = EmailID;
                string from = "yagantiashok@gmail.com";
                string subject = "Recovery Password";
                string body = "Your Recovery Password for Image Repository is :" + pass11;
                using (MailMessage mm = new MailMessage(from, to))
                {
                    mm.Subject = subject;
                    mm.Body = body;
                    mm.IsBodyHtml = false;
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    NetworkCredential NetworkCred = new NetworkCredential(from, "srilakshmi123");
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = 587;
                    smtp.Send(mm);
                    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Recovery Password has been sent to your email.');", true);
                }

            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Email Address Incorrect')</script>", false);
                //Response.Redirect(ResolveUrl("login.aspx"));
            }
        }
    }
}
