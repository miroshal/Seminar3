﻿// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int a = N / 10000;
int b = N % 10;
    
int c = N / 1000;
int d = c % 10;

int e = N / 10;
int f = e % 10;

if ((N < 9999) || (N > 100000))
{
    Console.WriteLine("Неверная цифра. Введите пятизначное число. ");
}
else if (a == b && d == f)
{
        Console.WriteLine($"число {N} является палиндромом");
}
else
{
    Console.WriteLine($"число {N} не является палиндромом");
} 