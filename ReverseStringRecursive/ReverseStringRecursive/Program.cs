static string ReverseStringRecursive(string str)
{
    if (str.Length == 0)
        return str;

    return ReverseStringRecursive(str[1..]) + str[0];
}

Console.WriteLine(ReverseStringRecursive("abcdefghij"));

static string ReverseStringIterative(string str)
{
    var arrChar = str.ToCharArray();
    var n = str.Length - 1;

    for (int i = 0; i < n / 2; i++)
    {
        (arrChar[n - i], arrChar[i]) = (arrChar[i], arrChar[n - i]);
    }

    return new string(arrChar);
}

Console.WriteLine(ReverseStringIterative("abcdefghij"));