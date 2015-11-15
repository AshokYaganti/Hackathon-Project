<%@ WebHandler Language="C#" Class="Handler2" %>

using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Data.SqlClient;

public class Handler2 : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        if (context.Request.QueryString["imageid"] != null)
        {
            // context.Response.Write(context.Request.QueryString["id"]);
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);

            //SqlConnection con = new SqlConnection(@"Data Source=Ashok\SQL2008; Initial Catalog=yaganti; User Id=sa; Password=srilakshmi");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select photo from ArchiveImageDetails where imageid=@imageid", con);
            cmd.Parameters.AddWithValue("@imageid", context.Request.QueryString["imageid"].ToString());
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            context.Response.BinaryWrite((byte[])dr["photo"]);
            dr.Close();
            con.Close();
        }
        else
        {
            context.Response.Write("No Image Found");
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}