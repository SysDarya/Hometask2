// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine ("Координаты первой точки: ");
int x = int.Parse (Console.ReadLine ()!);
int y = int.Parse (Console.ReadLine ()!);
int z = int.Parse (Console.ReadLine ()!);

Console.WriteLine ("Координаты второй точки: ");
int xs = int.Parse (Console.ReadLine ()!);
int ys = int.Parse (Console.ReadLine ()!);
int zs = int.Parse (Console.ReadLine ()!);

double d;

if (z == 0 && zs == 0)
{
    d = Math.Sqrt((xs-x)*(xs-x)+(ys-y)*(ys-y));
    Console.WriteLine ("Расстояние равно " + d + ".");
}
else
{
    d = Math.Sqrt((xs-x)*(xs-x)+(ys-y)*(ys-y)+(zs-z)*(zs-z));
    Console.WriteLine ("Расстояние равно " + d + ".");
}
