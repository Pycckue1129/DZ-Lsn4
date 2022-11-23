// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int num = new Random().Next(1,10);
// int degree = new Random().Next(1,10);
// Console.WriteLine($"{num}, {degree}");

Console.WriteLine(Exponentiation(new Random().Next(1,10), new Random().Next(1,10)));

int Exponentiation (int num, int degree)
{
    int temp = num;
    for (int i = 1; i < degree; i++)
    {
        num = num * temp;
    }
    return num;
}