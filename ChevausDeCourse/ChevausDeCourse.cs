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
        int Temp = int.MinValue;
        int Dif = int.MaxValue;
        int N = int.Parse(Console.ReadLine());
        int[] Power = new int[N];
        for (int i = 0; i < N; i++)
        {
            Power[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < Power.Length - 1; j++)
        {
            for (int h = j + 1; h < Power.Length; h++)
            {
                Temp = Math.Abs(Power[j] - Power[h]);
                if (Temp < Dif)
                {
                    Dif = Math.Abs(Temp);
                }
            }



        }
        Console.WriteLine(Dif);
        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


    }
}