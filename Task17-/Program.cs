// Написать прогр, которая принимает на вход
//коорд. точки (X и Y), причем X не = 0 и Y не = 0
// и выдает номер четверти плоскости, в которой
// находится эта точка.
Console.Clear();
Console.WriteLine("Enter the coordinates of the point: ");
Console.Write("X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
if (X > 0 && Y > 0) Console.WriteLine("The point lies in the first quarter.");
else if (X < 0 && Y > 0) Console.WriteLine("The point lies in the second quarter.");
else if (X < 0 && Y < 0) Console.WriteLine("The point lies in the third quarter.");
else if (X > 0 && Y < 0) Console.WriteLine("The point lies in the fourth quarter.");
else Console.WriteLine("Incorrect data entered.");