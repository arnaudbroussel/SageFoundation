using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageFoundation {
    class LoopBreakExample {
        public static void Go() {
            Console.WriteLine("Break example");

            // Déclarez une variable x et lui attribuez une valeur de 2.
            int x = 2;

            while (x < 15) {

                Console.WriteLine("----------------------\n");
                Console.WriteLine("x = {0}", x);

                // Vérifiez si x = 5, quittez la boucle.
                if (x == 5) {
                    break;
                }
                // Augmentez la valeur de x par 1 (Écrit en bref x = x + 1;).
                // TOTO PEPE EC ....  x++;
                x = x + 1;
                Console.WriteLine("x after ++ = {0}", x);

            }

            Console.ReadLine();
        }
    }
}
