using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeleteAppleMailsOnIphone.UserFolder
{
    public class UserMails
    {
        #region Variables
        string _mailTo, _subject, _content;
        UserInfo _parent;
        #endregion
        #region Properties
        public string MailTo { get => _mailTo; set => _mailTo = value; }
        public string Subject { get => _subject; set => _subject = value; }
        public string Content { get => _content; set => _content = value; }
        public UserInfo Parent { get => _parent; set => _parent = value; }
        #endregion
    }
}