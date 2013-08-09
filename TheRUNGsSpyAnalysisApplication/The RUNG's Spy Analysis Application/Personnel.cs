using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRUNGsSpyAnalysisApplication
{
  class Personnel : Asset
  {
    private string department;

    private string superVisor;

    public string Department
    {
      get
      {
        return department;
      }
      set
      {
        department = value;
      }
    }

    public string SuperVisor
    {
      get
      {
        return superVisor;
      }
      set
      {
        superVisor = value;
      }
    }



    public Personnel(string CodeName, string Region, string SkillSet, string Department, string SuperVisor)
    {
      CodeName = CodeName;
      Region = Region;
      SkillSet = SkillSet;
      Department = Department;
      SuperVisor = SuperVisor;
    }

  }
}
