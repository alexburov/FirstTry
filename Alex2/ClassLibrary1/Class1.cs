using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
      private static string RemoveWideSpaces(string expression)
      {
        return expression.Replace(" ", "");
      }

      public static string Parse(string userString)
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

      private static int Summ(int x, int y)
        {
          return x + y;
        }

      private static int Residual(int x, int y)
      {
        return x - y;
      }

      private static int Multiply(int x, int y)
      {
        return x * y;
      }

      private static int Devide(int x, int y)
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
    }
}
