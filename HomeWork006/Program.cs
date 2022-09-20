/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int GoodNumber = 0;

if (Number < 100 )
{
   Console.WriteLine("В этом числе третьей цифры нет!");
   return;
   
}
GoodNumber = Number;
string stGoodNumber = GoodNumber.ToString(); //перевел в строку число у которого более 3-х знаков

// Далее гуглил т.к. логика была понятна, что нужно перевести строку в массив и вывести второй элемент. Но со способом реализации
// не сталкивался. В общем нашел аж три варианта. Если раскомментить, то каждый будет работать.

char[] array = new char[stGoodNumber.Length];
for (int index = 0; index < stGoodNumber.Length; index++)
{
    array[index] = stGoodNumber[index];
}

//char [] array = stGoodNumber.ToCharArray();
//int[] array = stGoodNumber.Select(x => int.Parse(x.ToString())).ToArray();

Console.WriteLine(array[2]);

