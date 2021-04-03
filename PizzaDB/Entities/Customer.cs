using System.ComponentModel.DataAnnotations;

namespace PizzaDB.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}