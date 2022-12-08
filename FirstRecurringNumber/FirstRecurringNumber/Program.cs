//Given an array int[], return the first recurring number, or null if all number are unique

using System.Collections;

static int? FirtsRecurringNumber(int[] arr)
{
    var hash = new Hashtable();
    for (int i = 0; i < arr.Length; i++)
    {
        if (hash.ContainsKey(arr[i])) return arr[i];

        hash.Add(arr[i], i);
    }

    return null;
}

var arr = new int[5] { 1, 7, 5, 4, 2 };
Console.WriteLine(FirtsRecurringNumber(arr));