// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;
Clear();

Write("Введите количество элементов в массиве: ");
WriteLine($"Cумма элементов, стоящих на нечётных позициях в нашем массив: {SumOfNotEvenArrayElements(FillArrayWithRandomNum(int.Parse(ReadLine()!)))}");


int SumOfNotEvenArrayElements(int[] array)
{
    int sum = 0;
       for (int i = 1; i < array.Length; i+=2)
    {
        sum +=array[i];
    }
    return sum;
}


int[] FillArrayWithRandomNum(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
    WriteLine($"Массив заполненный случайными числами в диапазоне от -10 до 10 - [{String.Join(", ", array)}]");
    return array;
}