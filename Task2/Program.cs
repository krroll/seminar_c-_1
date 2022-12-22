// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine ("Введите число а ");
int numberA = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите число b ");
int numberB = Convert.ToInt32 (Console.ReadLine ());
int max;
if (numberA>numberB)
{
    Console.WriteLine ("a>b");
    Console.WriteLine ("max = ");
    max = numberA;
    Console.WriteLine (max);
}
else if (numberA == numberB)
{
    Console.WriteLine ("Числа равны");
}
else
{
    max = numberB;
    Console.WriteLine ("a<b");
    Console.WriteLine ("max = ");
    Console.WriteLine (max);
}