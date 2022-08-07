// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет


using static System.Console;
Clear();
 


Write("Введите число A: ");
int numA = Convert.ToInt32(ReadLine());



if (numA% 2 == 0)
{
 System.Console.WriteLine("Введенное число - четное");
}

else 
{
System.Console.WriteLine("Введенное число - не четное");
}


   
   