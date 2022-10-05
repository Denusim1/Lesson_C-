/*Задача 34: Задайте массив заполненный случайными положительными трехзначными числами.
 Напишите программу, которая покажет количество четных чисел в массиве.
 [345, 897, 568, 234] => 2
*/

int size = Read("Введите длинну массива : ");

int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
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

int numberOfevenElements(int []numbers)
{
   int count = 0;
    for (int j = 0; j < numbers.Length; j++)
    {
        if (numbers[j] % 2 == 0)
        count++;
    } 
    return count;
}


Console.Write("Полученный массив: ");
PrintArray(numbers);
int NumberOf = numberOfevenElements(numbers);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"В массиве колличество четных чисел равно {NumberOf}.");