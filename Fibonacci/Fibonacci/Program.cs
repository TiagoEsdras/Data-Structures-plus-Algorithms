using System.Collections;

static int FindFibonacciIterative(int num)
{
    int[] arr = new int[num + 1];

    arr[0] = 0;
    arr[1] = 1;

    for (int i = 2; i <= num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }

    return arr[num];
}

Console.WriteLine("starting FindFibonacciIterative");
var timeStartingFibonacciIterative = DateTime.Now;
Console.WriteLine(FindFibonacciIterative(46));
Console.WriteLine("finishing FindFibonacciIterative. Time spent (seconds): {0}", (DateTime.Now - timeStartingFibonacciIterative).TotalSeconds);

static int FindFibonacciRecursive(int num)
{
    if (num == 0 || num == 1)
        return num;

    return FindFibonacciRecursive(num - 1) + FindFibonacciRecursive(num - 2);
}

Console.WriteLine("starting FindFibonacciRecursive");
var timeStartingFibonacciRecursive = DateTime.Now;
Console.WriteLine(FindFibonacciRecursive(46));
Console.WriteLine("finishing FindFibonacciRecursive. Time spent (seconds): {0}", (DateTime.Now - timeStartingFibonacciRecursive).TotalSeconds);

var fibonacciDynamic = new FibonacciMaster();
Console.WriteLine("starting FibonacciMaster");
var timeStartingFibonacciMaster = DateTime.Now;
Console.WriteLine(fibonacciDynamic.Fib(46));
Console.WriteLine("finishing FibonacciMaster. Time spent (seconds): {0}", (DateTime.Now - timeStartingFibonacciMaster).TotalSeconds);
internal class FibonacciMaster
{
    private readonly Hashtable cache = new();

    public int Fib(int n)
    {
        if (!cache.ContainsKey(n))
        {
            if (n < 2)
                return n;

            int fibValue = Fib(n - 1) + Fib(n - 2);
            cache.Add(n, fibValue);
            return fibValue;
        }
        return (int)cache[n];
    }
}