using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class DisplayArchiveImage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        string EmailID = Convert.ToString(Session["emailid"]);
        con.Open();
        SqlCommand cmd = new SqlCommand("sp_GetArchiveImageDetails", con);
        cmd.CommandText = "sp_GetArchiveImageDetails";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 100);
      
        EmailID1.Value = EmailID;
        
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
}