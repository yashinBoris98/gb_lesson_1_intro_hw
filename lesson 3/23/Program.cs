﻿// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int n = Convert.ToInt32(Console.ReadLine());
int count = n;
for (int i = 0; i < count; i++)
{
    Console.WriteLine(n*n);
    n--;
}