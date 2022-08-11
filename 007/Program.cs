// Определить количество цифр в числе

Console.WriteLine ("Введите число: ");
int a = int.Parse (Console.ReadLine ()!);

string str = a.ToString();
 Console.WriteLine ("Количество цифр в числе равно " + str.Length + ".");