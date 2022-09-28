/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


int number = Read("Введите число А: ");
int number2 = Read("Введите число В: ");

int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


function(number, number2);

void function(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    { 
        result = result*number;         
    }
    Console.WriteLine($"Число {number} в степени {number2} равно {result}");
}







