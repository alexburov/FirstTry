using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace GlobalSpyAnalysisApplication
{
  internal class Interface
  {
    public static _Spy_s_DatabaseDataSetTableAdapters.AgenciesTableAdapter ata =
      new _Spy_s_DatabaseDataSetTableAdapters.AgenciesTableAdapter();

    public static _Spy_s_DatabaseDataSet dt = new _Spy_s_DatabaseDataSet();
    






    public void Menu()
    {
      Console.WriteLine("GLOBAL SPY ANALYSIS APPLICATION");
      Console.WriteLine("--------------------------------");
      Console.WriteLine("1 - Add a new agency to database");
      Console.WriteLine("2 - Add a new SPY to database");
      Console.WriteLine("3 - View the database");
      Console.WriteLine("--------------------------------");


      switch (Console.ReadLine())
      {
        case "1":
        case "2":
        case "3":
        default:
      }


    }

    public void AddASpy()
    {
      
    }


    public void AddAnAgency()
    {
    }


  }


}
