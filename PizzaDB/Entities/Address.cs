#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Address.cs
// 
// Current Data:
// 2021-04-05 9:46 AM
// 
// Creation Date:
// 2021-04-04 4:32 PM

#endregion

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaDB.Entities.Types;

namespace PizzaDB.Entities
{
  [Table("Addresses")]
  public class Address
  {
    public int AddressId { get; set; }

    [Required] [MaxLength(50)] public string StreetAddress { get; set; }

    [Required] [MaxLength(50)] public string Suburb { get; set; }

    [Required] [MaxLength(4)] public string PostCode { get; set; }

    public AddressState State { get; set; }
  }
}