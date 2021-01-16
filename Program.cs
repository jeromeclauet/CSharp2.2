using System;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quel âge avez vous ?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quel est votre sexe ? (Masculin ou Féminin)");
            string sex = Console.ReadLine();
            if (age >= 18)
            {
                if (sex == ("Masculin"))
                {
                    Console.WriteLine("Vous êtes un Homme et vous avez " + age + " ans, vous êtes donc majeur.");
                }
                if (sex == ("Féminin"))
                {
                    Console.WriteLine("Vous êtes une Femme et vous avez " + age + " ans, vous êtes donc majeure.");
                }
            }
            else
            {
                if (sex == ("Masculin"))
                {
                    Console.WriteLine("Vous êtes un garçon et vous avez " + age + " ans, vous êtes donc mineur.");
                }
                if (sex == ("Féminin"))
                {
                    Console.WriteLine("Vous êtes une fille et vous avez " + age + " ans, vous êtes donc mineure.");
                }
            }
        }
    }
}