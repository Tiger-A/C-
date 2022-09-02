// Задача 43
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)



using static System.Console;
Clear();


WriteLine("Введите коэффициенты b1, k1, b2, k2 чтобы найти точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2: ");
WriteLine($"Точка пересечения по X: {IntersectionPoint(double.Parse(ReadLine()!), double.Parse(ReadLine()!), double.Parse(ReadLine()!), double.Parse(ReadLine()!))}");

double IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = 0;
   
        x = (b2 - b1) / (k1 - k2);
    
    WriteLine($"Точка пересечения по Y: {(k1 * (b2 - b1)) / (k1 - k2) + b1}");
    return x;
}