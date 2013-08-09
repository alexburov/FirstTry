using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
  class Truck : Automobile
  {
    public int TowingCapacity;

    public int CargoCapacity;

    public void Tow()
    {
      Console.WriteLine("Now Towing ...");
    }
    public void Haul()
    {
      Console.WriteLine("Now Hauling...");
    }
    public override void Start()
    {
      base.Start();
      Console.WriteLine("Truck ignition sequence ...");
    }

  }
}
