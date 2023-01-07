static int[] BubbleSort(int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length - 1 - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
            }
        }
    }

    return arr;
}

int[] arr = new int[10] { 1, 22, 33, 14, 5, 76, 77, 58, 39, 10 };
var arrSorted = BubbleSort(arr);
Console.WriteLine(String.Join(" ", arrSorted));