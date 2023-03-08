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
        Console.WriteLine("Nombre element");
        int N = int.Parse(Console.ReadLine()); // Number of elements which make up the association table.
        Console.WriteLine("Nombre a analisé");
        int Q = int.Parse(Console.ReadLine()); // Number Q of file names to be analyzed.
        
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("element");
            string[] inputs = Console.ReadLine().Split(' ');
            string EXT = inputs[0]; // file extension
            string MT = inputs[1]; // MIME type.
        }
        for (int i = 0; i < Q; i++)
        {
            string FNAME = Console.ReadLine(); // One file name per line.

        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");


        // For each of the Q filenames, display on a line the corresponding MIME type. If there is no corresponding type, then display UNKNOWN.
        Console.WriteLine("UNKNOWN");
    }
}