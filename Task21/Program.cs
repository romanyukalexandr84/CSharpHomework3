double Distance (int a, int b, int c, int d, int e, int f)
{
    return (Math.Sqrt (Math.Pow ((d-a), 2) + Math.Pow ((e-b), 2) + Math.Pow ((f-c), 2)));
}

Console.WriteLine ("Введите координаты первой точки:");
Console.Write ("x1 = ");
int x1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("y1 = ");
int y1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("z1 = ");
int z1 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Введите координаты второй точки:");
Console.Write ("x2 = ");
int x2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("y2 = ");
int y2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("z2 = ");
int z2 = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine ("Расстояние между двумя точками = "+Distance (x1, y1, z1, x2, y2, z2));