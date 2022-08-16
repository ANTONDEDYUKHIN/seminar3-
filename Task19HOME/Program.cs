// Задача 19 Напишите программу, которая 
//принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 23432 -> да
Console.Clear();
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int dig1 = num / 10000;
//Console.WriteLine($"digit1:{dig1} ");
int dig2 = (num / 1000) % 10;
//Console.WriteLine($"digit2:{dig2} ");
int dig4 = (num / 10) % 10;
//Console.WriteLine($"digit4:{dig4} ");
int dig5 = num % 10;
//Console.WriteLine($"digit5:{dig5} ");
if(dig1 == dig5 && dig2 == dig4) Console.WriteLine($"The number {num} is a palindrome.");
else Console.WriteLine($"The number {num} is not a palindrome.");