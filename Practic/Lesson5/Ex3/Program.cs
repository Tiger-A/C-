﻿// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

using static System.Console;
using System.Linq;
Clear();

// int [] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select

int [] array = new int[10].Select(x=> new Random().Next(0,100)).ToArray();

int[] CopyArray (int[] arr)

WriteLine($"{String.Join("," array2)}")

{
    for (int i = 0; i < arr.Length; int++)
    {
        int temp =  arr1[]
        arr2[]
        return 
    }
}





От Эльвира Магасумова всем 10:44 PM
/*Задача 45: Напишите программу, которая будет
создавать копию заданного массива с помощью поэлементного копирования.*/

using static System.Console;
using System.Linq;
Clear();
WriteLine("Введите число:");

int[] array1 = new int[10].Select(x=> new Random().Next(0,100)).ToArray();
int[] array2 = CopyArray(array1);
WriteLine($"[{String.Join(",", array1)}]");
WriteLine($"[{String.Join(",", array2)}]");

int[] CopyArray (int[] arr1)
{
    int[] result = new int[arr1.Length]; 
    for (int i = 0; i < arr1.Length; i++)
    {
        result[i] = arr1[i];
    }
    return result;
}

