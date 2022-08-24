/* Задача 40: Напишите программу, которая принимает на вход три числа 
и проверяет, может ли существовать треугольник с сторонами такой длины.*/

using static System.Console;
Clear();

WriteLine("Введите длины сторон треугольника");

int[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=>Convert.ToiInt32(x)).ToArray;

WriteLine(Trianngle(arraay)?"Yes":"No")

bool Triangle (int[] arr)
{
     

return (arr[0]+arr[1] > arr[3] $$ arr[1]+arr[2] > arr[0] $$ arr[0]+arr[2] > arr[1]);
}


/*Задача 40: Напишите программу, которая принимает на вход три
 числа и проверяет, может ли существовать треугольник с сторонами
 такой длины*/
using static System.Console;
using System.Linq;
Clear();

WriteLine("Enter the sides of the triangle");

int[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=>Convert.ToInt32(x)).ToArray();

WriteLine(Triangle(array)?"Yes":"No");

bool Triangle(int[] arra)
{
    return (arra[0]+arra[1] > arra[2] && arra[1]+arra[2] > arra[0] && arra[0]+arra[2] > arra[1]);
    
}

