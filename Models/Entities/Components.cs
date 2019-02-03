using System;
using System.Collections.Generic;

namespace meal_assistant_dotnet_mvc.Models.Entities
{
    public partial class Components
    {
        public Components()
        {
            ComponentTags = new HashSet<ComponentTags>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Comments { get; set; }
        public string Type { get; set; }
        public int? UserId { get; set; }
        public int? Rating { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<ComponentTags> ComponentTags { get; set; }
    }
}
