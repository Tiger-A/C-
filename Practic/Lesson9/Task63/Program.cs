/*
Задача 65: Задайте значения M и N. Напишите программу, которая
 выведет все натуральные числа в промежутке от M до N.
 */


using static System.Console;
Clear();

int max = int.Parse(ReadLine());
int min = int.Parse(ReadLine());


WriteLine($"{GetStringNumbers(max, min)}");

string GetStringNumbers(int n, int m)
{
    if (n > m)
    {
    if(n == m) return  $"{m}";
    return GetStringNumbers(n-1, m)+" "+$" {n}";
     }
    else
    {
        if(m == n) return  $"{n}";
        return GetStringNumbers(m-1, n)+" "+$" {m}";
    }
}
