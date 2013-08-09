using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDay5
{
  class PhysicalMutant : Mutant, IDisplayable
  {
    public int IQ { get; set; }
    public int Strength { get; set; }



    public override int DangerQuotient()
    {
      return IQ * Strength * Level;
    }
  }
}
