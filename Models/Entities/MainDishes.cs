using System;
using System.Collections.Generic;

namespace meal_assistant_dotnet_mvc.Models.Entities
{
    public partial class MainDishes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Comments { get; set; }
        public int? MealId { get; set; }

        public virtual Meals Meal { get; set; }
    }
}
