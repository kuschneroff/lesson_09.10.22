﻿// Цикл в Цикле на примере Таблицы умножения.

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); // Способ назвается ИНТЕРПОЛЯЦИЯ строк
    }
    Console.WriteLine();
}