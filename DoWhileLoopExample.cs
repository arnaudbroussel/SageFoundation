using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageFoundation {
    class DoWhileLoopExample {
        public static void Go() {

            Console.WriteLine("Do-While loop example");

            // Déclarez une variable x et lui attribuez une valeur de 2.
            int x = 2;

            // Exécutez le bloc au moins une fois.
            // Après chaque itération (iteration), il vérifie la condition,
            // Si la condition est vraie, le bloc sera exécuté.
            // ​​​​​​​
            do {
                Console.WriteLine("Value of x = {0}", x);

                x = x + 3;

            } while (x < 10);
            // Remarque : il devrait y avoir un point-virgule (;) ici.
            Console.ReadLine();
        }
    }
}