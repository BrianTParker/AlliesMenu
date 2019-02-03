using System;
using System.Collections.Generic;

namespace meal_assistant_dotnet_mvc.Models.Entities
{
    public partial class Tags
    {
        public Tags()
        {
            ComponentTags = new HashSet<ComponentTags>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; }

        public virtual ICollection<ComponentTags> ComponentTags { get; set; }
    }
}
