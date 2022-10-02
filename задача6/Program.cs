// Напишите программу, которая на входе принимает число и выдает, является ли число четным(делиться ли оно на два без остатка)
Console.Clear();
Console.WriteLine("Введите первое чиcло");
 int x = int.Parse(Console.ReadLine()!);
if(x%2==0)
{
Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


