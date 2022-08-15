//Задача 21. Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
double Distance(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt((xa - xb)*(xa - xb) + (ya - yb)*(ya - yb) + + (za - zb)*(za - zb));
}
Console.WriteLine("1 точка ");
Console.Write("введите координаты x:  ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1 точка ");
Console.Write("введите координаты y:  ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("1 точка ");
Console.Write("введите координаты z:  ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 точка ");
Console.Write("введите координаты x:  ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 точка ");
Console.Write("введите координаты y:  ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 точка ");
Console.Write("введите координаты z:  ");
int zb = Convert.ToInt32(Console.ReadLine());
double res = Distance(xa, ya, za, xb, yb, zb);
Console.WriteLine(Math.Round(res, 2));