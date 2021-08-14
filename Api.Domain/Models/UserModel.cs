using System;
namespace Api.Domain.Models
{
    public class UserModel : BaseModel
    {
        private string _userName { get; set; }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private bool _active;
        public bool Active 
        {
            get { return _active; }
            set { _active = value; }
        }

        private string _userType;
        public string UserType
        {
            get { return _userType; }
            set { _userType = value; }
        }        
    }
}
