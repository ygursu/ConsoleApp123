﻿int kontrol = 0;
Console.Write("Sayı Girin : ");
int sayi = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (i < sayi)
{
    if (sayi % i == 0)
        kontrol++;

    i++;
}

if (kontrol != 0)
    Console.WriteLine("Girdiğiniz sayı asal değildir.");
else
    Console.WriteLine("Girdiğiniz sayı asaldır.");

Console.ReadKey();