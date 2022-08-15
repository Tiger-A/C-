// вывод случайного числа от 10-99 и показывает наибольшуюю цифру числа

int GetRandomNumberInRange(int minNumber,int maxNumber)
{
    int result = new Random().Next(minNumber,maxNumber+1);
    return result;
}
int GetMaxDigitFromNumber(int number)
{
    int result = number / 10;
    int secondDigit = number % 10;
    if (result < secondDigit)
    {
        result = secondDigit;
    }
        
    return result;
}

for(int i = 0; i < 10; i++)
{
int randomNumber = GetRandomNumberInRange(10,99);
int MaxDigit = GetMaxDigitFromNumber(randomNumber);
Console.WriteLine($"Наибольшая цифра числа  -  {randomNumber} является {MaxDigit}");
}