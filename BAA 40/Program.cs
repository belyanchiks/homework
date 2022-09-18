﻿// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

Console.WriteLine("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a + b > c && a + c > b && c + b > a)
{
    Console.WriteLine($"Треугольник со сторонами {a}, {b} и {c} - существует");
}
else Console.WriteLine("Такой треугольник не существует");