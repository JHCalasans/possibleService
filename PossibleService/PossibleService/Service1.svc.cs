using PossibleService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PossibleService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1 : IService1
    {

        private static List<User> Users { get; set; }
        private static List<Item> Itens { get; set; }
        private static List<Assignment> Assignments { get; set; }

        public User Login(User user)
        {
            if (Users != null)
            {
                return Users.Find(usr => usr.Name.Equals(user.Name) && usr.Password.Equals(user.Password));
            }
            else
                return null;
        }
        public User SaveUser(User user)
        {
            User newUser = new User(user);
            if (Users == null)
                Users = new List<User>();

            Users.Add(newUser);
            return newUser;
        }

        public Item SaveItem(Item item)
        {
            Item newItem = new Item(item);
            if (Itens == null)
                Itens = new List<Item>();

            Itens.Add(newItem);
            return newItem;
        }

        public List<ListObject> GetAssignmentsByUser(string userID)
        {
            if (Itens == null)
                return null;
            else
            {
                List<Item> newItens = Itens.FindAll(it => it.UserID == Int32.Parse(userID));
                List<ListObject> ListReturn = new List<ListObject>();
                ListObject obj;
                if (newItens != null && newItens.Count > 0)
                {
                    foreach (Item element in newItens)
                    {
                        obj = new ListObject() { ItemDescription = element.Description, ItemID = element.ItemID };
                        if (Assignments != null)
                        {
                            List<Assignment> ListAssignments = Assignments.FindAll(assi => assi.ItemID == element.ItemID);
                            foreach (Assignment assi in ListAssignments)
                            {
                                obj.Add(assi);
                            }
                        }
                        ListReturn.Add(obj);
                    }
                }
                return ListReturn;
            }
        }

        public List<Item> GetItensByUser(string userID)
        {

            if (Itens == null)
                return null;
            else
                return Itens.FindAll(it => it.UserID == Int32.Parse(userID));

        }

        public Assignment SaveAssignment(Assignment assignment)
        {
            Assignment newAssignment = new Assignment(assignment);
            if (Assignments == null)
                Assignments = new List<Assignment>();

            Assignments.Add(newAssignment);
            return newAssignment;
        }

        public class ListObject : List<Assignment>
        {
            public List<Assignment> Assignments { get; set; }

            public String ItemDescription { get; set; }

            public int ItemID { get; set; }


        }
    }
}
