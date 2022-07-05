using System;
using System.Diagnostics;
using System.Numerics;

public class Program
{
     public static BigInteger N;
     public static void Main()
     {
         N = 200000;
         Console.WriteLine($"The input is {N}, the output is {Fibonacci(N)} The elapsed time for the execution is {GetTimeLapse():N3} ms");

     }


     public static BigInteger Fibonacci(BigInteger n)
     {
         BigInteger previousValue = -1;
         BigInteger currentResult = 1;

         for (var i = 0; i <= n; ++i)
         {
             BigInteger sum = currentResult + previousValue;
             previousValue = currentResult;
             currentResult = sum;
         }

         return currentResult;
     }

     public static float GetTimeLapse()
     {
         var watch = Stopwatch.StartNew();
         RunMethod(Fibonacci);
         watch.Stop();
         float timelapse = (float)watch.Elapsed.TotalMilliseconds;
         return timelapse;
     }

     public static bool RunMethod(Func<BigInteger, BigInteger> Fibonaci)
     {
         try
         {
             Fibonaci(N);
         }
         catch (Exception)
         {
             return false;
             throw;
         }

         return true;
     }
}
