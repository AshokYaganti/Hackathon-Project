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
using System.Collections.Generic;
public partial class DisplayImage : System.Web.UI.Page
{


    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack)
        //{
        //    BindDetails();
        //    BindTagname();
          
           
        //}
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int searchby =Convert.ToInt32(DropDownList1.SelectedValue);
        
        if (searchby == 1)
        {
            BindDetails();
        }
        else if (searchby == 2)
        {
            BindTagname();
        }
        else
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Option' )</script>", false);
        }



    }

    public void BindDetails()
    {

        Dictionary<int, string> sl = new Dictionary<int, string>();
        string EmailID = Convert.ToString(Session["emailid"]);
        sl = obj.GetUserCategory(EmailID);
      
        DropDownList2.DataSource = sl;
        DropDownList2.DataValueField = "Value";
        DropDownList2.DataTextField = "Value";
             
        DropDownList2.DataBind();
        DropDownList2.Items.Add(new ListItem("Select Category", "0"));
    }
    public void BindTagname()
    {

        Dictionary<int, string> sl1 = new Dictionary<int, string>();
        string EmailID = Convert.ToString(Session["emailid"]);
        sl1 = obj.GetUserTagNames(EmailID);

       
        DropDownList2.DataSource = sl1;
        DropDownList2.DataValueField = "Value";
        DropDownList2.DataTextField = "Value";
       
        DropDownList2.DataBind();
        DropDownList2.Items.Add(new ListItem("Select Tag Name", "0"));
    }




    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        string searchby = DropDownList1.SelectedValue;
        string name = Convert.ToString(DropDownList2.SelectedItem);
        string EmailID = Convert.ToString(Session["emailid"]);
        if ((name == "Select Tag Name") || (name == "Select Category"))
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Option' )</script>", false);
        }

        if (searchby == "1")
        {

           
            DataSet ds = new DataSet();

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_GetCategoryImageDetails", con);
            cmd.CommandText = "sp_GetCategoryImageDetails";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 100);
            SqlParameter name1 = cmd.Parameters.Add("@categoryname", SqlDbType.VarChar, 100);
            EmailID1.Value = EmailID;
            name1.Value = name;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();
            GridView1.DataSource = ds;
            GridView1.DataBind();


        }
        else if (searchby == "2")
        {

            DataSet ds1 = new DataSet();

            con.Open();
            SqlCommand cmd = new SqlCommand("sp_GetTagNameImageDetails", con);
            cmd.CommandText = "sp_GetTagNameImageDetails";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 100);
            SqlParameter name1 = cmd.Parameters.Add("@tagname", SqlDbType.VarChar, 100);
            EmailID1.Value = EmailID;
            name1.Value = name;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds1);
            con.Close();
            GridView1.DataSource = ds1;
            GridView1.DataBind();

        }
        else
        {
        }

    }


    protected void lnkdelete_Click(object sender, EventArgs e)
    {
        

            LinkButton lnkbtndel = sender as LinkButton;
            GridViewRow gdrow = lnkbtndel.NamingContainer as GridViewRow;
            int rowIndex = gdrow.RowIndex;
            Label imageid = GridView1.Rows[rowIndex].FindControl("ID2") as Label;
            string imageid1 = imageid.Text;
            int imageid12 = Convert.ToInt32(imageid1);
           
            int result = obj.DeleteImageDetails(imageid12);
            if (result > 0)
            {
                //BindDetails();
                //BindTagname();

                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Image has been Deleted Successfully');window.location='DisplayImage.aspx';", true);
               
            }
            else
            {
            }
      
    }
}


 