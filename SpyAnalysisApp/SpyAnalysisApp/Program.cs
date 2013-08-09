using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyAnalysisApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Personnel myPers = new Personnel("Alex", "Ukraine", "C# developer", "San-Francisco", "Oleg Burov");
      Agent myAgent = new Agent();
      myAgent.CodeName = "Lol";
      myAgent.Region = "Russia";
      myAgent.SkillSet = "Drinkin...";
      myAgent.Print();
      myPers.Print();



      Analyze.Analyzer(myPers);



      Console.ReadLine();
    }
  }
}
