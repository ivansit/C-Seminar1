// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// Console.Clear();
// int number = new Random().Next(10, 100);
// int firstValue = number / 10;
// int secondValue = number % 10;
// Console.WriteLine(number + " " + firstValue + " " + secondValue);
// if (firstValue > secondValue)
// {
//     Console.WriteLine(firstValue);
// }
// else if (firstValue == secondValue)
// {
//     Console.WriteLine("цифры числа равны");
// }
// else
// {
//     Console.WriteLine(secondValue);
// }


// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// Console.Clear();
// int number = new Random().Next(100, 1000);
// //Console.WriteLine(number);
// int lastValue = number % 10; //получили последнюю цифру - остаток от деления на 10
// //Console.WriteLine(firstValue);
// int firstValue = number / 100; // целочисленное деление
// //Console.WriteLine(secondValue);
// // Console.WriteLine($" {number} -> {firstValue}{lastValue}");
// Console.WriteLine($" {number} -> {firstValue * 10 + lastValue} ");


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int a = int.Parse (Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse (Console.ReadLine()!);
// int result = 0;
// double result2 = 1;

// if (b % a == 0)
// {
//     result = b / a;
//     Console.WriteLine($" {b}, {a} -> кратно");
// }
// else
// {
//     result2 = b % a;
//     Console.WriteLine($" {b}, {a} -> не кратно, остаток {result2}");
// }


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 46 -> нет 161 -> да

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// if(number % 7 == 0 && number % 23 == 0)
// {
//     Console.WriteLine($" {number} -> да");
// }
// else
// {
//     Console.WriteLine($" {number} -> нет");
// }


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

// Console.Clear();
// Console.WriteLine("Введите первое число: ");
// int a = int.Parse (Console.ReadLine()!);
// Console.WriteLine("Введите второе число: ");
// int b = int.Parse (Console.ReadLine()!);
// int x = 0; //квадрат меньшего числа
// if (a > b)
// {
//     x = b * b;
//     if (x == a)
//     {
//         Console.WriteLine($" {a}, {b} -> да");
//     }
// }
// else if (a < b)
// {
//     x = a * a;
//     if (x == b)
//     {
//         Console.WriteLine($" {a}, {b} -> да");
//     }
//     else 
//     {
//         Console.WriteLine($" {a}, {b} -> нет");
//     }
// }