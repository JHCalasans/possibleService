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
        int _userID;

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

        [DataMember]
        public int UserID 
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public User(User user)
        {
            UserIndex++;
            UserID = UserIndex;
            Password = user.Password;
            Name = user.Name;
            
        }

        public static int UserIndex { get; set; }

        
    }
}