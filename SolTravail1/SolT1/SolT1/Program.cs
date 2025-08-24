using System;

namespace ExercicesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;
            do
            {
                choix = Menu();
                switch (choix)
                {
                    case 1: { Console.Clear(); Exercice1_Kayak.Kayak(); break; }
                    case 2: { Console.Clear(); Exercice2_KayakPlus.Kayakplus(); break; }
                    case 3: { Console.Clear(); Exercice3_MaxTaxe.MaxTaxe(); break; }
                    case 4: { Console.Clear(); Exercice4_ChangerLaCasse.ChangerLaCasse(); break; }
                    case 5: { Console.Clear(); Exercice5_Password.Password(); break; }
                    case 6: { Console.Clear(); Exercice6_E.E(); break; }
                    case 7: { Console.Clear(); Exercice7_QCM.QCM(); break; }
                    default: { Console.Clear(); break; }
                }

            } while (choix != -1);
            Console.ReadKey();
        }

        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Kayak"); 
            Console.WriteLine("2. KayakPlus"); 
            Console.WriteLine("3. MaxTaxe");
            Console.WriteLine("4. ChangerLaCasse"); 
            Console.WriteLine("5. Password"); 
            Console.WriteLine("6. E"); 
            Console.WriteLine("7. QCM");

            Console.Write("Entrer le numero du programme a executer ou -1 pour quitter :  ");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
