using System;

namespace Pow_x__n_
{
  class Program
  {
    static void Main(string[] args)
    {
      Solution s = new Solution();
      var answer = s.MyPow(1.00000, -2147483648);
      Console.Write(answer);
    }
  }

  public class Solution
  {
    public double MyPow(double x, long n)
    {
      // its a simple math
      // when n is negetive answer would be 1 / answer
      // n = -2 and x = 2 so answer 1/ 2^2 = 1/4 = .25
      // will solve the problem using divide and conquer
      // example x = 2 and n = 10, 2^10 = 2^5 * 2^5 = 2^2 * 2^2 * 2^1 .......  = 2^1 * 2^1 * 2^2 * 2^1 * .....
      // so we can solve this using subproblem or using recursion

      double Helper(double x, long n)
      {
        // base conditions
        // when n = 0, x^0 = 1
        if (n == 0) return 1;
        // when x = 0, 0^n = 0 always
        if (x == 0) return 0;

        double half = Helper(x, n / 2); // we are dividing the n into two half
        half = half * half; // when n = 10, x^5 * x^5 = x^10
        return n % 2 == 0 ? half : x * half; // when n is odd say 11, x^5 * x^5 * x = x^11
      }
      double answer = Helper(x, Math.Abs(n));
      return n > 0 ? answer : 1 / answer;
    }
  }
}
