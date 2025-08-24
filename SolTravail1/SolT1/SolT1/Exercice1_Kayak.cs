using System;

namespace ExercicesCSharp
{
    public static class Exercice1_Kayak
    {
        public static int Kayak()
        {
            int age, prix = 0;
            do
            {
                Console.WriteLine("l'age svp ? ou -1 pour terminer");
                age = Int32.Parse(Console.ReadLine());
                prix += prixParAge(age);

            } while (age > 0);

            Console.WriteLine(prix);
            Console.ReadKey();

            return prix;
        }

        private static int prixParAge(int age)
        {
            if (age < 2)
                return 0;
            else if (age < 12)
                return 5;
            else if (age < 65)
                return 12;
            else
                return 10;
        }
    }
}
