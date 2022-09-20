/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/



Console.Write("Введи цифру дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

void CheckDay (int day) {
  if (day == 6 || day == 7) 
  {
    Console.WriteLine("Это выходной день!");
  }
  else 
  {
    Console.WriteLine("Это не выходной день!");
  }
}

CheckDay(day);
