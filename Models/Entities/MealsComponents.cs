using System;
using System.Collections.Generic;

namespace meal_assistant_dotnet_mvc.Models.Entities
{
    public partial class MealsComponents
    {
        public int Id { get; set; }
        public int? MealId { get; set; }
        public int? ComponentId { get; set; }
    }
}
