
// Напишите программу, которая на выход принимает три  числа и выдает, какое число больше.
Console.Clear();
Console.WriteLine("Введите первое чило");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе чило");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье чило");
int c = int.Parse(Console.ReadLine()!);
int max = x;
if (y > max)
     max = y;
if (c > max)
     max = c;
Console.WriteLine($"Максимальное{max}");