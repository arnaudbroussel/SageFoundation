using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageFoundation {
    class IfElseExample {
        public static void Go() {
            // Déclarez un entier du type int, décrit votre âge.
            int age;

            Console.WriteLine("Please enter your age: \n");

            // Déclarez une variable pour stocker l'extrait du texte que l'utilisateur a saisi à partir du clavier.
            string inputStr = Console.ReadLine();

            // Int32 est une classe qui se trouve dans l'espace de noms System.
            // Utilisez la méthode statique Parse de la classe Int32 pour convertir une chaîne en nombre
            // Et attribuez à la variable age.
            // (Remarque: Si 'inputStr' n'est pas de chaîne en nombre, une erreur de programme se produira ici).
            
            age = Int32.Parse(inputStr);

            Console.WriteLine("Tu edad: {0}", age);

            // Vérifiez si l'âge est inférieur à 80 alors ...
            if (age < 80) {
                Console.WriteLine("You are pretty young");
            }

            // Sinon, si l'âge entre 80 et 100 ans, alors
            else if (age >= 80 && age <= 100) {
                Console.WriteLine("You are old");
            }
            // Sinon, (Les cas restants)
            else {
                Console.WriteLine("You are verry old");
            }

            Console.ReadLine();
        }
    }
}