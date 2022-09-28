/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

int number = Read("Введите число : ");


int Read(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}



int SumNumber(int number)
{
    int N = number.ToString().Length; 
    int dop = 0;
    int result = 0;
    for (int i = 0; i < N; i++)
    {
        dop = number - number % 10;
        //Console.WriteLine(dop);
        result = result + (number - dop);
        //Console.WriteLine(result);
        number = number / 10;
        //Console.WriteLine(number);
    }
    return result;
}

  
int sumNum = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNum);


