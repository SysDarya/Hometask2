// Написать программу вычисления произведения чисел от 1 до N

Console.WriteLine ("Введите число-предел: ");
int n = int.Parse (Console.ReadLine ()!);

int count = 1;
int mult = 1;

while (count <= n)
{
    mult = mult * count;
    count++;
}
Console.WriteLine ("Произведение чисел от 1 до " + n + " равно " + mult + ".");