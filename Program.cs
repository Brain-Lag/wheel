using System;

const int S = 1000 * 1000 * 100;
double D = 80;
double L = Math.PI * D;
double MaxTurnover = 200000;
double turnovers = S / L;
if (turnovers < MaxTurnover)
    Console.WriteLine("Запаса прочности хватит для преодоления данного расстояния");
else
    Console.WriteLine("Запаса прочности не хватит для преодоления данного расстояния");
