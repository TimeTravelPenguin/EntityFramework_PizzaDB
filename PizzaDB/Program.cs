#region Title Header

// Name: Phillip Smith
// 
// Solution: PizzaDB
// Project: PizzaDB
// File Name: Program.cs
// 
// Current Data:
// 2021-04-05 12:42 AM
// 
// Creation Date:
// 2021-04-04 4:31 PM

#endregion

using System;
using System.Linq;

namespace PizzaDB
{
  public static class Program
  {
    public static void Main(string[] args)
    {
      var ctx = new PizzaContext();
      foreach (var addr in ctx.Addresses.ToList())
      {
        Console.WriteLine(addr.State);
      }
    }
  }
}