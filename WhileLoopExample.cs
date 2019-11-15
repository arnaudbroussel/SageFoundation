using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageFoundation {
    class WhileLoopExample {
        public static void Go() {

            Console.WriteLine("While loop example");

            // Déclarez une varible x et lui attribuez la valeur de 2.
            int x = 2;

            // La condition est x < 10.
            // Si x < 10 est vrai alors exécutez le bloc.
            while (x < 10) {
                Console.WriteLine("Value of x = {0}", x);

                x = x + 3;
            }

            Console.ReadLine();
        }
    }
}