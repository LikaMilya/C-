// Напишите программу, которая на выход принимает два числа и выдает, какое число большее, а какое меньшее
Console.Clear();
Console.WriteLine("Введите первое чило");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе чило");
int y = int.Parse(Console.ReadLine()!);
if (x > y)
{
    int max = x;
    
    Console.WriteLine($" максимальное число {x}");
}
else
{
    int max = y;
   
    Console.WriteLine($" максимальное числочисло {y}");
}