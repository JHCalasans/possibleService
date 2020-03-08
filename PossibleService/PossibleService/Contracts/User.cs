using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PossibleService.Contracts
{
    [DataContract]
    public class User
    {
        String _name;
        String _password;

        [DataMember]
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [DataMember]
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
    }
}