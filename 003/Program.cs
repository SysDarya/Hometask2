// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine ("Введите четверть координатной плоскости: ");
int q = int.Parse (Console.ReadLine ()!);

if (q == 1)
{
    Console.WriteLine ("Диапазон координат для этой плоскости: x[0;	inf]; y[0; inf].");
}
else if (q == 2)
{
    Console.WriteLine ("Диапазон координат для этой плоскости: x[0;	negInf]; y[0; inf].");
}
else if (q == 3)
{
    Console.WriteLine ("Диапазон координат для этой плоскости: x[0;	negInf]; y[0; negInf].");
}
else if (q == 4)
{
    Console.WriteLine ("Диапазон координат для этой плоскости: x[0;	inf]; y[0; negInf].");
}
else
{
    Console.WriteLine ("У плоскости координат только 4 четверти :)");
}