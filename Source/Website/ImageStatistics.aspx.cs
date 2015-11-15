using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.DataVisualization.Charting;
using System.Drawing;  
public partial class ImageStatistics : System.Web.UI.Page
{
    ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
    SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bindchart();

        }    
    }

    private void Bindchart()
    {
        string EmailID = Convert.ToString("emailid");

        con.Open();
        SqlCommand cmd = new SqlCommand("sp_ImageStatistics", con);
        cmd.CommandText = "sp_ImageStatistics";
        cmd.CommandType = CommandType.StoredProcedure;
        //SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 100);
        //EmailID1.Value = EmailID;
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);

        DataTable ChartData = ds.Tables[0];

        //storing total rows count to loop on each Record  
        string[] XPointMember = new string[ChartData.Rows.Count];
        int[] YPointMember = new int[ChartData.Rows.Count];

        for (int count = 0; count < ChartData.Rows.Count; count++)
        {
            //storing Values for X axis  
            XPointMember[count] = ChartData.Rows[count]["categoryname"].ToString();
            //storing values for Y Axis  
            YPointMember[count] = Convert.ToInt32(ChartData.Rows[count]["count"]);

        }
        //binding chart control  
        Chart1.Series[0].Points.DataBindXY(XPointMember, YPointMember);

        //Setting width of line  
        Chart1.Series[0].BorderWidth = 10;
        //setting Chart type   
        Chart1.Series[0].ChartType = SeriesChartType.Pie;


        foreach (Series charts in Chart1.Series)
        {
            foreach (DataPoint point in charts.Points)
            {
                switch (point.AxisLabel)
                {
                    case "Logos": point.Color = Color.RoyalBlue; break;
                    case "Fitness": point.Color = Color.SaddleBrown; break;
                    case "Marrige": point.Color = Color.SpringGreen; break;
                    case "School": point.Color = Color.AliceBlue; break;
                    case "Company": point.Color = Color.Aqua; break;
                    case "cellphones": point.Color = Color.Beige; break;
                    case "Clothes": point.Color = Color.Bisque; break;
                    case "Shoes": point.Color = Color.BlanchedAlmond; break;
                    case "Birthday": point.Color = Color.BlueViolet; break;
                    case "Tourism": point.Color = Color.Brown; break;
                    case "Atmosphere": point.Color = Color.BurlyWood; break;
                    case "Vehicle": point.Color = Color.CadetBlue; break;
                    case "House": point.Color = Color.Chocolate; break;
                    case "Electronics": point.Color = Color.Cornsilk; break;
                    case "Jewelry": point.Color = Color.DarkGoldenrod; break;
                    case "Books": point.Color = Color.DarkKhaki; break;
                    case "Sports": point.Color = Color.DarkOrchid; break;
                    case "Furniture": point.Color = Color.DeepPink; break;
                 

                }
                point.Label = string.Format("{0:0} - {1}", point.YValues[0], point.AxisLabel);

            }
        }


        //Enabled 3D  
        Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;  
        con.Close();

    }  
}