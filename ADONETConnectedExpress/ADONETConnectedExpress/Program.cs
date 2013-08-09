using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace ADONETConnectedExpress
{
  class Program
  {
    static void Main(string[] args)
    {
      //Step 1:Handshake with the database
      SqlConnection myConnnection = new SqlConnection("Data Source=.\\SQLEXPRESS;User ID=sa;Password=12345;AttachDbFilename=C:\\Program Files\\Microsoft SQL Server\\MSSQL11.SQLEXPRESS\\MSSQL\\DATA\\Database1.mdf;Database=Database1");

      myConnnection.Open();



      //Step 2: Specify the command or request
      SqlCommand myCommand = myConnnection.CreateCommand();



      //myCommand.CommandText = "SELECT * FROM Customers";
      //myCommand.CommandType = System.Data.CommandType.Text;

      myCommand.CommandText = "SELECT * FROM Customers";
      myCommand.CommandType = System.Data.CommandType.Text;

      SqlDataReader myDataReader;
      myDataReader = myCommand.ExecuteReader();
      //Step3 : Use the data


      while (myDataReader.Read())
      {
        Console.WriteLine(myDataReader[1] + " " + myDataReader[2]);
      }

      myConnnection.Close();
      Console.ReadLine();


    }
  }
}
