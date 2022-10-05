/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/



int size = 4;
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);


void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int SumNumbers(int[] numbers)
{
    int summ = 0;
    for (int i = 1; i < numbers.Length; i += 2)
    {
        summ += numbers[i];
    }
    return summ;
}



Console.Write("Полученный массив: ");
PrintArray(numbers);
int Summ = SumNumbers(numbers);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {Summ}.");