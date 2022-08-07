using static System.Console;
Clear();
 



//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22



Write("Введите число A: ");
int numA = Convert.ToInt32(ReadLine());
 
Write("Введите число B: ");
int numB = Convert.ToInt32(ReadLine());
 
 Write("Введите число C: ");
int numC = Convert.ToInt32(ReadLine());

int max = numA;

if (numB > max)
{
max = numB;
}

if (numC > max)
{
max = numC;
}


    System.Console.WriteLine("Maксимальное число - ");
    System.Console.WriteLine(max);
