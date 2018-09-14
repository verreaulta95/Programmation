using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonsoir cher détenu! Vous avez été emprisonné en raison d'un braquage qui a mal tourné.");
            Console.ReadKey();
            Console.WriteLine("Vous aurez 39 mois de prison à purgé avant d'être libre et pas question d'attendre aussi longtemps!");
            Console.ReadKey();

            Random chance = new Random();
            Random evasion = new Random();
            int choix = 0;
            int choix1 = 0;
            int choix2 = 0;
            int choix3 = 0;
            int choix4 = 0;
            int luck = chance.Next(1, 101);
            int escape = evasion.Next(1, 101);


            //Début lab prison

            // Amitié (1)

            while (choix != 1 && choix != 2) //boucle
            {
                Console.WriteLine("Le garde vous escorte jusqu'à votre cellule. À peine arrivé que votre co-détenu, un peu idiot, semble vouloir être votre ami. Qu'allez-vous faire?");
                Console.ReadKey();
                Console.WriteLine("1 - Accepte ou 2 - Refuse");
                choix = Convert.ToInt32(Console.ReadLine());
                if (choix == 1) // accepte
                {
                    Console.WriteLine("Super! Vous venez de vous faire un nouvel ami!");
                }
                else if (choix == 2) // refuse 
                {
                    Console.WriteLine("Oh non! Votre compagnon de cellule semble faché... Espérons qu'il ne m'en voudras pas!");
                }
                else //have fun
                {
                    Console.WriteLine("Vous n'avez pas compris le sentiment que procure l'amitié. Ré-essayer donc!");
                }

            }

            Console.ReadKey();
            Console.Clear();

            //Proposition (2) 

            while (choix1 != 1 && choix1 != 2) //boucle
            {
                Console.WriteLine("Maintenant que vous avez fait connaissance, vous poursuivez votre objectif : vous évader.");
                Console.ReadKey();
                Console.WriteLine("Vous aurez besoin d'aide dans votre évasion. Il est temps de recruter! Voyon voir si votre compagnon veut se joindre à vous.");
                Console.ReadKey();
                Console.WriteLine("1 - Accepte ou 2 - Refuse");
                choix1 = Convert.ToInt32(Console.ReadLine());

                if (choix1 == 1) //Accepte
                {
                    if (choix == 1) // Accepte + amitié
                    {
                        Console.WriteLine("Bien joué! Vous avez recruté votre compagnon de cellule.");
                    }
                    else if (choix == 2 && luck <= 50) //Accepte + non amitié
                    {
                        Console.WriteLine("Super! Votre compagnon de cellule se joint à vous. (Espérons que c'est un bon choix.)");
                    }
                    else // Pas de chance
                    {
                        Console.WriteLine("Oups... on dirait qu'il n'a pas aimé votre proposition. Avec un peu de chance, il nous laissera tranquille durant l'évasion.");
                    }
                }
                else if (choix1 == 2) // Restez seul
                {
                    Console.WriteLine("Vous pensez à votre compagnon de cellule, et puis non. Trouvons d'autres personnes alors.");
                }
                else //have fun
                {
                    Console.WriteLine("Vous devez choisir une option");
                }
            }

            Console.ReadKey();
            Console.Clear();

            //Préparation (3)  

            Console.WriteLine("Après un mois, vous avez appris la connaissance de plusieurs types personnes.");
            Console.ReadKey();
            Console.WriteLine("Comme s'évader seul est impossible, vous aurez à recruter afin de garantir le succès de votre évasion.");
            Console.ReadKey();
            Console.WriteLine("1 - Avoir gang 2 - Personnes de confiance ou 3 - Rester seul");
            choix2 = Convert.ToInt32(Console.ReadLine());

            if (choix2 == 1)
            {
                if (luck <= 35)  // gang
                {
                    Console.WriteLine("Vous recrutez un gang en échange de les faire évader mais votre compagnon vous abandonne. ");
                }
                else if (luck >= 36)
                {
                    Console.WriteLine("Vous avez échouez dans votre recrutement! Vous restez donc avec votre compagnon de cellule.");
                }
            }
            else if (choix2 == 2)    // personne de confiance
            {
                Console.WriteLine("Vous tentez de recrutez des détenus qui vous semblent de confiance mais votre compagnon vous abandonne. ");
            }
            else if (choix2 == 3)  // alone
            {
                if (choix == 1 && choix1 == 1) // Amitié + Proposition 
                {
                    Console.WriteLine("Vous préféré restez seul avec votre compagnon de cellule un peu idiot.");
                }
                else  // Restez seul
                {
                    Console.WriteLine("Vous préféré restez seul.");
                }
            }
            else if (choix2 != 1 && choix2 != 2 && choix2 != 3) // oops ^^
            {
                Console.WriteLine("Comme vous n'avez pas compris, et bien votre compagnon vous abandonne HAHAHA!!!");
            }

            Console.ReadKey();
            Console.Clear();

            // Fin préparation

            // Début recherche objet (4)

            Console.WriteLine("Vous devez maintenant trouvé le nécessaire à votre évasion. ");
            Console.ReadKey();
            Console.WriteLine("1 - Salle de travail des détenus 2 - Salle des gardiens ou 3 - Fouiner dans les cellules ");
            choix3 = Convert.ToInt32(Console.ReadLine());

            if (choix3 == 1)
            {
                if (luck <= 45)   // Salle de travail
                {
                    Console.WriteLine("Vous avez réussi à obtenir le matériel nécéssaire. ");
                }
                else
                {
                    Console.WriteLine("Vous avez échouez à trouvé le matériel nécéssaire. Vous devrez vous débrouillez. ");
                }
            }
            else if (choix3 == 2)  // Salle des gardiens
            {
                if (luck <= 15)
                {
                    Console.WriteLine("BRAVO! Vous avez réussi à voler les guardiens! Vous n'avez pas froid au yeux! ");
                }
                else
                {
                    Console.WriteLine("Vous avez échouez lamentablement. Et les gardes vous tabassent pour vous donnez une bonne leçon. Vous n'avez pas d'outils donc vous ferez sans.");
                }
            }
            else if (choix3 == 3)  // Cellules
            {
                if (luck <= 75)
                {
                    Console.WriteLine("Vous fouillez. Vous fouillez. Et vous fouillez encore. Oh! Vous avez trouvez du matériel, quoique en mauvaise qualité, mais ferras bien le travail demandé, je crois. ");
                }
                else
                {
                    Console.WriteLine("Vous n'avez malheureusement rien trouvé qui aurais pu vous aidez.");
                }
            }

            Console.ReadKey();
            Console.Clear();

            // Fin recherche objet.

            //Début évasion (fin) (5)

            Console.WriteLine("Nous sommes désormais rendu au moment fatidique! Vous devrez vous échappez de la prison selon votre choix. ");
            Console.ReadKey();
            Console.WriteLine("1 - Pour vous évadez de nuit 2 - Pour vous évadez lors de la pause ou 3 - Pour vous échappez sur votre heure de travail obligatoire ");
            choix4 = Convert.ToInt32(Console.ReadLine());

            if (choix4 == 1) //evasion nuit
            {
                if (choix2 == 1 && luck >= 36 && escape <= 10) //1
                {
                    Console.WriteLine("Super! Vous avez réussi à vous évadez à l'aide de votre compagnon!");
                }
                else if (choix2 == 1 && luck <= 35 && escape <= 25)
                {
                    Console.WriteLine("Bien joué ! Vous avez réussi à vous évadez grâce au gang! Mais vous êtes encore poursuivit alors prudence!"); // 2
                }
                else if (choix == 1 && choix1 == 1 && choix2 == 3 && luck <= 5)
                {
                    Console.WriteLine("Wow ! Malgré que votre compagnon à presque gâché votre évasion, vous en êtes sortie vainqueur! Alors n'y pensez plus.. "); // 3
                }
                else if (choix2 == 2 && escape <= 40)
                {
                    Console.WriteLine("Merveilleux! Vous avez réussi à vous évadez grâce à la confiance que vous avez portez en ces personnes!"); // 4
                }
                else if (choix == 2 && choix1 == 2 && choix2 == 3 && escape <= 5)
                {
                    Console.WriteLine("Ouff !!! Vous avez réussi à vous en sortir seul jusqu'au bout! BRAVO!!! "); // 5
                }
                else
                {
                    Console.WriteLine("Oups.. Il semblerais que vous avez échouez lors de votre évasion...");
                }
            }
            else if (choix4 == 2) //evasion pause
            {
                if (choix2 == 1 && luck >= 36 && escape <= 30) //1
                {
                    Console.WriteLine("Bien joué ! Votre compagnon vous à été d'une grande aide malgré tout!");
                }
                else if (choix2 == 1 && luck <= 35 && escape <= 35) //2
                {
                    Console.WriteLine("C'étais chaud! Allez faite vite! La police et les chiens sont encore à vos trousses! Continuer de courrir et c'est bon!");
                }
                else if (choix == 1 && choix1 == 1 && choix2 == 3 && luck <= 25) //3
                {
                    Console.WriteLine("My god! Vous avez réussi votre évasion ET retrouvé votre liberté avec l'aide de votre compagnon, enfin pas totalement mais c'est mieux que d'être enfermé pour les 38 mois à venir n'est-ce pas? ");
                }
                else if (choix2 == 2 && luck <= 40) //4
                {
                    Console.WriteLine("Merveilleux! Vous avez réussi à vous évadez et sans eux cela aurait été impossible! Vous lez remerciez et partez chacun de votre coté.");
                }
                else if (choix == 2 && choix1 == 2 && choix2 == 3 && escape <= 10) //5
                {
                    Console.WriteLine("Ouff! C'était presque trop risqué mais parfois le travail est mieux fait par soi-même! ");
                }
                else
                {
                    Console.WriteLine("Oups.. Il semblerais que vous avez échouez lors de votre évasion...");
                }
            }
            else if (choix4 == 3) //evasion travail
            {
                if (choix2 == 1 && luck >= 36 && escape <= 25) //1
                {
                    Console.WriteLine("Vive la liberté! Votre compagnon n'aura pas servi à rien finalement!");
                }
                else if (choix2 == 1 && luck <= 35 && escape <= 40) //2
                {
                    Console.WriteLine("Choisir le gang n'était pas la meilleure option mais vous êtes en liberté maintenant. Allez, vite avant que l'on vous rattrape!");
                }
                else if (choix == 1 && choix1 == 1 && choix2 == 3 && luck <= 15) //3
                {
                    Console.WriteLine("Oh vous avez réussi! Votre compagnon n'a pas été à la hauteur et vous avez été obligé de le laisser en arrière, tant pis, maintenant courrez! ");
                }
                else if (choix2 == 2 && luck <= 50) //4
                {
                    Console.WriteLine("Vous n'oublierez jamais ces personnes et cela vous fera une histoire à raconter pour vos petits enfants.");
                }
                else if (choix == 2 && choix1 == 2 && choix2 == 3 && escape <= 20)
                {
                    Console.WriteLine("Vos efforts ont été récompensé! Après de longs jours en cavale, vous êtes finalement en liberté! ");
                }
                else
                {
                    Console.WriteLine("Oups.. Il semblerais que vous avez échouez lors de votre évasion...");
                }
            }
            else if (choix4 != 1 && choix4 != 2 && choix4 != 3) //oops
            {
                Console.WriteLine("Dommage! Vous n'avez pas écoutez les instructions et les gardes vont ont pris la main dans le sac!");
            }
            else
            {
                Console.WriteLine("Vous êtes cuits! On vous a repéré! Direction votre cellule immédiatement! ");
            }


            // Fin lab prison   


            Console.ReadKey();

        }
    }
}
