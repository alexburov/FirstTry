using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndOtherStuff
{
  class Book : IPrintable, IProduct
  {
    public string Title { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }

    public void Print()
    {
      Console.WriteLine("\"{0}\", {1}, (ISBN: {2})", Title, Autor, ISBN);
    }

    public void GetStorageLocation()
    {
      Console.WriteLine("The title \"{0}\" is stored in Warehouse B");
    }
  }
}
