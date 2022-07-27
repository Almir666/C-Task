string[] arrayOld = new string[] { "hello", "2", "world", ":-)" };

int ArrayFindWords3(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] ArrayComplete(string[] arr, int count)
{
    int j = 0;
    string[] arrayNew = new string[count];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arrayNew[j] = arr[i];
            j++;
        }
    }
    return arrayNew;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

PrintArray(ArrayComplete(arrayOld, ArrayFindWords3(arrayOld)));