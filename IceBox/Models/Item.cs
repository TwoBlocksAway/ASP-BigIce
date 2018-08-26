using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IceBox.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public decimal Quantity { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime CreatedAt { get; set; }

        [ForeignKey("Ingredient")]
        public int? IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }
    }
}
