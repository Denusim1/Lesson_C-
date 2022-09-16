/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int startNumber = 0;

while (startNumber < Number)
{
    if (Number%2==0)
    {
        Number = Number;
    }
    else 
    {
        Number = Number - 1;    
    }
    startNumber = startNumber +2 ;
    Console.Write(startNumber + ", ");     
}


 



