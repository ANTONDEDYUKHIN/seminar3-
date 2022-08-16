// Написть прог, которая принимает на вход число
//(Н) и выдает таблицу квадратов чиаел от 1 до Н.
// 5 - 1, 4, 9, 16, 25. 2 - 1, 4.
Console.Clear();
Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
if (n > 0)
{
    while(i <= n)
    {
    int q = i * i;
    Console.WriteLine($"{i} {q}");
    i++;
    }
}
else Console.WriteLine("Incorrect data entered.");