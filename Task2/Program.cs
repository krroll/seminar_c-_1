// Задача 2: Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine ("Введите число а ");
// int numberA = Convert.ToInt32 (Console.ReadLine ());
// Console.WriteLine ("Введите число b ");
// int numberB = Convert.ToInt32 (Console.ReadLine ());
// int max;
// if (numberA>numberB)
// {
//     Console.WriteLine ("a>b");
//     Console.WriteLine ("max = ");
//     max = numberA;
//     Console.WriteLine (max);
// }
// else if (numberA == numberB)
// {
//     Console.WriteLine ("Числа равны");
// }
// else
// {
//     max = numberB;
//     Console.WriteLine ("a<b");
//     Console.WriteLine ("max = ");
//     Console.WriteLine (max);
// }
//----------------------------------------------
// Задача 4: Напишите программу, которая 
// принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine ("Введите первое число ");
// int number1 = Convert.ToInt32 (Console.ReadLine ());
// Console.WriteLine ("Введите воторое число ");
// int number2 = Convert.ToInt32 (Console.ReadLine ());
// Console.WriteLine ("Введите третье число ");
// int number3 = Convert.ToInt32 (Console.ReadLine ());
// int max = number1;
// if (number2>max)
// {
//     max = number2;
// }
// if (number3>max)
// {
//     max = number3;
// }
// Console.Write ("max = ");
// Console.WriteLine (max);
//--------------------------------------

// Задача 6: Напишите программу, которая 
// на вход принимает число и выдаёт, 
// является ли число чётным 
// (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine ("Введите число ");
int number = Convert.ToInt32 (Console.ReadLine ());

if (number % 2 == 0)
{
    Console.WriteLine ("Число чётное");
}
else
{
    Console.WriteLine ("Число  НЕ чётное");
}