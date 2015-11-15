using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using ServiceReference1;
public partial class Register : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        string EmailID = TextBox1.Text;
        List<string> EmailID11 = new List<string>();
        ds = obj.GetEmailID();

        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {

            EmailID11.Add(ds.Tables[0].Rows[i][0].ToString());
        }

        string Password = "MustChangeThisPassword";
        Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        Match match = regex.Match(EmailID);

        if (EmailID.Length == 0)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Enter Email ID')</script>", false);
        }
        else if (!(match.Success))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Email Address was not in correct Format' )</script>", false);
        }
        else if (EmailID11.Contains(EmailID))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Email Address already exist' )</script>", false);
        }
        else
        {
            string firsttime = "yes";

            int result = obj.InserRegisterDetails(EmailID, Password, firsttime);

            if (result > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your Registration was Accepted and Default password sent to your Email ID');window.location='LoginPage.aspx';", true);

                string to = EmailID;
                string from = "yagantiashok@gmail.com";
                string subject = "Default Password";
                string body = "Your Default Password for Image Repository is :" + Password;
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
                    
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Registration Failure')</script>", false);
                Response.Redirect(ResolveUrl("Register.aspx"));

            }
        }
        

           

    }
}