// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine ("Введите номер дня недели: ");
int w = int.Parse (Console.ReadLine ());

if (w == 6 || w == 7)
{
    Console.WriteLine ("Ура, выходной!!!");
}
else
{
    Console.WriteLine ("Опять работать :(");
}