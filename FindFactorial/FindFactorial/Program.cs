static int FindFactorialIterative(int num)
{
    var factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }

    return factorial;
}

Console.WriteLine(FindFactorialIterative(5));

static int FindFactorialRecursive(int num)
{
    //var factorial = num;
    //var count = num - 1;
    //if (count == 1)
    //    return factorial *= count;
    //return factorial * FindFactorialRecursive(count);
    if (num == 2)
        return 2;

    return num * FindFactorialRecursive(num - 1);
}

Console.WriteLine(FindFactorialRecursive(5));