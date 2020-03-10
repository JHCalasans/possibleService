
using System;
using System.Runtime.Serialization;

namespace PossibleService.Contracts
{
    [DataContract]
    public class Assignment
    {

        int _assignmentID;
        string _title;
        String _color;
        int _itemID;
        String _dateString;

        [DataMember]
        public int AssignmentID 
        {
            get { return _assignmentID; }
            set { _assignmentID = value; }
        }

        [DataMember]
        public string Title 
        {
            get { return _title; }
            set { _title = value; }
        }


        [DataMember]
        public String Color
        {
            get { return _color; }
            set { _color = value; }
        }

        [DataMember]
        public int ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }

        [DataMember]
        public String DateString
        {
            get { return _dateString; }
            set { _dateString = value; }
        }

        public Assignment(Assignment assignment)
        {
            AssignmentIndex++;
            AssignmentID = AssignmentIndex;
            Title = assignment.Title;
            Color = assignment.Color;
            ItemID = assignment.ItemID;
            DateString = assignment.DateString;

        }

        public static int AssignmentIndex { get; set; }
    }
}
