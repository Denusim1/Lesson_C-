/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Write("Введите пятизначное число: ");
int Number = Convert.ToInt32(Console.ReadLine());



if (Number < 100000 )
{
    if ( Number > 9999)
    {    
        if (CenterNumber1(Number) == CenterNumber5(Number))
        {
            Console.WriteLine($"Число {Number} является палиндромом");
        }
        else
        {
            Console.WriteLine($"Число {Number}  не является палиндромом");
        }
    }
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
}


int CenterNumber1(int N)
{
    int namber1 = ((N / 10000) % 10);
    return namber1;  
}

int CenterNumber5(int N)
{
    int namber5 = (N % 10);
    return namber5;   
}




