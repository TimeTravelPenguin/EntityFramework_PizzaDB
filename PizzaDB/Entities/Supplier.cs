using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaDB.Entities
{
    public class Supplier
    {
        public int SupplierId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Ingredient> SuppliedIngredients { get; set; }
    }
}