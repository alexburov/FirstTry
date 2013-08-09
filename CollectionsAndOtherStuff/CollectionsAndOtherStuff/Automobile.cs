using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndOtherStuff
{
  class Automobile : IPrintable, IProduct
  {
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Miles { get; set; }
    public string ExteriorColor { get; set; }


    public void Print()
    {
      Console.WriteLine("{0} {1} {2} with {3} exterior (Odometer: {4})", Year, Make, Model, ExteriorColor, Miles);
    }

    public void GetStorageLocation()
    {
      Console.Write("The {0} {1} {2} is stored in warehouse A", Year, Make, Model);
    }
  }
}
