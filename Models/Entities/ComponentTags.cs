using System;
using System.Collections.Generic;

namespace meal_assistant_dotnet_mvc.Models.Entities
{
    public partial class ComponentTags
    {
        public int Id { get; set; }
        public int? ComponentId { get; set; }
        public int? TagId { get; set; }

        public virtual Components Component { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
