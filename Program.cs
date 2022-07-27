string[] arrayOld = new string[] { "fwer", "cat", "gerg", "fsfg", "ff" };

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
