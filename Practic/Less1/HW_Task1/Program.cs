using static System.Console;
Clear();
 
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


Write("Введите число A: ");
int numA = Convert.ToInt32(ReadLine());
 
Write("Введите число B: ");
int numB = Convert.ToInt32(ReadLine());
 
if (numB*numB < numA){
    System.Console.WriteLine("Число А больше B");
}else{
    System.Console.WriteLine("Число B больше А");
}