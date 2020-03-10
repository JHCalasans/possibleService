

using System.Runtime.Serialization;

namespace Possible.Models
{
    [DataContract]
    public class Item
    {

        int _itemID;
        string _description;
        int _userID;

        [DataMember]
        public int ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }

        [DataMember]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        [DataMember]
        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }


        public Item(Item item)
        {
            ItemIndex++;
            ItemID = ItemIndex;
            Description = item.Description;
            UserID = item.UserID;

        }
        public static int ItemIndex { get; set; }

    }
}
