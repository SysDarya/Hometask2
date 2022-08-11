// Найти кубы чисел от 1 до N

Console.WriteLine ("Введите число-предел: ");
int n = int.Parse (Console.ReadLine ()!);

int count = 1;
int cube;

while (count <= n)
{
    cube = count*count*count;
    Console.WriteLine ("Куб числа " + count + " равен " + cube + ".");
    count++;
}
