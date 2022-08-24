// Задача 25: 
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using static System.Console;
Clear();
WriteLine("Возведем первое число в степнь второг числа. Введитете Первое число, нажмиьте Enter, введите второе число, нжмите Enter");
int answer = RaiseNumberInPower(Convert.ToInt32(ReadLine()), Convert.ToInt32(ReadLine()));
Write($"Ответ -  {answer}");

int RaiseNumberInPower(int a, int b)
{
    int result = 1;    
    for (int i = 0; i < b; i++) 
    {
        result *= a;
    }
    return result;
}
