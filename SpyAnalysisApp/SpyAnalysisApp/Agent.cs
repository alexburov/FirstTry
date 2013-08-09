using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyAnalysisApp
{
  class Agent : Asset
  {
    public override void Print()
    {
      Console.WriteLine(Region + " " + SkillSet + " " + CodeName);
    }
  }
}
