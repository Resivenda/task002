﻿// Задача 13: Напишите программу, которая выводит третью цифру (с конца) заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 100)
{
    int ThirdDigit = ((number /100)%10);

    Console.WriteLine("ThirdDigit=" + ThirdDigit);

}
else Console.WriteLine("Число должно быть трехзначным и более");
