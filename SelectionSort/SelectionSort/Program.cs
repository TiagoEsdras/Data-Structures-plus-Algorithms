static int[] SelectionSort(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        int smallNumberIndex = i;
        for (int j = i + 1; j < length; j++)
        {
            if (arr[j] < arr[smallNumberIndex])
            {
                smallNumberIndex = j;
            }

            if (j == length - 1)
            {
                (arr[i], arr[smallNumberIndex]) = (arr[smallNumberIndex], arr[i]);
            }
        }
    }

    return arr;
}

int[] arr = new int[10] { 100, 22, 33, 14, 5, 76, 77, 58, 39, 1 };
var arrSorted = SelectionSort(arr);
Console.WriteLine(String.Join(" ", arrSorted));