Console.WriteLine("Программа для проверки числа на палиндром");
Console.WriteLine("Введите пятизначное число:");
int x = Convert.ToInt32(Console.ReadLine());
int z1 = 0;
int z2 = 0;
int z3 = 0;
int z4 = 0;
int z5 = 0;
int x1 = 0;

z1 = x % 10;
z2 = x % 100; z2 = z2 / 10;
z3 = x % 1000; z3 = z3 / 100;
z4 = x % 10000; z4 = z4 / 1000;
z5 = x % 100000; z5 = z5 / 10000;

x1 = z1 * 10000 + z2 * 1000 + z3 * 100 + z4 * 10 + z5;

Console.WriteLine(x1);

if (x == x1)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}