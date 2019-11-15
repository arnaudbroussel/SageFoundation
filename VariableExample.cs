using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageFoundation {
    class VariableExample {
        public static void Go(string studentName) {
            // Déclarez un constant du type int.
            // Vous ne pouvez pas attribuer de nouvelles valeurs pour les constantes.
            const int MAX_SCORE = 100;

            // Déclarez une variable du type int.
            int score = 0;

            // Attribuez une nouvelle valeur pour la variable score.
            score = 90;

            // Affichez la valeur de la variable dans l'écran Console.
            Console.WriteLine("Hi {0}", studentName);
            Console.WriteLine("Your score: {0}/{1}", score, MAX_SCORE);
        }
    }
}