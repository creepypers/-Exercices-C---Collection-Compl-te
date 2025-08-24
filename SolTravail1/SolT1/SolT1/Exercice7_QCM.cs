using System;

namespace ExercicesCSharp
{
    public static class Exercice7_QCM
    {
        public static void QCM()
        {
            int[] choix = { -1, -1, -1, -1 }; // contiendra l'index des questions au hasard

            string[,] questions = new string[10, 6]; //à 0 la question, à 1 choix1, à 2 choix 2, à 3 choix 3, à 4 bonne réponse et à 5 la réponse de l'utilisateur
            questions[0, 0] = "Question1"; questions[0, 1] = "Q1-choix1"; questions[0, 2] = "Q1-choix2"; questions[0, 3] = "Q1-choix3"; questions[0, 4] = "Q1-choix3"; questions[0, 5] = "";
            questions[1, 0] = "Question2"; questions[1, 1] = "Q2-choix1"; questions[1, 2] = "Q2-choix2"; questions[1, 3] = "Q2-choix3"; questions[1, 4] = "Q2-choix2"; questions[1, 5] = "";
            questions[2, 0] = "Question3"; questions[2, 1] = "Q3-choix1"; questions[2, 2] = "Q3-choix2"; questions[2, 3] = "Q3-choix3"; questions[2, 4] = "Q3-choix1"; questions[2, 5] = "";
            questions[3, 0] = "Question4"; questions[3, 1] = "Q4-choix1"; questions[3, 2] = "Q4-choix2"; questions[3, 3] = "Q4-choix3"; questions[3, 4] = "Q4-choix1"; questions[3, 5] = "";
            questions[4, 0] = "Question5"; questions[4, 1] = "Q5-choix1"; questions[4, 2] = "Q5-choix2"; questions[4, 3] = "Q5-choix3"; questions[4, 4] = "Q5-choix2"; questions[4, 5] = "";
            questions[5, 0] = "Question6"; questions[5, 1] = "Q6-choix1"; questions[5, 2] = "Q6-choix2"; questions[5, 3] = "Q6-choix3"; questions[5, 4] = "Q6-choix3"; questions[5, 5] = "";
            questions[6, 0] = "Question7"; questions[6, 1] = "Q7-choix1"; questions[6, 2] = "Q7-choix2"; questions[6, 3] = "Q7-choix3"; questions[6, 4] = "Q7-choix3"; questions[6, 5] = "";
            questions[7, 0] = "Question8"; questions[7, 1] = "Q8-choix1"; questions[7, 2] = "Q8-choix2"; questions[7, 3] = "Q8-choix3"; questions[7, 4] = "Q8-choix2"; questions[7, 5] = "";
            questions[8, 0] = "Question9"; questions[8, 1] = "Q9-choix1"; questions[8, 2] = "Q9-choix2"; questions[8, 3] = "Q9-choix3"; questions[8, 4] = "Q9-choix1"; questions[8, 5] = "";
            questions[9, 0] = "Question10"; questions[9, 1] = "Q10-choix1"; questions[9, 2] = "Q10-choix2"; questions[9, 3] = "Q10-choix3"; questions[9, 4] = "Q10-choix1"; questions[9, 5] = "";

            //Choisir les 4 questions sans répéter aucune question
            Random random = new Random();
            for (int i = 0; i < choix.Length; i++)
            {
                int nombre;
                bool existe;
                do
                {
                    nombre = random.Next(10);
                    existe = false;
                    for (int j = 0; j < choix.Length; j++)
                        if (nombre == choix[j])
                            existe = true;

                } while (existe);
                choix[i] = nombre;
            }

            //Afficher les questions et enregister les réponses
            for (int i = 0; i < choix.Length; i++)
            {
                Console.WriteLine("entrer 1 pour la premiere reponse, 2 pour la deuxieme et 3 pour la troisieme.");
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(questions[choix[i], j]);
                }
                int reponse = Int32.Parse(Console.ReadLine());
                questions[choix[i], 5] = questions[choix[i], reponse]; //enregistrer la réponse dans le tableau à 5
                Console.Clear();
            }

            //Tester et afficher les bonnes Réponses
            int resultat = 0;
            for (int i = 0; i < questions.GetLength(0); i++)
            {
                if (!questions[i, 5].Equals("")) // la rèponse des questions non posées reste vide
                {
                    if (questions[i, 4].Equals(questions[i, 5]))
                        resultat++;
                    else
                        Console.WriteLine("votre rèponse à la question " + (i + 1) + " : " + questions[i, 0] + " etait  :  " + questions[i, 5] + " mais la bonne reponse est  :  " + questions[i, 4]);
                }
            }

            //Afficher le résultat
            Console.Write("Le nombre de bonnes reponses est : " + resultat + " et la cote est : ");
            switch (resultat)
            {
                case 4: { Console.WriteLine("A"); break; }
                case 3: { Console.WriteLine("B"); break; }
                case 2: { Console.WriteLine("D"); break; }
                default: { Console.WriteLine("E"); break; }
            }

            Console.WriteLine("\n appuyer sur une touche pour retourner au Menu");
            Console.ReadKey();
        }
    }
}
