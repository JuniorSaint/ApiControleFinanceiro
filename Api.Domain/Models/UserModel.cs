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

        private string _passWord;
        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
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
