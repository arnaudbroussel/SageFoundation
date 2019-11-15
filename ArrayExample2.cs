using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageFoundation {
    class ArrayExample2 {
        public static void Go() {
            // Matriz de valores de 2 dimensiones, 3 linias et 5 columnas.
            int[,] a =   {
                          { 1, 2, 3, 4, 5 },
                          { 9, 3, 4, 5, 7 },
                          { 8, 3, 4, 0, 0 }
                          };

            // Primera bucle (o rotación) para recoger la linias de la matriz
            for (int row = 0; row < 3; row++) {
                // Secunaa bucle (o rotación) para recoger la columnas de la matriz
                for (int col = 0; col < 5; col++) {
                    Console.WriteLine("Element at [{0},{1}] = {2}", row, col, a[row, col]);
                }
            }
        }
    }
}