static int[] InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int j = i - 1;
        int temp = arr[i];
        while (j >= 0 && arr[j] > temp)
        {
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = temp;
    }

    return arr;
}

int[] arr = new int[10] { 100, 22, 33, 14, 5, 76, 77, 58, 39, 10 };
var arrSorted = InsertionSort(arr);
Console.WriteLine(String.Join(" ", arrSorted));