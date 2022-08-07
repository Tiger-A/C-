//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8




using static System.Console;
Clear();

Write("Введите число N: ");
int numA = Convert.ToInt32(ReadLine());
int i = 1;

while (i <= numA)
{
    if (i % 2 == 0)
    {
        System.Console.WriteLine(i);
    }
    i++;
}





