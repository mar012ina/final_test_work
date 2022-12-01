string[] array1 = new string[7] {"123", "54", "hello", "world", "run", "program", "7"};
string[] array2 = new string[array1.Length];
int count = 0;

void CreateSecondArray(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
CreateSecondArray(array1, array2);
ShowArray(array2);
