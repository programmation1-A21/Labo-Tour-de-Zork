/**
* Solution possible au Labo 1
* 
* 1. Le menu principal continue toujours vers la nouvelle partie (création du personnage)
* 2. La création du personnage commence par un nom, puis 3 questions pour déterminer ses statistiques
* 3. Résumé du résultat de la cération
* 
* Création : 21/08/16
* Par : Frédérik Taleb
*
* Modification: 21/08/25
* Par : Frédérik Taleb
*/
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables pour le menu principal
            string intro = "Bienvenue à la tour de Zork, jusqu'où pourras-tu aller?\n  1.Nouvelle partie"; //\n  2.Continuer\n  3.Quitter";
            int choixMenu = 0;

            // Variables pour la création du personnage
            string creation = "Création du personnage";
            string questionNom = "\nQuel est ton nom aventurier?";
            string questionClasse = "Réponds aux 3 questions suivantes pour déterminer si {0} est un guerrier ou un magicien!";
            string questionCombat = "\nTu fais face à un troll des cavernes! Tu...\n  1. prends ta hache et le décapite\n  2. jette un sort de flammes. Ça fera parfaitement l'affaire";
            string questionExploration = "\nUne porte en bois massif bloque l'accès au prochain étage. Tu...\n  1. lui donne des couprs de pieds jusqu'à ce qu'elle défonce\n  2. reconnais le type de serrure et magnétise le loquet pour l'ouvrir";
            string questionInteraction = "\nLe gobelin que tu as capturé connais la réponse à une énigme critique. Tu...\n  1. lui tord tout ce que tu peux imaginer pour le faire parler\n  2. lui pose des questions sur l'énigme en lisant son esprit pour découvrir la réponse";
            string classeMagicien = "Tu es un maître de l'arcane et des éléments. Mais les années d'étude et de recherche ne t'ont pas laissé l'occasion de développer ton physique.";
            string classeGuerrier = "Une brute sanguinaire ou un noble chevalier, à toi de décider. Tu es endurant, rapide et un maître des arts martiaux. Pas le crayon le plus aiguisé de la boîte par contre...";
            int guerrier = 0;
            int magicien = 0;

            // Caractéristiques du personnage
            string stats = "\nNom: {0}\nVie : {1}\nArmure : {2}\nDommage : {3}";
            string nom = "Coco l'asticot";
            int vie = 20;
            int armure = 10;
            int dommage = 5;

            // Menu principal
            Console.WriteLine(intro);
            int.TryParse(Console.ReadLine(), out choixMenu);

            // Création du personnage
            Console.Clear();
            Console.WriteLine(creation);
            Console.WriteLine(questionNom);
            nom = Console.ReadLine();

            // Choix de la classe
            Console.Clear();
            Console.WriteLine(questionClasse, nom);
            Console.WriteLine(questionCombat);
            if(Console.ReadLine() == "1")
            {
                guerrier++;
            }
            else
            {
                magicien++;
            }

            Console.WriteLine(questionExploration);
            if(Console.ReadLine() == "1")
            {
                guerrier++;
            }
            else
            {
                magicien++;
            }

            Console.WriteLine(questionInteraction);
            if(Console.ReadLine() == "1")
            {
                guerrier++;
            }
            else
            {
                magicien++;
            }
            // Affichage du résultat
            Console.Clear();
            if(guerrier > magicien)
            {
                Console.WriteLine(classeGuerrier);
                vie += 10;
                armure += 5;
                dommage += 5;
                Console.WriteLine(stats, nom, vie, armure, dommage);
            }
            else
            {
                Console.WriteLine(classeMagicien);
                vie -= 5;
                armure += 10;
                dommage += 15;
                Console.WriteLine(stats, nom, vie, armure, dommage);
            }

            Console.ReadLine();
        }
    }
}
