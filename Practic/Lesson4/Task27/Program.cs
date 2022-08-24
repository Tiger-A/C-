// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



using static System.Console;
Clear();
WriteLine("Введите число cумму цифр которого вы хотите узнать: ");
int number = Convert.ToInt32(ReadLine());
Console.WriteLine($"Cумма цифр в  введённом числе {SumDigitsInNumber(number)}");

int SumDigitsInNumber(int number)
{
    int DigitsSum = 0;
    for (int i = 0; i < number; i++)
    {
        DigitsSum += number % 10;
        number = number / 10;
    }
    return DigitsSum;
}
