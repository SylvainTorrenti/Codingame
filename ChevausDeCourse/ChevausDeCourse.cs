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
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
        }

        // Write an answer using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine("answer");
    }
}
//Solution naîve
//L'algorithme le plus simple consiste simplement à comparer chaque puissance deux à deux puis afficher la différence la plus faible.

//Or, le nombre de valeurs peut atteindre 100 000 chevaux. Les comparer deux à deux nécessiterait plusieurs milliards de comparaisons, ce qui est bien trop pour passer le dernier test.

//Meilleure approche
//Pour obtenir un score de 100%, il est nécessaire de trouver une astuce permettant d'éviter de faire autant de comparaisons.

//Essayez de répondre à la question suivante : quelle modification sur les données d'entrée vous permettrait de trouver la réponse en parcourant une seule fois les valeurs de puissance (N-1 comparaisons) ?