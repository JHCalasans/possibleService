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
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetDatas()
        {
            return string.Format("You entered rompt");
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

        public User GetUsers()
        {
           // User user = new User() { Name = "João", Password = "teste" };
            return null;
        }
        public  User SaveUser(User user)
        {
            User newUser = new User(user);
            if (Users == null)
                Users = new List<User>();

            Users.Add(newUser);
            return newUser;
        }
    }
}
