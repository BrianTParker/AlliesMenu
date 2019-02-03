using System;
using System.Collections.Generic;

namespace meal_assistant_dotnet_mvc.Models.Entities
{
    public partial class MealTimes
    {
        public MealTimes()
        {
            Meals = new HashSet<Meals>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Meals> Meals { get; set; }
    }
}
