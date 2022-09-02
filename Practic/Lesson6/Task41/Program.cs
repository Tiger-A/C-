// Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
using System.Linq;
Clear();


Write("Введите через пробел несколько положительных и отрицательных целых чисел : ");
WriteLine($"Введено положительных чисел - {FindCountPositiveElements(GetArrayFromString(ReadLine()!))}");


int[] GetArrayFromString(string AnyStringArray)
{
    string[] MyStringArray = AnyStringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[MyStringArray.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(MyStringArray[i]);
    }
    WriteLine($"[{String.Join(",", result)}]");
    return result;
}


int FindCountPositiveElements(int[] AnyArray)
{
    int count = 0;
    foreach (int element in AnyArray)
    {
        count += element > 0 ? 1 : 0;
    }
    return count;
}



