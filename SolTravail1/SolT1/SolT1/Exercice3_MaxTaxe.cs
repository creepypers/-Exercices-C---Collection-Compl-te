using System;

namespace ExercicesCSharp
{
    public static class Exercice3_MaxTaxe
    {
        public static void MaxTaxe()
        {
            float salaire1, salaire2, nombreEnfant;
            float[] Taxes = new float[6];

            for (int i = 0; i < Taxes.Length; i++)
            {
                Console.WriteLine("entrer le salaire 1 du couple " + (1 + i));
                salaire1 = float.Parse(Console.ReadLine());
                Console.WriteLine("entrer le salaire 2 du couple " + (1 + i));
                salaire2 = float.Parse(Console.ReadLine());
                Console.WriteLine("entrer le nombre d'enfants du couple " + (1 + i));
                nombreEnfant = float.Parse(Console.ReadLine());

                Taxes[i] = (salaire1 + salaire2) * TauxTaxe(salaire1 + salaire2);
                Taxes[i] -= Taxes[i] * nombreEnfant * 0.02f;
                Console.Clear();
            }

            //chercher le max
            float max = Taxes[0]; 
            int positionMax = 0; // supposer que le max est à la première place
            for (int i = 1; i < Taxes.Length; i++)
                if (Taxes[i] > max)
                {
                    max = Taxes[i];
                    positionMax = i;
                }
            Console.WriteLine("Le couple qui paie le plus de taxe est le couple : " + (positionMax+1) + " avec un montant de : " + Taxes[positionMax]);
            Console.ReadKey();
        }

        private static float TauxTaxe(float salaire)
        {
            if (salaire <= 25000)
                return 0;
            else if (salaire <= 60000)
                return 0.15f;
            else 
                return 0.2f;
        }
    }
}
