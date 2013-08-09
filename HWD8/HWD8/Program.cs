using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace HWD8
{
  internal class Program
  {


    private static void IncByCountry()
    {
      Console.WriteLine("Insert the country name <ex. US> :");
      string countryName = Console.ReadLine();



      SqlConnection connection = new SqlConnection(@"Data Source=LT-OBU-5D79HV1\SQLEXPRESS;User ID=sa;Password=12345;Database=FifthColumn");
      connection.Open();


      SqlCommand command = connection.CreateCommand();

      command.CommandText = "exec GetIncedentsByCountry " + countryName;
      command.CommandType = CommandType.Text;


      SqlDataReader reader;
      reader = command.ExecuteReader();

      while (reader.Read())
      {
        Console.WriteLine("Agent: {0} {1} - Investigated:{2}", reader[3].ToString(), reader[4].ToString(), reader[2].ToString());
      }
      connection.Close();
      Console.ReadLine();


    }

    private static void ReportIncedent()
    {
      SqlConnection connection = new SqlConnection(@"Data Source=LT-OBU-5D79HV1\SQLEXPRESS;User ID=sa;Password=12345;Database=FifthColumn");
      connection.Open();

      SqlCommand command = connection.CreateCommand();


      //@agentID, @country, @incidentType, @dateTime

      Console.WriteLine("AgentID <1-100>:");
      string agentId = Console.ReadLine();
      Console.WriteLine("Enter the country <ex. US>:");
      string country = Console.ReadLine();
      Console.WriteLine("IncidentId <1-4>:");
      string incidentId = Console.ReadLine();
      command.CommandText = "InsertIncident";
      command.CommandType = CommandType.StoredProcedure;
      command.Parameters.Add(new SqlParameter("@agentID", Int32.Parse(agentId)));
      command.Parameters.Add(new SqlParameter("@country", country));
      command.Parameters.Add(new SqlParameter("@incidentType", byte.Parse(incidentId)));
      command.Parameters.Add(new SqlParameter("@dateTime", DateTime.Now));

      Console.WriteLine("Successfully added!");
      connection.Close();
      Program.Menu();
    }

    private static void Menu()
    {
      Console.WriteLine("Menu");
      Console.WriteLine("------------------------------");
      Console.WriteLine("1 - Incidents By Country");
      Console.WriteLine("2 - Report Incident");
      Console.WriteLine("3 - EXIT");
      Console.WriteLine("------------------------------");


      switch (Console.ReadLine())
      {
        case "1":
          Program.IncByCountry();
          break;
        case "2":
          Program.ReportIncedent();
          break;
      }
    }

    private static void Main(string[] args)
    {
      Program.Menu();
    }
  }
}
