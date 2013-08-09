using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Truck myTruck = new Truck();
      //myTruck.Model = "Toyota";
      //myTruck.Maker = "My Make";
      //myTruck.Color = "Blue";
      //myTruck.TowingCapacity = 100;
      //myTruck.Tow();
      //myTruck.Haul();
      myTruck.Start();
      myTruck.Maker = Make.GMC;
      Console.ReadLine();
    }
  }

}
