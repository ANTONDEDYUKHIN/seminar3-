//Написать прогр, которая по заданному номеру 
// четверти, показывает диапазон возм.
//координат точек в этой четверти (Х и У)
Console.Clear();
Console.WriteLine("Enter the number of quarter: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string GetRange(int Q)
// Console.Write("X: ");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int Y = Convert.ToInt32(Console.ReadLine());
// string GetQuarter(int X, int Y)
{
if (Q == 1) return"X > 0 && Y > 0";
if (Q == 2) return"X < 0 && Y > 0";
if (Q == 3) return"X < 0 && Y < 0";
if (Q == 4) return"X > 0 && Y < 0";
return"Incorrect data entered.";
}
string result = GetRange(quarter);
Console.WriteLine(result);