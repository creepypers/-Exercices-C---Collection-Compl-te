using System;

namespace ExercicesCSharp
{
    public static class Exercice6_E
    {
        public static void E()
        {
            int lignes, colonnes;
            char caractere;

            Console.WriteLine("Entrer le nombre de lignes : ");
            lignes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrer le nombre de colonnes : ");
            colonnes = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Entrer * pour utiliser des * ou autre pour utiliser des ♥");
            caractere = Console.ReadKey().KeyChar;
            if (caractere != '*')
                caractere = '♥';

            for (int l = 0; l < lignes; l++)
            {
                Console.Write("\n");
                if (l == 0 || l == lignes - 1 || l == (int)(lignes / 2))
                {
                    for (int c = 0; c < colonnes; c++)
                        Console.Write(caractere);
                }
                else
                    Console.Write(caractere);
            }
            Console.ReadKey();
        }
    }
}
