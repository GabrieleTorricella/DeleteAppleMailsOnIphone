using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace DeleteAppleMailsOnIphone
{
    public class UserInfo
    {
        #region Variables
        string _name, _surname, _mail, _password;
        int _id;
        #endregion
        #region Properties
        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Mail { get => _mail; set => _mail = value; }
        public string Password { get => _password; set => _password = value; }
        public int Id { get => _id; set => _id = value; }
        #endregion
        #region Constructor
        public UserInfo()
        {

        }
        public UserInfo(string mail, string password) : this()
        {
            Mail = mail;
            Password = password;
        }
        #endregion
        #region Methods
        #endregion
    }
}