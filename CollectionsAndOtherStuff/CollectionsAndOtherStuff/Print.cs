using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndOtherStuff
{
  static class Print
  {
    public static void ToConsole(IPrintable printableObject)
    {
      printableObject.Print();
    }
  }
}
