﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int num = new Random().Next(1, 10);

System.Console.WriteLine($"Число = {num}");

for(int i = 1; i <= num; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}