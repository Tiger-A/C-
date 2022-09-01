/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B,
 и возводит число А в целую степень B с помощью рекурсии
 */


using static System.Console;
Clear();

int number1 = int.Parse(ReadLine());
int number2 = int.Parse(ReadLine());


int num = number1 ^ number2;



WriteLine($"{GetPow(number1, number2)}");

int GetPow(int num1, int num2)
{   
    if(num2 == 0) return  1;
    return GetPow(num1, num2 -1 ) * num1;
      
}
/*
Через тернарник

int GetPow(int num1, int num2)
{   
    return (num2 == 0)? 1:GetPow(num1, num2 -1 ) * num1;
    
      
}
*/
