/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

using static System.Console;
Clear();


int m = InputNumbers("Введити колво строк массива: ");
int n = InputNumbers("Ведите кол-во столбцов: ");
int range = InputNumbers("Введите диапвзон значений");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

WriteLine($"Отсортированный построчно от макс к мин массив: ");
SortedOrderArrayLines(array);
WriteArray(array);

void SortedOrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Write(input);
  int output = Convert.ToInt32(ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Write(array[i, j] + " ");
    }
    WriteLine();
  }
}