using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using ServiceReference1;
public partial class ArchiveImage : System.Web.UI.Page
{
   
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int month = Convert.ToInt32(DropDownList2.SelectedValue);

        if ((month == 1) || (month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
        {
            DropDownList3.Items.Add(new ListItem("Select day", "0"));
            DropDownList3.Items.Add(new ListItem("1", "1"));
            DropDownList3.Items.Add(new ListItem("2", "2"));
            DropDownList3.Items.Add(new ListItem("3", "3"));
            DropDownList3.Items.Add(new ListItem("4", "4"));
            DropDownList3.Items.Add(new ListItem("5", "5"));
            DropDownList3.Items.Add(new ListItem("6", "6"));
            DropDownList3.Items.Add(new ListItem("7", "7"));
            DropDownList3.Items.Add(new ListItem("8", "8"));
            DropDownList3.Items.Add(new ListItem("9", "9"));
            DropDownList3.Items.Add(new ListItem("10", "10"));
            DropDownList3.Items.Add(new ListItem("11", "11"));
            DropDownList3.Items.Add(new ListItem("12", "12"));
            DropDownList3.Items.Add(new ListItem("13", "13"));
            DropDownList3.Items.Add(new ListItem("14", "14"));
            DropDownList3.Items.Add(new ListItem("15", "15"));
            DropDownList3.Items.Add(new ListItem("16", "16"));
            DropDownList3.Items.Add(new ListItem("17", "17"));
            DropDownList3.Items.Add(new ListItem("18", "18"));
            DropDownList3.Items.Add(new ListItem("19", "19"));
            DropDownList3.Items.Add(new ListItem("20", "20"));
            DropDownList3.Items.Add(new ListItem("21", "21"));
            DropDownList3.Items.Add(new ListItem("22", "22"));
            DropDownList3.Items.Add(new ListItem("23", "23"));
            DropDownList3.Items.Add(new ListItem("24", "24"));
            DropDownList3.Items.Add(new ListItem("25", "25"));
            DropDownList3.Items.Add(new ListItem("26", "26"));
            DropDownList3.Items.Add(new ListItem("27", "27"));
            DropDownList3.Items.Add(new ListItem("28", "28"));
            DropDownList3.Items.Add(new ListItem("29", "29"));
            DropDownList3.Items.Add(new ListItem("30", "30"));
            DropDownList3.Items.Add(new ListItem("31", "31"));

        }
        else if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
        {
            DropDownList3.Items.Add(new ListItem("Select day", "0"));
            DropDownList3.Items.Add(new ListItem("1", "1"));
            DropDownList3.Items.Add(new ListItem("2", "2"));
            DropDownList3.Items.Add(new ListItem("3", "3"));
            DropDownList3.Items.Add(new ListItem("4", "4"));
            DropDownList3.Items.Add(new ListItem("5", "5"));
            DropDownList3.Items.Add(new ListItem("6", "6"));
            DropDownList3.Items.Add(new ListItem("7", "7"));
            DropDownList3.Items.Add(new ListItem("8", "8"));
            DropDownList3.Items.Add(new ListItem("9", "9"));
            DropDownList3.Items.Add(new ListItem("10", "10"));
            DropDownList3.Items.Add(new ListItem("11", "11"));
            DropDownList3.Items.Add(new ListItem("12", "12"));
            DropDownList3.Items.Add(new ListItem("13", "13"));
            DropDownList3.Items.Add(new ListItem("14", "14"));
            DropDownList3.Items.Add(new ListItem("15", "15"));
            DropDownList3.Items.Add(new ListItem("16", "16"));
            DropDownList3.Items.Add(new ListItem("17", "17"));
            DropDownList3.Items.Add(new ListItem("18", "18"));
            DropDownList3.Items.Add(new ListItem("19", "19"));
            DropDownList3.Items.Add(new ListItem("20", "20"));
            DropDownList3.Items.Add(new ListItem("21", "21"));
            DropDownList3.Items.Add(new ListItem("22", "22"));
            DropDownList3.Items.Add(new ListItem("23", "23"));
            DropDownList3.Items.Add(new ListItem("24", "24"));
            DropDownList3.Items.Add(new ListItem("25", "25"));
            DropDownList3.Items.Add(new ListItem("26", "26"));
            DropDownList3.Items.Add(new ListItem("27", "27"));
            DropDownList3.Items.Add(new ListItem("28", "28"));
            DropDownList3.Items.Add(new ListItem("29", "29"));
            DropDownList3.Items.Add(new ListItem("30", "30"));
        }

        else
        {
            DropDownList3.Items.Add(new ListItem("Select day", "0"));
            DropDownList3.Items.Add(new ListItem("1", "1"));
            DropDownList3.Items.Add(new ListItem("2", "2"));
            DropDownList3.Items.Add(new ListItem("3", "3"));
            DropDownList3.Items.Add(new ListItem("4", "4"));
            DropDownList3.Items.Add(new ListItem("5", "5"));
            DropDownList3.Items.Add(new ListItem("6", "6"));
            DropDownList3.Items.Add(new ListItem("7", "7"));
            DropDownList3.Items.Add(new ListItem("8", "8"));
            DropDownList3.Items.Add(new ListItem("9", "9"));
            DropDownList3.Items.Add(new ListItem("10", "10"));
            DropDownList3.Items.Add(new ListItem("11", "11"));
            DropDownList3.Items.Add(new ListItem("12", "12"));
            DropDownList3.Items.Add(new ListItem("13", "13"));
            DropDownList3.Items.Add(new ListItem("14", "14"));
            DropDownList3.Items.Add(new ListItem("15", "15"));
            DropDownList3.Items.Add(new ListItem("16", "16"));
            DropDownList3.Items.Add(new ListItem("17", "17"));
            DropDownList3.Items.Add(new ListItem("18", "18"));
            DropDownList3.Items.Add(new ListItem("19", "19"));
            DropDownList3.Items.Add(new ListItem("20", "20"));
            DropDownList3.Items.Add(new ListItem("21", "21"));
            DropDownList3.Items.Add(new ListItem("22", "22"));
            DropDownList3.Items.Add(new ListItem("23", "23"));
            DropDownList3.Items.Add(new ListItem("24", "24"));
            DropDownList3.Items.Add(new ListItem("25", "25"));
            DropDownList3.Items.Add(new ListItem("26", "26"));
            DropDownList3.Items.Add(new ListItem("27", "27"));
            DropDownList3.Items.Add(new ListItem("28", "28"));
        }
    }


    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int month = Convert.ToInt32(DropDownList2.SelectedValue);

        if ((month == 1) || (month == 3) || (month == 5) || (month == 7) || (month == 8) || (month == 10) || (month == 12))
        {
            DropDownList5.Items.Add(new ListItem("Select day", "0"));
            DropDownList5.Items.Add(new ListItem("1", "1"));
            DropDownList5.Items.Add(new ListItem("2", "2"));
            DropDownList5.Items.Add(new ListItem("3", "3"));
            DropDownList5.Items.Add(new ListItem("4", "4"));
            DropDownList5.Items.Add(new ListItem("5", "5"));
            DropDownList5.Items.Add(new ListItem("6", "6"));
            DropDownList5.Items.Add(new ListItem("7", "7"));
            DropDownList5.Items.Add(new ListItem("8", "8"));
            DropDownList5.Items.Add(new ListItem("9", "9"));
            DropDownList5.Items.Add(new ListItem("10", "10"));
            DropDownList5.Items.Add(new ListItem("11", "11"));
            DropDownList5.Items.Add(new ListItem("12", "12"));
            DropDownList5.Items.Add(new ListItem("13", "13"));
            DropDownList5.Items.Add(new ListItem("14", "14"));
            DropDownList5.Items.Add(new ListItem("15", "15"));
            DropDownList5.Items.Add(new ListItem("16", "16"));
            DropDownList5.Items.Add(new ListItem("17", "17"));
            DropDownList5.Items.Add(new ListItem("18", "18"));
            DropDownList5.Items.Add(new ListItem("19", "19"));
            DropDownList5.Items.Add(new ListItem("20", "20"));
            DropDownList5.Items.Add(new ListItem("21", "21"));
            DropDownList5.Items.Add(new ListItem("22", "22"));
            DropDownList5.Items.Add(new ListItem("23", "23"));
            DropDownList5.Items.Add(new ListItem("24", "24"));
            DropDownList5.Items.Add(new ListItem("25", "25"));
            DropDownList5.Items.Add(new ListItem("26", "26"));
            DropDownList5.Items.Add(new ListItem("27", "27"));
            DropDownList5.Items.Add(new ListItem("28", "28"));
            DropDownList5.Items.Add(new ListItem("29", "29"));
            DropDownList5.Items.Add(new ListItem("30", "30"));
            DropDownList5.Items.Add(new ListItem("31", "31"));

        }
        else if ((month == 4) || (month == 6) || (month == 9) || (month == 11))
        {
            DropDownList5.Items.Add(new ListItem("Select day", "0"));
            DropDownList5.Items.Add(new ListItem("1", "1"));
            DropDownList5.Items.Add(new ListItem("2", "2"));
            DropDownList5.Items.Add(new ListItem("3", "3"));
            DropDownList5.Items.Add(new ListItem("4", "4"));
            DropDownList5.Items.Add(new ListItem("5", "5"));
            DropDownList5.Items.Add(new ListItem("6", "6"));
            DropDownList5.Items.Add(new ListItem("7", "7"));
            DropDownList5.Items.Add(new ListItem("8", "8"));
            DropDownList5.Items.Add(new ListItem("9", "9"));
            DropDownList5.Items.Add(new ListItem("10", "10"));
            DropDownList5.Items.Add(new ListItem("11", "11"));
            DropDownList5.Items.Add(new ListItem("12", "12"));
            DropDownList5.Items.Add(new ListItem("13", "13"));
            DropDownList5.Items.Add(new ListItem("14", "14"));
            DropDownList5.Items.Add(new ListItem("15", "15"));
            DropDownList5.Items.Add(new ListItem("16", "16"));
            DropDownList5.Items.Add(new ListItem("17", "17"));
            DropDownList5.Items.Add(new ListItem("18", "18"));
            DropDownList5.Items.Add(new ListItem("19", "19"));
            DropDownList5.Items.Add(new ListItem("20", "20"));
            DropDownList5.Items.Add(new ListItem("21", "21"));
            DropDownList5.Items.Add(new ListItem("22", "22"));
            DropDownList5.Items.Add(new ListItem("23", "23"));
            DropDownList5.Items.Add(new ListItem("24", "24"));
            DropDownList5.Items.Add(new ListItem("25", "25"));
            DropDownList5.Items.Add(new ListItem("26", "26"));
            DropDownList5.Items.Add(new ListItem("27", "27"));
            DropDownList5.Items.Add(new ListItem("28", "28"));
            DropDownList5.Items.Add(new ListItem("29", "29"));
            DropDownList5.Items.Add(new ListItem("30", "30"));
        }

        else
        {
            DropDownList5.Items.Add(new ListItem("Select day", "0"));
            DropDownList5.Items.Add(new ListItem("1", "1"));
            DropDownList5.Items.Add(new ListItem("2", "2"));
            DropDownList5.Items.Add(new ListItem("3", "3"));
            DropDownList5.Items.Add(new ListItem("4", "4"));
            DropDownList5.Items.Add(new ListItem("5", "5"));
            DropDownList5.Items.Add(new ListItem("6", "6"));
            DropDownList5.Items.Add(new ListItem("7", "7"));
            DropDownList5.Items.Add(new ListItem("8", "8"));
            DropDownList5.Items.Add(new ListItem("9", "9"));
            DropDownList5.Items.Add(new ListItem("10", "10"));
            DropDownList5.Items.Add(new ListItem("11", "11"));
            DropDownList5.Items.Add(new ListItem("12", "12"));
            DropDownList5.Items.Add(new ListItem("13", "13"));
            DropDownList5.Items.Add(new ListItem("14", "14"));
            DropDownList5.Items.Add(new ListItem("15", "15"));
            DropDownList5.Items.Add(new ListItem("16", "16"));
            DropDownList5.Items.Add(new ListItem("17", "17"));
            DropDownList5.Items.Add(new ListItem("18", "18"));
            DropDownList5.Items.Add(new ListItem("19", "19"));
            DropDownList5.Items.Add(new ListItem("20", "20"));
            DropDownList5.Items.Add(new ListItem("21", "21"));
            DropDownList5.Items.Add(new ListItem("22", "22"));
            DropDownList5.Items.Add(new ListItem("23", "23"));
            DropDownList5.Items.Add(new ListItem("24", "24"));
            DropDownList5.Items.Add(new ListItem("25", "25"));
            DropDownList5.Items.Add(new ListItem("26", "26"));
            DropDownList5.Items.Add(new ListItem("27", "27"));
            DropDownList5.Items.Add(new ListItem("28", "28"));
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
   
        string frommonth = DropDownList2.SelectedValue;
        string fromday = DropDownList3.SelectedValue;
        string fromyear =DropDownList4.SelectedValue;

         string tomonth = DropDownList1.SelectedValue;
         string today =  DropDownList5.SelectedValue;
         string toyear = DropDownList6.SelectedValue;

         string fromdate11 = frommonth + "-" + fromday + "-" + fromyear;
         string todate11=   tomonth + "-" + today + "-" + toyear;
         
         DateTime fromdate = Convert.ToDateTime(fromdate11);
         DateTime todate = Convert.ToDateTime(todate11);
         DateTime fromdate123 = fromdate.Date;
         DateTime todate123 = todate.Date;

        if (frommonth == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Month' )</script>", false);

        }

        else if (fromday == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Day' )</script>", false);

        }
        else if (fromyear == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Year' )</script>", false);
        }
        else if (fromdate > DateTime.Now)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Select the Correct from date' )</script>", false);
        }
        else if (tomonth == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Month' )</script>", false);

        }
        else if (today == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Day' )</script>", false);

        }
        else if (toyear == "0")
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please select the Year' )</script>", false);
        }
        else if (todate > DateTime.Now)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('Please Select the Correct from date' )</script>", false);
        }

        else
        {
            string EmailID=Convert.ToString(Session["emailid"]);
            getiamgedetails(fromdate123,todate123);
            int result = obj.ArchiveImageDetails(EmailID,fromdate123,todate123);

            if (result > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Your Documents have been Archived');window.location='ArchiveImage.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ss", "<script>alert('No Documents were found for the Given Interval')</script>", false);
                Response.Redirect(ResolveUrl("ArchiveImage.aspx"));
            }
            
        }
        
    }
    public void getiamgedetails(DateTime fromdate123,DateTime todate123)
    {
        string EmailID = Convert.ToString(Session["emailid"]);
        DataSet ds = new DataSet();
        con.Open();

        SqlCommand cmd = new SqlCommand("sp_GetImageDetails", con);
        cmd.CommandText = "sp_GetImageDetails";
        cmd.CommandType = CommandType.StoredProcedure;
        SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar,100);
        SqlParameter fromdate1 = cmd.Parameters.Add("@fromdate", SqlDbType.DateTime);
        SqlParameter todate1 = cmd.Parameters.Add("@todate", SqlDbType.DateTime);
        EmailID1.Value = EmailID;
        fromdate1.Value = fromdate123;
        todate1.Value = todate123;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds);
        con.Close();

        string imageid = string.Empty;
        string EmailID11 = string.Empty;
        string categoryname = string.Empty;
        string tagname = string.Empty;
        byte[] photo;
        string date = string.Empty;


        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {

            imageid = ds.Tables[0].Rows[i][0].ToString();
            EmailID11 = ds.Tables[0].Rows[i][1].ToString();
            categoryname = ds.Tables[0].Rows[i][2].ToString();
            tagname = ds.Tables[0].Rows[i][3].ToString();
            photo = (byte[])ds.Tables[0].Rows[i][4];
            date = ds.Tables[0].Rows[i][5].ToString();
          DateTime  date11 = Convert.ToDateTime(date);

            con.Open();


            SqlCommand cmd1 = new SqlCommand("sp_InsertArchiveDetails", con);
            cmd1.CommandText = "sp_InsertArchiveDetails";
            cmd1.CommandType = CommandType.StoredProcedure;
            SqlParameter imageid1 = cmd1.Parameters.Add("@imageid", SqlDbType.VarChar, 100);
            SqlParameter EmailID111 = cmd1.Parameters.Add("@EmailID", SqlDbType.VarChar,100);
            SqlParameter categoryname1 = cmd1.Parameters.Add("@categoryname", SqlDbType.VarChar,100);
            SqlParameter tagname1 = cmd1.Parameters.Add("@tagname", SqlDbType.VarChar, 100);
            SqlParameter photo1 = cmd1.Parameters.Add("@photo", SqlDbType.Image);
            SqlParameter date1 = cmd1.Parameters.Add("@date", SqlDbType.DateTime);
            imageid1.Value = imageid;
            EmailID111.Value = EmailID11;
            categoryname1.Value = categoryname;
            tagname1.Value = tagname;
            photo1.Value = photo;
            date1.Value = date11;
            int result11 = cmd1.ExecuteNonQuery();

            con.Close();
        }
            
        
                   
    }
}