using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;

namespace Day6
{
  class Program
  {
    static void Main(string[] args)
    {
      //Step 1: Handshake with a database
      SqlCeConnection myConnection = new SqlCeConnection("Data Source=Database1.sdf");

      myConnection.Open();

      //Step 2: Specify a command (request)
      SqlCeCommand myCommand = myConnection.CreateCommand();

      myCommand.CommandText = "Customers";
      myCommand.CommandType = System.Data.CommandType.TableDirect;



      SqlCeDataReader myDataReader;
      myDataReader = myCommand.ExecuteReader();



      //Step 3 : Use the data


      while (myDataReader.Read())
      {
        Console.WriteLine(myDataReader[0].ToString() + myDataReader[1] + " " + myDataReader[2]);
      }
      myConnection.Close();


      Console.ReadLine();



    }
  }
}
