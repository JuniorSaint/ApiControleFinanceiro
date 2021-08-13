using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PassWord { get; set; }
        public bool Active { get; set; }
        public string  UserType{ get; set; }
    }
}
