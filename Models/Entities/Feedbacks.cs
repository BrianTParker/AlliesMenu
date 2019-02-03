using System;
using System.Collections.Generic;

namespace meal_assistant_dotnet_mvc.Models.Entities
{
    public partial class Feedbacks
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Users User { get; set; }
    }
}
