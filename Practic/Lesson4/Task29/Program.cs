// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using static System.Console;
Clear();
int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] MyArray)
{
    int length = MyArray.Length;
    int index = 0;
    while (index < length)
    {
        Write("Введите число массива  - ");
        MyArray[index] = int.Parse(ReadLine()!);
        index++;
    }
}

void PrintArray(int[] AnyArray)
{
    int length = AnyArray.Length;
    int index = 0;
    while (index < length)
    {
        Write($"{AnyArray[index]} ");
        index++;
    }
}

