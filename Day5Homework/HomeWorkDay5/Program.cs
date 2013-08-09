using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDay5
{
  class Program
  {
    static void Main(string[] args)
    {

      /*
      #region Mutants
      PsyhicMutant psychicMutantOne = new PsyhicMutant();
      psychicMutantOne.CodeName = "Osborn";
      psychicMutantOne.IQ = 90;
      psychicMutantOne.UsageCount = 10;
      psychicMutantOne.Level = 2;

      PsyhicMutant psyhicMutantTwo = new PsyhicMutant();
      psyhicMutantTwo.CodeName = "Legolas";
      psyhicMutantTwo.IQ = 77;
      psyhicMutantTwo.UsageCount = 12;
      psyhicMutantTwo.Level = 3;

      PhysicalMutant physMutantOne = new PhysicalMutant();
      physMutantOne.CodeName = "Mike Tyson";
      physMutantOne.IQ = 80;
      physMutantOne.Strength = 20;
      physMutantOne.Level = 4;

      PhysicalMutant physMutantTwo = new PhysicalMutant();
      physMutantTwo.CodeName = "Fedor Emeleyanenko";
      physMutantTwo.IQ = 120;
      physMutantTwo.Strength = 10;
      physMutantTwo.Level = 2;

      ElementalMutant elemMutantOne = new ElementalMutant();
      elemMutantOne.CodeName = "Alex Burov";
      elemMutantOne.Region = 5;
      elemMutantOne.Level = 5;

      ElementalMutant elemMutantTwo = new ElementalMutant();
      elemMutantTwo.CodeName = "Annet Katan";
      elemMutantTwo.Region = 9;
      elemMutantTwo.Level = 6;
      #endregion

      List<Mutant> listOfMutants = new List<Mutant>();
      listOfMutants.Add(psychicMutantOne);
      listOfMutants.Add(psyhicMutantTwo);
      listOfMutants.Add(physMutantOne);
      listOfMutants.Add(physMutantTwo);
      listOfMutants.Add(elemMutantOne);
      listOfMutants.Add(elemMutantTwo);
      */



      List<Mutant> listOfMutants = new List<Mutant>()
                                     {
                                       new PhysicalMutant {CodeName = "Mike Tyson", IQ = 80, Strength = 20, Level = 4}
                                     };






      foreach (Mutant mutant in listOfMutants)
      {
        mutant.DisplayInfo();
      }
      Console.ReadLine();
    }
  }
}
