using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRUNGsSpyAnalysisApplication
{
  class Asset
  {
    private string codeName;

    private string region;

    private string skillSet;


    public string CodeName
    {
      get
      {
        return codeName;
      }
      set
      {
        codeName = value;
      }
    }
    
    public string Region
    {
      get
      {
        return region;
      }
      set
      {
        region = value;
      }
    }

    public string SkillSet
    {
      get
      {
        return skillSet;
      }
     set
     {
       skillSet = value;
     }
    }



    public void Print()
    {
      Console.WriteLine(CodeName + Region + SkillSet);
    }
  }
}
