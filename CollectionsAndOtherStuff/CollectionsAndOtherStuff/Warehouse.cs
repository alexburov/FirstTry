using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndOtherStuff
{
  public class Warehouse
  {
    private Queue<IProduct> inventory { get; set; }

    public Warehouse()
    {
      inventory = new Queue<IProduct>();
    }

    public IProduct GetOldestItem()
    {
      IProduct oldestItem = inventory.First();

      return oldestItem;
    }

    public IProduct GetNewestItem()
    {
      IProduct newestItem = inventory.Last();

      return newestItem;
    }


    public void Add(IProduct productToAdd)
    {
      inventory.Enqueue(productToAdd);
    }

  }
}
