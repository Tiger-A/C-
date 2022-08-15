//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1  не использовать строки, только математически


using static System.Console;
Clear();

Write("Введите число Трехзначное число: ");
int numA = Convert.ToInt32(ReadLine());

int GetSecondDigitOfNumber(int numA)
{
int secondDigitDoble = numA% 100;
int thirdDigit = secondDigitDoble% 10;
int secondDigit = (secondDigitDoble - thirdDigit)/10;
return secondDigit;
}

int secondDigit = GetSecondDigitOfNumber(numA);
Console.WriteLine($"Вторая цифра числа  -  {numA} является {secondDigit}");


