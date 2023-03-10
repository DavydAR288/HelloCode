//Задача. Упорядочить данные в массиве. Сортировка методом выбора - минимакса.

// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[minPosition]) minPosition = j;
//         }


//         int temp = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temp;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

//Задача. Упорядочить данные в массиве. Сортировка от большего к меньшему.

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }


        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);