//Задача 20. Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
Console.Clear();
double Distance(int xa, int ya, int xb, int yb)
{
    return Math.Sqrt((xa - xb)*(xa - xb) + (ya - yb)*(ya - yb));
}
Console.WriteLine("1 точка ");
Console.Write("введите координаты x:  ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1 точка ");
Console.Write("введите координаты y:  ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 точка ");
Console.Write("введите координаты x:  ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 точка ");
Console.Write("введите координаты y:  ");
int yb = Convert.ToInt32(Console.ReadLine());

double res = Distance(xa, ya, xb, yb);
Console.WriteLine(Math.Round(res, 2));