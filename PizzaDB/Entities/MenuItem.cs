using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaDB.Entities
{
    public class MenuItem
    {
        public int Id { get; set; }

        [MaxLength(50)] public string Name { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }

        public double SellPrice { get; set; }
    }
}