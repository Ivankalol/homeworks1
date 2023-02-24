// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($" The maximum number  ->   {num1}");
//     Console.WriteLine($" The minimum number  ->   {num2}");
// }
// else 
// {
//     Console.WriteLine($" The maximum number  ->   {num2}");
//     Console.WriteLine($" The minimum number  ->   {num1}");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Input first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input third number");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2 > max)
// {
//    max = num2;
// }
// if (num3 > max)
// {
//    max = num3;
// }
// Console.WriteLine($" The maximum number  ->   {max}");


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.WriteLine("Input number");
// double num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine($" The number is  even ->   {num}");
// }
// else
// {
//     Console.WriteLine($" The  number is not even  ->   {num}");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Input N");
int n = Convert.ToInt32(Console.ReadLine());

int even = 2;
while(even <= n)
{
    Console.Write(even + " ");
    even = even + 2;
}
if (n == 1)
{
    Console.WriteLine($" There are no even numbers  ->   {n}");
}

