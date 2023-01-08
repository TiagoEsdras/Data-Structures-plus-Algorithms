static int[] MergeSort(int[] arr)
{
    int length = arr.Length;

    if (length == 1) return arr;

    int middle = length / 2;

    int[] left = arr.Take(middle).ToArray();
    int[] right = arr.Skip(middle).ToArray();

    return Merge(MergeSort(left), MergeSort(right));
}

static int[] Merge(int[] left, int[] right)
{
    List<int> result = new();
    int leftIndex = 0;
    int rigthIndex = 0;

    while (leftIndex < left.Length && rigthIndex < right.Length)
    {
        if (left[leftIndex] < right[rigthIndex])
        {
            result.Add(left[leftIndex]);
            leftIndex++;
        }
        else
        {
            result.Add(right[rigthIndex]);
            rigthIndex++;
        }
    }

    return result.Concat(left.Skip(leftIndex)).Concat(right.Skip(rigthIndex)).ToArray();
}

int[] arr = new int[11] { 1, 22, 33, 14, 5, 76, 77, 58, 39, 10, 54 };
var arrSorted = MergeSort(arr);
Console.WriteLine(String.Join(" ", arrSorted));