// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[new Random().Next(4, 15)];
PrintArray(FillArray(array));


int[] FillArray(int[] arr)
{
    int[] randomArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        randomArr[i] = new Random().Next(0,10);
    }
    return randomArr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}