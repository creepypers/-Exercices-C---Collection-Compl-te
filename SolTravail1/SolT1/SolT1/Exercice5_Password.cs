using System;

namespace ExercicesCSharp
{
    public static class Exercice5_Password
    {
        public static void Password()
        {
            string chaine = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            int debut, fin;
            string pass = "";

            Random aleatoire = new Random();
            debut = aleatoire.Next(0, 26);
            do
            {
                fin = aleatoire.Next(0, 26);
            } while (fin < debut);
            pass += Min(debut, fin, chaine);

            debut = aleatoire.Next(0, 26);
            do
            {
                fin = aleatoire.Next(0, 26);
            } while (fin < debut);
            pass += Maj(debut, fin, chaine);

            debut = aleatoire.Next(0, 10);
            do
            {
                fin = aleatoire.Next(0, 10);
            } while (fin < debut);
            pass += Chiffre(debut, fin, chaine);

            Console.WriteLine(pass);
            Console.ReadKey();
        }

        private static string Min(int debut, int fin, string chaine)
        {
            if (debut >= 0 && fin >= 0 && fin >= debut && fin <= 25)
                return chaine.Substring(debut, fin - debut + 1);
            return "";
        }

        private static string Maj(int debut, int fin, string chaine)
        {
            if (debut >= 0 && fin >= 0 && fin >= debut && fin <= 25)
            {
                debut += 26;
                fin += 26;
                return chaine.Substring(debut, fin - debut + 1);
            }
            return "";
        }

        private static string Chiffre(int debut, int fin, string chaine)
        {
            if (debut >= 0 && fin >= 0 && fin >= debut && fin <= 9)
            {
                debut += 52;
                fin += 52;
                return chaine.Substring(debut, fin - debut + 1);
            }
            return "";
        }
    }
}
