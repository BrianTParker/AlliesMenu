using System;
using System.Collections.Generic;
using System.Net;

namespace meal_assistant_dotnet_mvc.Models.Entities
{
    public partial class Users
    {
        public Users()
        {
            Components = new HashSet<Components>();
            Feedbacks = new HashSet<Feedbacks>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Token { get; set; }
        public string EncryptedPassword { get; set; }
        public string ResetPasswordToken { get; set; }
        public DateTime? ResetPasswordSentAt { get; set; }
        public DateTime? RememberCreatedAt { get; set; }
        public int SignInCount { get; set; }
        public DateTime? CurrentSignInAt { get; set; }
        public DateTime? LastSignInAt { get; set; }
        public IPAddress CurrentSignInIp { get; set; }
        public IPAddress LastSignInIp { get; set; }
        public string Provider { get; set; }
        public string Uid { get; set; }

        public virtual ICollection<Components> Components { get; set; }
        public virtual ICollection<Feedbacks> Feedbacks { get; set; }
    }
}
