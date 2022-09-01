
/*
Задача 67: Напишите программу, 
которая будет принимать на вход число и
 возвращать сумму его цифр.
 */


using static System.Console;
Clear();

int number = int.Parse(ReadLine());



WriteLine($"{GetStringSumNum(number)}");

int GetStringSumNum(int num)
{   
    if(num / 10 == 0) return  num;
    return GetStringSumNum(num / 10 ) +  num % 10;
      
}

