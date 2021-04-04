using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaDB.Entities
{
  [Table("CustomerAddresses")]
  public class CustomerAddress
  {
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    public int AddressId { get; set; }
    public Address Address { get; set; }
  }
}