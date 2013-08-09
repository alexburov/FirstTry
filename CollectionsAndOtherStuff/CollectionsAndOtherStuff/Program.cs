using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionsAndOtherStuff
{
  class Program
  {
    static void Main(string[] args)
    {


      #region Private Fields
      

      Automobile a1 = new Automobile();
      a1.Make = "Dodge";
      a1.Model = "Dart";
      a1.Year = 1976;
      a1.ExteriorColor = "Green";
      a1.Miles = 111001;

      Book b1 = new Book();
      b1.Autor = "Robert Tabor";
      b1.Title = "Microsoft .NET XML Web Services";
      b1.ISBN = "0-672-32088-6";

      #endregion

      Print.ToConsole(a1);
      Print.ToConsole(b1);


      Console.ReadLine();


      Console.WriteLine("");
      Console.WriteLine("Where is our oldest product located ?");

      Warehouse myWareHouse = new Warehouse();
      myWareHouse.Add(a1);
      myWareHouse.Add(b1);

      var myOldestProduct = myWareHouse.GetOldestItem();

      myOldestProduct.GetStorageLocation();

      Console.ReadLine();

      Console.WriteLine();

      Console.WriteLine("Adding ...");
      Toy newToy = new Toy() { Manufacturer = "Kenner", Name = "Luke Skywalker", Type = "Doll" };

      myWareHouse.Add(newToy);
      var myNewestProduct = myWareHouse.GetNewestItem();
      myNewestProduct.GetStorageLocation();
      Console.ReadLine();


    }
  }
}
