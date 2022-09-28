/*
Задача 29: Напишите программу, в которой пользователь задает длину массива, элементы которого задаются в диапазоне [1,99] и выводит на экран .

5 -> [1, 2, 5, 7, 19]

3 -> [6, 1, 33]
*/

int number = Read("Введите длинну массива : ");

int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] collection)

{
    int Length = collection.Length;
    int index = 0;
    while(index<Length)
    {
        collection[index] = new Random().Next(1,99);
        index++;
    }
}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int position = 0;
    while(position<count)
    {
        position++;
    }
}

int[] array = new int[number];
FillArray(array);
PrintArray(array);
string mass = string.Join(",", array);
Console.Write($"Массив из {number} элементов выглядет так [{mass}] ");