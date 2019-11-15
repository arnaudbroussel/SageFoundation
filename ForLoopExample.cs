using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageFoundation {
    class ForLoopExample {
        public static void Go() {
            Console.WriteLine("For loop example");

            Console.WriteLine("Bucle numero = {0}", 1);
            Console.WriteLine("Bucle numero = {0}", 2);
            Console.WriteLine("Bucle numero = {0}", 3);
            Console.WriteLine("Bucle numero = {0}", 4);
            Console.WriteLine("Bucle numero = {0}", 5);
            Console.WriteLine("Bucle numero = {0}", 6);
            Console.WriteLine("Bucle numero = {0}", 7);

            Console.WriteLine();

            for (int x = 1; x <= 99; x = x + 5) {
                Console.WriteLine("Bucle numero = {0}", x);
                Console.WriteLine("Sumame {0}+{0}={1} ", x, x + x);
                Console.WriteLine("Multiplicame {0}x{0}={1} ", x, x*x);
                Console.WriteLine();
            }

            // Déclarez la variable x et lui attribuez la valeur de 2
            // La condition est x <15
            // Si x <15 est vraie alors exécutez le bloc.
            // Après chaque itération (iteration), la valeur de x est augmentée de 3.
            //for (int x = 2; x < 15; x = x + 3) {
            //    Console.WriteLine();
            //    Console.WriteLine("Estamo mirando eso... Value of x = {0}", x);
            //}

            //Console.ReadLine();
        }
    }
}