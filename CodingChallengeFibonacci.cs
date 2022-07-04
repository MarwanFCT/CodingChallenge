using System;
using System.Diagnostics;
using System.Numerics;
					
public class Program
{
	
	public static void Main(string[] args)
    {
        BigInteger n = 100000;
        var watch = Stopwatch.StartNew();
        Console.WriteLine("The input is: " + n + " and the ouput (Fn) is: " + Fibonacci(n));
		watch.Stop();
		float timelapse = (float) watch.Elapsed.TotalMilliseconds;
        Console.WriteLine("Elapsed Time is {0} ms", timelapse.ToString("N3"));
    }
	
	public static BigInteger Fibonacci(BigInteger n)
	{
		
      BigInteger previousValue = -1;
      BigInteger currentResult = 1;
 
      for (var i = 0; i <= n; ++i)
      {
        var sum = currentResult + previousValue;
        previousValue = currentResult;
        currentResult = sum;
      }
		
      return currentResult;
	}
	
	
}