// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

string[] array = new string[] {"мир", "страна", "цифра", ":-)", "слово"};
string[] sortArray = SortArrayString(array);
PrintArray(sortArray);

string[] SortArrayString(string[] arr)
{
    int len = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) len += 1;

    }
    string[] newArray = new string[len];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }

    }
    return newArray;
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}