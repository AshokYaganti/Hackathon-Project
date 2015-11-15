using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace ImageRepositoryAPI
{
    
    public class Service1 : IService1
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["myconnectionstring"].ConnectionString);

        public DataSet GetDetails(string EmailID)
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_GetDetails", con);
            cmd.CommandText = "sp_GetDetails";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 100);
            EmailID1.Value = EmailID;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();

            return ds;
        }

        public DataSet GetEmailID()
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_GetEmailID", con);
            cmd.CommandText = "sp_GetEmailID";
            cmd.CommandType = CommandType.StoredProcedure;
         
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();

            return ds;
        }

        public int InserRegisterDetails(string EmailID, string Password, string firsttime)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_RegisterDetails", con);
            cmd.CommandText = "sp_RegisterDetails";
            cmd.CommandType = CommandType.StoredProcedure;
           
            SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 100);
            SqlParameter Password1 = cmd.Parameters.Add("@Password", SqlDbType.VarChar, 100);
            SqlParameter firsttime1 = cmd.Parameters.Add("@firsttime", SqlDbType.VarChar, 100);

            EmailID1.Value = EmailID;
            Password1.Value = Password;
            firsttime1.Value = firsttime;
           
            int result= cmd.ExecuteNonQuery();
          
            con.Close();
            return result;
        }

        public int UpdatePassword(string EmailID, string newpassword, string firsttime)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("sp_UpdatePassword", con);
            cmd.CommandText = "sp_UpdatePassword";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 100);
            SqlParameter Password1 = cmd.Parameters.Add("@NewPassword", SqlDbType.VarChar, 100);
            SqlParameter firsttime1 = cmd.Parameters.Add("@firsttime", SqlDbType.VarChar, 100);

            EmailID1.Value = EmailID;
            Password1.Value = newpassword;
            firsttime1.Value = firsttime;

            int result = cmd.ExecuteNonQuery();

            con.Close();
            return result;

        }

     public DataSet GetForgotDetails(string EmailID)
        {
            DataSet ds = new DataSet();
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_GetForgotDetails", con);
            cmd.CommandText = "sp_GetForgotDetails";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 100);
            EmailID1.Value = EmailID;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            con.Close();

            return ds;
        }

     public SortedDictionary<int, string> GetCategory()
     {
         SortedDictionary<int, string> sl = new SortedDictionary<int, string>();
         con.Open();
         SqlCommand cmd = new SqlCommand("sp_GetCategory", con);
         cmd.CommandText = "sp_GetCategory";
         cmd.CommandType = CommandType.StoredProcedure;

         SqlDataReader reader = cmd.ExecuteReader();
         int i=0;
         while(reader.Read())
         {
             string categoryname = Convert.ToString(reader[0]);
             sl.Add(i,categoryname);
             i++;
         }
    
         con.Close();

         return sl;
     }

   public  int InsertImageDetails(string EmailID, string categoryname, string tagname, byte[] raw, DateTime date)
     {
         con.Open();

         SqlCommand cmd = new SqlCommand("sp_InsertImageDetails", con);
         cmd.CommandText = "sp_InsertImageDetails";
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.Parameters.Add("@imageid", SqlDbType.Int).Direction = ParameterDirection.Output;
         cmd.Parameters.AddWithValue("@EmailID", EmailID);
         cmd.Parameters.AddWithValue("@categoryname", categoryname);
         cmd.Parameters.AddWithValue("@tagname", tagname);
         cmd.Parameters.AddWithValue("@photo", raw);
         cmd.Parameters.AddWithValue("@date", date);
         cmd.ExecuteNonQuery();
         string result = cmd.Parameters["@imageid"].Value.ToString();
         int result1 = Convert.ToInt32(result);
         con.Close();
         return result1;
     }

   public int UpdateCategory(string categoryname11)
   {

       con.Open();

       SqlCommand cmd = new SqlCommand("sp_UpdateCategory", con);
       cmd.CommandText = "sp_UpdateCategory";
       cmd.CommandType = CommandType.StoredProcedure;

       SqlParameter Categoryname = cmd.Parameters.Add("@Categoryname", SqlDbType.VarChar, 100);


       Categoryname.Value = categoryname11;
     

       int result = cmd.ExecuteNonQuery();

       con.Close();
       return result;
   }

   public SortedList<int, string> GetUserCategory(string EmailID)
   {
       SortedList<int, string> sl = new SortedList<int, string>();
       con.Open();
       SqlCommand cmd = new SqlCommand("sp_GetUserCategory", con);
       cmd.CommandText = "sp_GetUserCategory";
       cmd.CommandType = CommandType.StoredProcedure;
       SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 100);
       EmailID1.Value = EmailID;
       SqlDataReader reader = cmd.ExecuteReader();
       int i = 0;
       while (reader.Read())
       {
           string categoryname = Convert.ToString(reader[0]);
           sl.Add(i, categoryname);
           i++;
       }

       con.Close();

       return sl;
   }


 public  SortedList<int, string> GetUserTagNames(string EmailID)
   {
       SortedList<int, string> sl = new SortedList<int, string>();
       con.Open();
       SqlCommand cmd = new SqlCommand("sp_GetUserTagNames", con);
       cmd.CommandText = "sp_GetUserTagNames";
       cmd.CommandType = CommandType.StoredProcedure;
       SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 100);
       EmailID1.Value = EmailID;
       SqlDataReader reader = cmd.ExecuteReader();
       int i = 0;
       while (reader.Read())
       {
           string categoryname = Convert.ToString(reader[0]);
           sl.Add(i, categoryname);
           i++;
       }

       con.Close();

       return sl;
   }
 public DataSet GetCategoryImageDetails(string EmailID, string name)
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

     return ds;
 }

 public DataSet GetTagNameImageDetails(string EmailID, string name)
 {
     DataSet ds = new DataSet();
     con.Open();
     SqlCommand cmd = new SqlCommand("sp_GetTagNameImageDetails", con);
     cmd.CommandText = "sp_GetTagNameImageDetails";
     cmd.CommandType = CommandType.StoredProcedure;
     SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar, 100);
     SqlParameter name1 = cmd.Parameters.Add("@tagname", SqlDbType.VarChar, 100);
     EmailID1.Value = EmailID;
     name1.Value = name;

     SqlDataAdapter da = new SqlDataAdapter(cmd);
     da.Fill(ds);
     con.Close();

     return ds;
 }

 public int DeleteImageDetails(int imageid)
 {
     con.Open();

     SqlCommand cmd = new SqlCommand("sp_DeleteImageDetails", con);
     cmd.CommandText = "sp_DeleteImageDetails";
     cmd.CommandType = CommandType.StoredProcedure;

     SqlParameter imageid1 = cmd.Parameters.Add("@imageid", SqlDbType.Int);


     imageid1.Value = imageid;
    

     int result = cmd.ExecuteNonQuery();

     con.Close();
     return result;
 }

 public int ArchiveImageDetails(string EmailID, DateTime fromdate, DateTime todate)
 {
     con.Open();

     SqlCommand cmd = new SqlCommand("sp_ArchiveImageDetails", con);
     cmd.CommandText = "sp_ArchiveImageDetails";
     cmd.CommandType = CommandType.StoredProcedure;

     SqlParameter EmailID1 = cmd.Parameters.Add("@EmailID", SqlDbType.VarChar,100);
     SqlParameter fromdate1 = cmd.Parameters.Add("@fromdate", SqlDbType.DateTime);
     SqlParameter todate1 = cmd.Parameters.Add("@todate", SqlDbType.DateTime);
     
     EmailID1.Value = EmailID;
     fromdate1.Value = fromdate;
     todate1.Value = todate;

     int result = cmd.ExecuteNonQuery();

     con.Close();
     return result;
 }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
