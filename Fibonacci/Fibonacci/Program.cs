static int FindFibonacciIterative(int num)
{
    //int a = 0;
    //int b = 1;
    //for (int i = 0; i < num; i++)
    //{
    //    int aux = a;
    //    a = b;
    //    b += aux;
    //}
    //return a;

    int[] arr = new int[num + 1];

    arr[0] = 0;
    arr[1] = 1;

    for (int i = 2; i <= num; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
    }

    return arr[num];
}

Console.WriteLine(FindFibonacciIterative(5));

static int FindFibonacciRecursive(int num)
{
    if (num == 0 || num == 1)
        return num;

    return FindFibonacciRecursive(num - 1) + FindFibonacciRecursive(num - 2);
}

Console.WriteLine(FindFibonacciRecursive(5));