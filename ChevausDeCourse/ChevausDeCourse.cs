using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int Temp = int.MaxValue;
        int Dif = int.MaxValue;

        Console.WriteLine("Nombre chevaux");
        int N = int.Parse(Console.ReadLine());
        int[] Power = new int[N];
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("puissance");
            Power[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < Power.Length - 1; j++)
        {
            Temp = Power[j] - Power[j + 1];
            Temp = Math.Abs(Temp);
            if (Temp < Dif)
            {
                Dif = Math.Abs(Temp);
            }
        }
        Console.WriteLine(Dif);


        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

    }
}