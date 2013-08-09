using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRUNGsSpyAnalysisApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Personnel myPers = new Personnel("Alex", "Ukraine", "C# developer", "San-Francisco", "Oleg Burov");
      myPers.Print();
      Console.ReadLine();

    }
  }
}
