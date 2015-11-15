using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
namespace ImageRepositoryAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        DataSet GetDetails(string EmailID);

        [OperationContract]
        DataSet GetEmailID();

         [OperationContract]
       int InserRegisterDetails(string EmailID,string Password, string firsttime);

         [OperationContract]
       int UpdatePassword(string EmailID, string newpassword,string firsttime);

         [OperationContract]
       DataSet GetForgotDetails(string EmailID);

         [OperationContract]
         SortedDictionary<int, string> GetCategory();

          [OperationContract]
       int InsertImageDetails(string EmailID,string categoryname,string tagname,byte[] raw, DateTime date);

          [OperationContract]
       int UpdateCategory(string categoryname11);

         [OperationContract]
          SortedList<int, string> GetUserCategory(string EmailID);

         [OperationContract]
         SortedList<int, string> GetUserTagNames(string EmailID);

          [OperationContract]
       DataSet GetCategoryImageDetails(string EmailID,string name);

          [OperationContract]
          DataSet GetTagNameImageDetails(string EmailID, string name);

        [OperationContract]
       int DeleteImageDetails(int imageid);

        [OperationContract]
        int ArchiveImageDetails(string EmailID, DateTime fromdate, DateTime todate);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
