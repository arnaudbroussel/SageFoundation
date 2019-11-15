using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageFoundation {
    class ArrayExample1 {
        public static void Go() {
            // Méthode 1:
            // Déclarez un tableau de int, spécifie les éléments.
            int[] years = { 2001, 2003, 2005, 1980, 2003 };

            // Length est une propriété du tableau, elle renvoie le nombre d'éléments.
            Console.WriteLine("Element count of array years = {0} \n", years.Length);

            // Utilisez une boucle for pour imprimer les éléments du tableau.
            for (int i = 0; i < years.Length; i++) {
                Console.WriteLine("Element at {0} = {1}", i, years[i]);
            }

            // Méthode 2:
            // Déclarez un tableau de flot, en spécifiant le nombre d'éléments.
            // (3 éléments)
            float[] salaries = new float[3];

            // Attribuez des valeurs aux éléments.
            salaries[0] = 1000;
            salaries[1] = 1200;
            salaries[2] = 1100;

            Console.ReadLine();
        }
    }
}