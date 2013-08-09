using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Alex2
{
  class Program
  {
    private static string RemoveWideSpaces(string expression)
    {
      return expression.Replace(" ", "");
    }

    private static string Parse(string userString)
    {
      userString = RemoveWideSpaces(userString);
      char[] charArray = { '+', '-', '*', '/' };

      string[] userStringSplited = userString.Split(charArray);

      int x = Convert.ToInt32(userStringSplited[0]);
      int y = Convert.ToInt32(userStringSplited[1]);

      int position = userString.IndexOfAny(charArray);

      string operationType = userString.Substring(position, position);
      string result = Convert.ToString(Calculate(x, y, operationType));

      return result;
    }

    static int Summ(int x, int y)
    {
      return x + y;
    }

    static int Residual(int x, int y)
    {
      return x - y;
    }

    static int Multiply(int x, int y)
    {
      return x * y;
    }

    static int Devide(int x, int y)
    {
      return x / y;
    }

    private static int Calculate(int x, int y, string operationType)
    {
      int result = 0;
      switch (operationType)
      {

        case "+":
          result = Summ(x, y);
          break;

        case "-":
          result = Residual(x, y);
          break;

        case "*":
          result = Multiply(x, y);
          break;

        case "/":
          result = Devide(x, y);
          break;
      }

      return result;
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Enter your operation:");
      string userString = Console.ReadLine();
      string result = Program.Parse(userString);
      Console.WriteLine(result);
      Console.ReadLine();
    }
  }
}
