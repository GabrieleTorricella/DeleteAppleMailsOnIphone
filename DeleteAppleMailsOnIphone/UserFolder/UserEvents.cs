using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace DeleteAppleMailsOnIphone.UserFolder
{
    public class UserEvents
    {
        #region Variables
        string _eventTitle;
        DateTime _startDate, _endDate;
        DateTime _creationDate;
        UserInfo _parent;
        #endregion
        #region Properties
        public string EventTitle { get => _eventTitle; set => _eventTitle = value; }
        public DateTime StartDate { get => _startDate; set => _startDate = value; }
        public DateTime EndDate { get => _endDate; set => _endDate = value; }
        public DateTime CreationDate { get => _creationDate; set => _creationDate = value; }
        public UserInfo Parent { get => _parent; set => _parent = value; }
        #endregion
    }
}