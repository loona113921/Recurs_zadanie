// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


void Main()
{
    int[] array = { 2, 6, 9, 5, 6 };

    ReverseArray(array, array.Length - 1);
}

void ReverseArray(int[] arr, int index)
{
    if (index >= 0)
    {
        Console.Write(arr[index] + " ");
        ReverseArray(arr, index - 1);
    }
}
Main();