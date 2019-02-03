using System;
using System.Collections.Generic;

namespace meal_assistant_dotnet_mvc.Models.Entities
{
    public partial class Meals
    {
        public Meals()
        {
            MainDishes = new HashSet<MainDishes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? StartTime { get; set; }
        public double? Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? UserId { get; set; }
        public int? MealTimeId { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual MealTimes MealTime { get; set; }
        public virtual ICollection<MainDishes> MainDishes { get; set; }
    }
}
