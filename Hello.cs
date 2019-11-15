using System;

namespace SageFoundation {
    class Hello {

        static string studentName = "NO SOY NADIE";

        static void Main(string[] args) {
            ConsoleKeyInfo cki;
            do {
                DisplayMenu();
                cki = Console.ReadKey(false);
                Console.WriteLine();
                switch (cki.KeyChar.ToString()) {
                    case "0":
                        QuienEres();
                        break;
                    case "1":
                        VariableExample.Go(studentName); ;
                        break;
                    case "2":
                        IfElseExample.Go();                        
                        break;
                    case "3":
                        ForLoopExample.Go();                        
                        break;
                    case "4":
                        WhileLoopExample.Go();                        
                        break;
                    case "5":
                        DoWhileLoopExample.Go();                        
                        break;
                    case "6":
                        LoopBreakExample.Go();   
                        break;
                    case "7":
                        LoopBreakExample.Go();
                        break;
                    case "8":
                        ArrayExample1.Go();
                        break;
                    case "9":
                        ArrayExample2.Go();
                        break;
                }
                cki = Console.ReadKey(false);
            } while (cki.Key != ConsoleKey.Escape);
        }

        static void QuienEres() {
            Console.Write("Como te llamas ? ");
            studentName = Console.ReadLine();
        }

        static public void DisplayMenu() {
            Console.WriteLine();
            Console.WriteLine("SAGE RAVI FOUNDATION");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine("0. Quien eres ?");
            Console.WriteLine("1. Variable");
            Console.WriteLine("2. If Else");
            Console.WriteLine("3. For Loop");
            Console.WriteLine("4. While Loop");
            Console.WriteLine("5. Do While Loop");
            Console.WriteLine("6. Loop Continue");
            Console.WriteLine("7. Break");
            Console.WriteLine("8. Array 1");
            Console.WriteLine("9. Array 2");
            Console.WriteLine("(esc to exit)");
            Console.WriteLine();
        }
    }
}