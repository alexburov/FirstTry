using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alex1
{
  class Program
  {
    static int Pow(int x, int y)
    {
      int result = 1;

      if (y != 0)
      {
        result = x;

        for (int n = 1; n < y; n++)
        {
          result *= x;
        }
      }

      return result;
    }
 
    static void Main(string[] args)
    {
      Console.WriteLine("Enter your integer:");
      Int32 usersInteger = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Enter the pow:");
      Int32 usersPow = Convert.ToInt32(Console.ReadLine());
      Int32 result = Program.Pow(usersInteger, usersPow);     
      Console.WriteLine("The result is {0}", result);
      Console.ReadLine();
    }
 
  }
}
