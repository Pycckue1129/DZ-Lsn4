// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int randomNum = new Random().Next(1,10000);
Console.WriteLine(randomNum);
Console.WriteLine(GetSum(randomNum));

int GetSum(int number)
{
    int length = GetLength(number);
    int sum = 0;
    for (int i = 1; i <= length; i++)
    {
        int temp = number % 10;
        sum = sum + temp;
        number = number / 10;
    }
    return sum;
}

int GetLength(int number)
{
    int i = 0;
    while (number != 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}