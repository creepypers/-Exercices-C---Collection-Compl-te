using System;

namespace ExercicesCSharp
{
    public static class Exercice4_ChangerLaCasse
    {
        public static void ChangerLaCasse()
        {
            string chaine1, chaine2 = "";
            Console.WriteLine("entrer la chaine de caracteres ");
            chaine1 = Console.ReadLine();

            for (int i = 0; i < chaine1.Length; i++)
                if ((int)chaine1[i] == 32)
                    chaine2 += '#';
                else if ((int)chaine1[i] >= 97 && (int)chaine1[i] <= 122)
                    chaine2 += (char)((int)chaine1[i] - 32);
                else if ((int)chaine1[i] >= 65 && (int)chaine1[i] <= 90)
                    chaine2 += (char)((int)chaine1[i] + 32);
                else
                    chaine2 += chaine1[i];
            
            Console.Clear();
            Console.WriteLine("L'ancienne chaine est : " + chaine1);
            chaine1 = chaine2;
            Console.WriteLine("La nouvelle chaine est : " + chaine1);

            Console.ReadKey();
        }
    }
}
