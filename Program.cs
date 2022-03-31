
string[] someWords = new string[7] { "hello", "world", "2", "ups", "cat", "me", "eagle" };
string[] newWords = new string[someWords.Length];

int count = 0;

void CorrectMassive(string[] arr1, string[] arr2)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

CorrectMassive(someWords, newWords);
PrintArray(newWords);