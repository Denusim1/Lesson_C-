/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4      //2*3+4*3 = 18 | 2*4+4*3 = 20   //  
3 2 | 3 3      //3*3+2*3 = 15 | 3*4+2+3 = 18   //
Результирующая матрица будет:
18 20
15 18
*/

int[,] array = new int[2, 2];
int[,] secondArray = new int[2, 2];
int[,] resultArray = new int[2, 2];

FillArrayRandomNumbers(array,secondArray);
PrintArray(array, secondArray);
Matrix(array, secondArray);
PrintArrayResult(resultArray); 



void FillArrayRandomNumbers(int[,] array, int[,] secondArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            secondArray[i, j] = new Random().Next(1, 10);
        }
    }
}

void Matrix(int[,] array, int[,] secondArray)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
            for (int k = 0; k < array.GetLength(1); k++)
            {
                resultArray[i, j] = resultArray[i, j] + array[i, k] * secondArray[k, j];  
            }
        }
    }
}


void PrintArray(int[,] array, int[,] secondArray)
{
    Console.ForegroundColor = ConsoleColor.Green; 
    Console.WriteLine("---ArrayRandomOne---");
    Console.ResetColor();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"| {array[i, j]} ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.Green; 
    Console.WriteLine("---ArrayRandomTwo---");
    Console.ResetColor();
    for (int i = 0; i < secondArray.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            Console.Write($"| {secondArray[i, j]} ");
        }
        Console.Write("|");
        Console.WriteLine();
    }
}


void PrintArrayResult(int[,] array)
{
    Console.ForegroundColor = ConsoleColor.Green; 
    Console.WriteLine("---ArrayResult---");
    Console.ResetColor();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"| {array[i, j]} | ");
        }
        Console.WriteLine();
    }
}