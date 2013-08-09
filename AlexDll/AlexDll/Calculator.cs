using System;

namespace Calculator
{
  /// <summary>
  /// Responsible to calculate two numbers.
  /// </summary>
  public class Calculator
  {
    /// <summary>
    /// Parses the specified expression.
    /// </summary>
    /// <param name="expression">The expression.</param>
    /// <returns></returns>
    public static int Parse(string expression)
    {
      expression = RemoveWhiteSpaces(expression);
      
      char[] charArray = { '+', '-', '*', '/' };
      string[] userStringSplited = expression.Split(charArray);

      int x = Convert.ToInt32(userStringSplited[0]);
      int y = Convert.ToInt32(userStringSplited[1]);

      int position = expression.IndexOfAny(charArray);
      string operationType = expression.Substring(position, position);

      return Calculate(x, y, operationType);
    }

    /// <summary>
    /// Removes the white spaces.
    /// </summary>
    /// <param name="expression">The expression.</param>
    /// <returns></returns>
    private static string RemoveWhiteSpaces(string expression)
    {
      return expression.Replace(" ", string.Empty);
    }

    /// <summary>
    /// Adds the specified x.
    /// </summary>
    /// <param name="x">The x.</param>
    /// <param name="y">The y.</param>
    /// <returns></returns>
    private static int Add(int x, int y)
    {
      return x + y;
    }

    /// <summary>
    /// Subtracts the specified x.
    /// </summary>
    /// <param name="x">The x.</param>
    /// <param name="y">The y.</param>
    /// <returns></returns>
    private static int Subtract(int x, int y)
    {
      return x - y;
    }

    /// <summary>
    /// Multiplies the specified x.
    /// </summary>
    /// <param name="x">The x.</param>
    /// <param name="y">The y.</param>
    /// <returns></returns>
    private static int Multiply(int x, int y)
    {
      return x * y;
    }

    /// <summary>
    /// Divides the specified x.
    /// </summary>
    /// <param name="x">The x.</param>
    /// <param name="y">The y.</param>
    /// <returns></returns>
    private static int Divide(int x, int y)
    {
      return x / y;
    }

    /// <summary>
    /// Calculates the operand x and y.
    /// </summary>
    /// <param name="x">The operand x.</param>
    /// <param name="y">The operand y.</param>
    /// <param name="operationType">Type of the calculation operation.</param>
    /// <returns>The result of calculated operand x and y.</returns>
    private static int Calculate(int x, int y, string operationType)
    {
      int result = 0;
      switch (operationType)
      {
        case "+":
          result = Add(x, y);
          break;

        case "-":
          result = Subtract(x, y);
          break;

        case "*":
          result = Multiply(x, y);
          break;

        case "/":
          result = Divide(x, y);
          break;
      }

      return result;
    }
  }
}