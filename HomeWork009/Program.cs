/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/



Console.Write("Введите координату Х первой точки: ");
int pointOneX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int pointOneY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int pointOneZ = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Х первой точки: ");
int pointSecondX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int pointSecondY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
int pointSecondZ = Convert.ToInt32(Console.ReadLine());



double function()
{
    double result = Math.Sqrt(Math.Pow(pointSecondX-pointOneX,2) + Math.Pow(pointSecondY-pointOneY,2) + Math.Pow(pointSecondZ-pointOneZ,2));
    return result;
}

double result = function();
Console.WriteLine($"Расстояние между ними в 3D пространстве {result}");
