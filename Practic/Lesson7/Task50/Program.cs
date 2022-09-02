// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


using static System.Console;
Clear();


WriteLine("Введите количество строк и столбцов чтобы получить случайный двумерный массив из целочисленных чисел в диапазоне [1-100]: ");
int[,] randomArray = GetMatrixArray(int.Parse(ReadLine()!), int.Parse(ReadLine()!));
PrintMatrixArray(randomArray);
WriteLine("Введите индекс элемента[строка + столбец] - значение которого Вы хотите узнать: (Значение строк и столбцов начинаюися с 0 !!!) ");
FindElementInRandomArray(randomArray, int.Parse(ReadLine()!), int.Parse(ReadLine()!));


int[,] GetMatrixArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 101);
        }
    }
    return result;
}


void PrintMatrixArray(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Write($"{myArray[i, j]} ");
        }
        WriteLine();
    }
}








void FindElementInRandomArray(int[,] checkArray, int myElementrow, int myElementcolumn)
{
    if (myElementrow < checkArray.GetLength(0) && myElementcolumn < checkArray.GetLength(1))
    {     
        Console.WriteLine($"На позиции строка - {myElementrow}, столбец - {myElementcolumn} " +
                          $"находится элемент со значением: {checkArray[myElementrow, myElementcolumn]}");
    }
    else Console.WriteLine($"Cтрока - {myElementrow}, столбец - {myElementcolumn} - элемента на такой позиции в нашем массиве нет.");
}