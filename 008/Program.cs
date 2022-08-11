// Подсчитать сумму цифр в числе

Console.WriteLine ("Введите число: ");
int a = int.Parse (Console.ReadLine ()!);

string str = a.ToString();
int index = 0;
int sum = 0;

while (index < str.Length)
{
    sum = sum + int.Parse(str[index].ToString());
    index++;
}

 Console.WriteLine ("Сумма цифр в числе равна " + sum + ".");