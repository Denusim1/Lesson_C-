/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите число M:");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M:");
int N = Convert.ToInt32(Console.ReadLine());


void Sum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    else
    {
        sum = sum + (M++);
        Sum(M, N, sum);
    }
}

Sum(M, N, 0);