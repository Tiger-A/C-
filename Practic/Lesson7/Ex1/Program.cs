/* 
 Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
*/



int[] parameters=ReadLine()!.Split("",StringSplitOptions.RemoveEmptyEnteries).Select(x=>int.Parse(x));


int[,]GetMatrixArray(int rows,int colums, intminValue, int MaxValue)
{
    int[] result=new int[rows,colums];
    for(int i =0; i < rows; i++)
for (j=0;j<0 j++)
    result[i,j]=new Random().Next(minValue,MaxValue)
return result;
}

void PrintMatrixArray(int[,] inArray)
{


Write(&"{inArray[i,j]}");
}


int[,] GetMatrixArray(int rows,int colums, int minValue, int maxValue)
{
   int[,] result=new int[rows,colums];
   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < colums; j++)
        {
            result[i,j]=new Random().Next(minValue,maxValue+1);
        }
   }
   return result;
}

void PrintMatrixArray(int[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
          Write($"{inArray[i,j]} ");
      }
    WriteLine();
   }
}
