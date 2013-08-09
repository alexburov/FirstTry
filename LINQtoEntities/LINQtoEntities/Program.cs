using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQtoEntities
{
  class Program
  {
    static void Main(string[] args)
    {
      Database1Entities3 de = new Database1Entities3();

      var customers = from c in de.Customers
                      where c.Orders.Any(o => o.OrderAmount > 150)
                      select c;


      foreach (var c in customers)
      {
        Console.WriteLine(c.LastName + " Orders " + c.Orders.Count().ToString());



        foreach (var o in c.Orders)
        {
          Console.WriteLine(o.OrderDate.ToString() + " - " + o.OrderAmount.ToString());
        }
      }


      Console.ReadLine();





    }
  }
}
