using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageFoundation {
    class LoopContinueExample {
        public static void Go() {

            Console.WriteLine("Continue example");

            // Déclarez une valeur x et lui attribuez une valeur de 2.
            int x = 2;

            while (x < 7) {

                Console.WriteLine("----------------------\n");
                Console.WriteLine("x = {0}", x);

                // L'opérateur % sert à calculer le reste.
                // Si x est pair, ignorez la ligne de commande ci-dessous de 'continuer',
                // et lancez un nouvel itérateur (si la condition est toujours vraie).
                if (x % 2 == 0) {
                    // Augmentez la valeur de x par 1. (écrit en bref x = x + 1;).
                    x++;
                    continue;
                }
                else {
                    // Augmentez la valeur de x par 1. (écrit en bref x = x + 1;).
                    x++;
                }
                Console.WriteLine("x after ++ = {0}", x);

            }

            Console.ReadLine();
        }
    }
}