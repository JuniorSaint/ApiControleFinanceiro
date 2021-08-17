using System;
using System.Text.Json.Serialization;

namespace Api.Domain.Dtos.User
{
    public class UserDtoCreateResult
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }        
        public bool Active { get; set; }
        public string UserType { get; set; }
        public DateTime CreatedAt { get; set; }

         [JsonIgnore]
        public string Password { get; set; }
    }
}
