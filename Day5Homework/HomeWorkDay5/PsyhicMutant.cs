using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDay5
{
  class PsyhicMutant : Mutant, IDisplayable
  {

    public int IQ { get; set; }
    public int UsageCount { get; set; }







    public override int DangerQuotient()
    {
      return IQ * UsageCount * Level;
    }
  }
}
