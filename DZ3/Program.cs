Console.WriteLine("Программа которая выдает таблицу кубов чисел");
int count = int.Parse(Console.ReadLine());
Console.WriteLine("Ответ");
for (int i = 1; i < count+1; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}