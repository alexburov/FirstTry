using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace GlobalSpyAnalysisApplication
{
  class Program
  {
    private Interface Interface = new Interface();

    static void Main(string[] args)
    {
      Interface myint = new Interface();
      myint.Menu();
    }
  }
}
