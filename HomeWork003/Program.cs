/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/


while (true)
{
    Console.Write("Введите число: ");
    int Number = Convert.ToInt32(Console.ReadLine());
        if (Number%2 == 0)
        {
            Console.Write("Введенное число "+ Number + " является четным. Попробуете еще?    ");
        }
        else 
        {
            Console.Write("Введенное число "+ Number + " является нечетным. Попробуйде другое!)   ");
        }
}

/*
Попробовал бесконечный цикл. Все работает)
*/

