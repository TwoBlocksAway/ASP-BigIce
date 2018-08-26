using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IceBox.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string Name { get; set; }

        [ForeignKey("FoodGroup")]
        public int FoodGroupId { get; set; }

        public FoodGroup FoodGroup { get; set; }
    }
}
