﻿//1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25; b = 5 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> да
//a = -3 b = 9 -> нет

using System;
using static System.Console;

Clear();
Write("Введите число a = ");
int a = Convert.ToInt32(ReadLine());
Write("Введите число b = ");
int b = Convert.ToInt32(ReadLine());

if ((a * a) == b) WriteLine("Число b является квадратом числа a");
else              WriteLine("Число b не является квадратом числа a");
