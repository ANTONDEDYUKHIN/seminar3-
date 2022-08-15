﻿// Задача 23. Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 1;
if(num > 0)
{
    while(i <= num)
    {
        int q = i*i*i;
        Console.WriteLine($"{i}  {q}");
        i++;
    }
}
else
{
    Console.WriteLine("Enter number > 0!");
}