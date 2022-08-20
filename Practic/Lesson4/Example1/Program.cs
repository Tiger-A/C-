using static System.Console;
Clear();
Write("ВВедите чило: ");
int A=int.Parse(ReadLine());
int sum=GetSum(A);
WriteLine($"Сумма 1 - {A} = {sum}");




int GetSum(int number)
{
    int result=0;
    for(int i=1;i<=number;i++)
        {
            result+=i;
        }
    return result;
}
