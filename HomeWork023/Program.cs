/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] Mass = new int[4, 4];
FillArrayRandomNumbers(Mass);
PrintArray(Mass);
Console.WriteLine();
SmallestRowSum(Mass); 



void FillArrayRandomNumbers(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.Green; 
    Console.WriteLine("---ArrayRandom---");
    Console.ResetColor();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void SmallestRowSum(int[,] array)
{
    int SmallestRow = 0;
    int SmallestRowSum = 0;
    int RowSum = 0;
    for (int i = 0; i < Mass.GetLength(1); i++)
    {
        SmallestRow += Mass[0, i];
        //Console.WriteLine(SmallestRow);
    }

    for (int i = 0; i < Mass.GetLength(0); i++)
    {
        for (int j = 0; j < Mass.GetLength(1); j++) RowSum += Mass[i, j];
        Console.WriteLine($"Сумма чивел в строке {i+1} равна: {RowSum}");
        if (RowSum  < SmallestRow)
        {
            SmallestRow = RowSum;
            SmallestRowSum = i;
            
        }
        RowSum = 0;
    }
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green; 
    Console.Write($"Наименьшая сумма элементов в {SmallestRowSum + 1} строке");
    Console.ResetColor();
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"| {array[i, j]} ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}


