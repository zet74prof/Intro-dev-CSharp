//Appel de la méthode WriteLine() de la classe statique Console
Console.WriteLine("J\'ai appelé ici la méthode WriteLine() depuis la classe Console");

//Certaines classes ne peuvent être utilisé directement comme la classe Console qu'on dit "static"
//Il faut alors créer une instance de cette classe avec l'instruction new et stocker cette instance dans une variable

//1-Création de l'instance de la classe Random.
//Instance de classe = variable d'un type particulier définie dans la bibliothèque .Net = un objet
Random unObjetDeLaClasseRandom = new Random();
//2-appel de la méthode Next() de la classe Random à partir de l'objet créé
//Cette méthode renvoie comme résultat un nombre entier aléatoire entre 1 et 6 qu'on récupère dans la variable chiffreAleatoire
//(1,7) sont les 2 paramètres d'entrée attendus par la méthode Next()
int chiffreAleatoire = unObjetDeLaClasseRandom.Next(1, 7);
//3-Affichage du résultat
Console.WriteLine("Mon chiffre aléatoire est: " + chiffreAleatoire);

//Surcharge de méthode = la même méthode peut être appelé avec différents paramètres d'entrée
//Exemple avec la méthode Next() de la classe Random
chiffreAleatoire = unObjetDeLaClasseRandom.Next();
Console.WriteLine("Avec Next(), mon chiffre aléatoire est: " + chiffreAleatoire + "(entre 0 et l'infini)");
chiffreAleatoire = unObjetDeLaClasseRandom.Next(100);
Console.WriteLine("Avec Next(100), mon chiffre aléatoire est: " + chiffreAleatoire + "(situé entre 0 et 99)");
//Note: les paramètres d'une méthode sont séparés par une virgule
chiffreAleatoire = unObjetDeLaClasseRandom.Next(1, 7);
Console.WriteLine("Avec Next(1,7), mon chiffre aléatoire est: " + chiffreAleatoire + "(situé entre 1 et 6)\n");

//Quand elles ont terminé leur travail, les méthodes peuvent retourner une valeur ou rien du tout
