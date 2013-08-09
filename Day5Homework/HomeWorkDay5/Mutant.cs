using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDay5
{
   abstract class Mutant : IDisplayable
  {
     public string CodeName { get; set; }
     public int Level { get; set; }




     public abstract int DangerQuotient();



     public void DisplayInfo()
     {
       Console.WriteLine("{0} - DQ:{1}", CodeName, DangerQuotient());
       
     }
  }
}
