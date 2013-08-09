using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyAnalysisApp
{
  class Personnel : Asset
  {
    public string Department { get; set; }

    public string SuperVisor { get; set; }




    public Personnel(string TheCodeName, string TheRegion, string TheSkillSet, string TheDepartment, string TheSuperVisor)
    {
      CodeName = TheCodeName;
      Region = TheRegion;
      SkillSet = TheSkillSet;
      Department = TheDepartment;
      SuperVisor = TheSuperVisor;
    }
  }
}
