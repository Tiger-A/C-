//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5




/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
 Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
 */



using static System.Console;
using System.Linq;
Clear();
//WriteLine("Введите размеры массива через пробел: ");
//int[] parametrs=ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToArray();
WriteLine("Введите количество строк: ");
//int r=int.Parse(ReadLine());
WriteLine("Введите количество столбцов: ");
//int c=int.Parse(ReadLine());
//int[,] Array=GetArray(r,c);
int[,] Array=GetArray(int.Parse(ReadLine()),int.Parse(ReadLine()));
//int[,] Array=GetArray(parametrs[0], parametrs[1]);
Printarray(Array);





/* int[,] GetArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = i + j;
        }
    }
    return result;
} */



void Printarray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write($"{matrix[i, j]} ");
        }
        WriteLine();
    }
}

