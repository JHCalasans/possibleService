using PossibleService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using static PossibleService.Service1;

namespace PossibleService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IService1
    {

        //[OperationContract]
        //[WebInvoke(Method = "GET",UriTemplate = "/GetDatas", RequestFormat =WebMessageFormat.Json,
        //    ResponseFormat =WebMessageFormat.Json,BodyStyle =WebMessageBodyStyle.Wrapped)]
        //string GetDatas();

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SaveUser", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        User SaveUser(User user);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Login", RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        User Login(User user);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SaveItem", RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json)]
        Item SaveItem(Item item);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetAssignmentsByUser/{userID}", RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        List<ListObject> GetAssignmentsByUser(string userID);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetItensByUser/{userID}", RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json)]
        List<Item> GetItensByUser(string userID);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/SaveAssignment", RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json)]
        Assignment SaveAssignment(Assignment assignment);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/GetAssignmentsByItem", RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        List<Assignment> GetAssignmentsByItem(List<Item> itens);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/RemoveItem/{itemID}", RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        void RemoveItem(string itemID);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/RemoveAssignment/{assignmentID}", RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json)]
        void RemoveAssignment(string assignmentID);


    }


    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
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
