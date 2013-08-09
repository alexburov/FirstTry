using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDay5
{
  internal class ElementalMutant : Mutant, IDisplayable
  {
    public int Region { get; set; }







    public override int DangerQuotient()
    {
      return Level * Region;
    }
  }
}
