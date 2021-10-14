using System;

namespace ApiTestFramework.Models.Users
{
    public class UserViewModel
    {
        public NameViewModel Name { get; set; }
        public Uri Photo { get; set; }
        public bool IsAdmin { get; set; }
        public bool Deleted { get; set; }
        public bool _id { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Email { get; set; }
        public string Ip{ get; set; }
        public int? __v { get; set; }
        public string? Phone { get; set; }
    }
}
