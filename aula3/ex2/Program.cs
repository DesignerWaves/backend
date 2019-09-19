using System;

namespace ex2 {
    class Program {
        static void Main (string[] args) {
            int num1 = 1;
            int var1;

            Console.Write ("Digite o número:\n");
            var1 = int.Parse (Console.ReadLine ());

            for ( num1 = 1; num1 <= 10; num1++) { 
                Console.Write("\n" + var1 + " x " + num1 + " = " + (var1*num1));

            }

           
        }
    }
}