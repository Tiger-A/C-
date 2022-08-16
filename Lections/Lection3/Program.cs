// сортировка от мин к макc чисел  в массиве
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

int[] arr = {2, 4, 56, 8, 5, 4, 3, 5, 6, 7, 78};

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)

    {
    Console.Write($"{array[i]} ");
cd
}
Console.WriteLine();
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);