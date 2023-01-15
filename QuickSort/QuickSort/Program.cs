static int[] QuickSort(int[] array, int left, int right)
{
    int pivot;
    int partitionIndex;

    if (left < right)
    {
        pivot = right;
        partitionIndex = Partition(array, pivot, left, right);

        QuickSort(array, left, partitionIndex - 1);
        QuickSort(array, partitionIndex + 1, right);
    }
    return array;
}

static int Partition(int[] array, int pivot, int left, int right)
{
    int pivotValue = array[pivot];
    int partitionIndex = left;

    for (int i = left; i < right; i++)
    {
        if (array[i] < pivotValue)
        {
            Swap(array, i, partitionIndex);
            partitionIndex++;
        }
    }
    Swap(array, right, partitionIndex);
    return partitionIndex;
}

static void Swap(int[] array, int firstIndex, int secondIndex)
{
    (array[secondIndex], array[firstIndex]) = (array[firstIndex], array[secondIndex]);
}

int[] arr = { 99, 44, 6, 2, 1, 5, 63, 87, 283, 4, 0 };
var arrSorted = QuickSort(arr, 0, arr.Length - 1);
Console.WriteLine(String.Join(" ", arrSorted));