using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndOtherStuff
{
  class Computers : IPrintable, IProduct
  {
    public void Print()
    {
      throw new NotImplementedException();
    }

    public void GetStorageLocation()
    {
      throw new NotImplementedException();
    }
  }
}
