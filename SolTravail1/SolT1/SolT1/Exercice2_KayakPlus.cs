using System;

namespace ExercicesCSharp
{
    public static class Exercice2_KayakPlus
    {
        public static int Kayakplus()
        {
            int montantTotal = 0;
            int[] categories = { 0, 0, 0, 0 };
            char reponse;
            do
            {
                Console.Clear();
                int age, prix = 0;
                do
                {
                    Console.WriteLine("l'age svp ? ou -1 s'il n'y a pas un autre membre de la famille");
                    age = Int32.Parse(Console.ReadLine());
                    prix += prixParAgeCategories(age, categories);

                } while (age > 0);
                montantTotal += prix;
                Console.WriteLine(prix);

                Console.WriteLine("une autre famille o/n");
                reponse = Console.ReadKey().KeyChar;
            } while (reponse != 'n');

            Console.WriteLine("Le montant total de la journee est : " + montantTotal);

            for (int i = 0; i < categories.Length; i++)
                Console.WriteLine(categories[i]);

            Console.ReadKey();
            return montantTotal;
        }

        private static int prixParAgeCategories(int age, int[] Tab)
        {
            if (age < 2)
            {
                Tab[0]++;
                return 0;
            }
            else if (age < 12)
            {
                Tab[1]++;
                return 5;
            }
            else if (age < 65)
            {
                Tab[2]++;
                return 12;
            }
            else
            {
                Tab[3]++;
                return 10;
            }
        }
    }
}
