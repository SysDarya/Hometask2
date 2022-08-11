// Показать кубы чисел, заканчивающихся на четную цифру

Console.WriteLine ("Введите число: ");
int a = int.Parse (Console.ReadLine ()!);

int cube = 0;

if (a%2 == 0)
{
    cube = a*a*a;
    Console.WriteLine ("Число заканчивается на четную цифру и его куб равен " + cube + ".");
}
else
{
    Console.WriteLine ("К сожалению, число заканчивается на нечетную цифру :(");
}