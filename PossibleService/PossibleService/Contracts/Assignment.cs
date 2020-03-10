
using System;
using System.Runtime.Serialization;

namespace PossibleService.Models
{
    [DataContract]
    public class Assignment
    {

        int _assignmentID;
        string _title;
        DateTime _date;
        String _color;
        int _itemID;

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
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
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

        public String DateString 
        { 
            get { return Date.ToString("MM/dd/yyyy"); }
        }

        public Assignment(Assignment assignment)
        {
            AssignmentIndex++;
            AssignmentID = AssignmentIndex;
            Title = assignment.Title;
            Date = assignment.Date;
            Color = assignment.Color;
            ItemID = assignment.ItemID;

        }

        public static int AssignmentIndex { get; set; }
    }
}
