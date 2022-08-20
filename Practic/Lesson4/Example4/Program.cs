// Заполняем массив случайными 0 и 1

using static System.Console;
Clear();

int[] array = new int [10];
FillArr(array);
Write("[");
PrintArr(array);
Write("]");


void FillArr (int[] arr)
{
    for(int i=0; i < array.Length; i++)
    {

        arr[i] = new Random().Next(0, 2);
    }

}

void PrintArr (int[] arr)
{
    for(int i=0; i <arr.Length; i++)
    {
        Write($"{arr[i]}");
        if(i < arr.Length-1) Write(", ");
    }




}