// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
using static System.Console;
Clear();
Write("Введите какое-нибудь пятизначное число: ");
int number = Convert.ToInt32(ReadLine());
int FirstDigit = number % Convert.ToInt32(Math.Pow(10, 5)) / Convert.ToInt32(Math.Pow(10, 4));
int SecondDigit = number % Convert.ToInt32(Math.Pow(10, 4)) / Convert.ToInt32(Math.Pow(10, 3));
int PenultimateDigit = number % Convert.ToInt32(Math.Pow(10, 2)) / Convert.ToInt32(Math.Pow(10, 1));
int LastDigit = number % Convert.ToInt32(Math.Pow(10, 1)) / Convert.ToInt32(Math.Pow(10, 0));
if (FirstDigit == LastDigit && SecondDigit == PenultimateDigit)
{
    Write("Это число палиндром");
}
else
{
    Write("Это число не палиндром");
}
 
