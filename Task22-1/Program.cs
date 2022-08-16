// Написть прог, которая принимает на вход число
//(Н) и выдает таблицу квадратов чиаел от 1 до Н.
// 5 - 1, 4, 9, 16, 25. 2 - 1, 4.
Console.Clear();
Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());
if (n > 0)
{
    for (int i = 1; i <= n; i++)
    Console.WriteLine($"{i}\t{i * i}");
}
else Console.WriteLine("Incorrect data entered.");