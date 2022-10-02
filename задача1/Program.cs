// Напишите программу, которая на выход принимает два числа и выдает, какое число большее, а какое меньшее
Console.Clear();
Console.WriteLine("Введите первое чило");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе чило");
int y = int.Parse(Console.ReadLine()!);
if (x > y)
{
    int max = x;
    int min = y;
    
    Console.WriteLine($" максимальное число {x}");
    Console.WriteLine($" минимальное число {y}");
}
else
{
    int max = y;
    int min = x;
   
    Console.WriteLine($" минимальное числочисло {y}");
    Console.WriteLine($" максимальное число {x}");
}