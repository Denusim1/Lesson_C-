/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число: ");
int threeNumber = Convert.ToInt32(Console.ReadLine());



if (threeNumber < 1000 )
{
    if ( threeNumber > 99)
    {
        Console.WriteLine("Второе число: " + CenterNumber(threeNumber));
    }
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
}


int CenterNumber(int N)
{
    int result = ((N / 10) % 10);
    return result;
}




