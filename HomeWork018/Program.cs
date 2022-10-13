/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
Console.Write("Введите колличество чисел: ");
int number = int.Parse(Console.ReadLine());

if(number!=0)
{
    Nnumbers(number,0);
} 
else
{
    Console.WriteLine($"Ошибка! Введиде значение больше {number}");
}

int Nnumbers(int number, int count)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int x = int.Parse(Console.ReadLine());
        if (x > 0)
            count++;
    }   PrintNumber(count);
    return count;
}   

void PrintNumber(int count)
{
    Console.WriteLine($"Пользователь ввел чисел больше нуля: {count} ");
}


