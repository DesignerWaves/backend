using System;

namespace fixacao {
    class Program {
        static void Main (string[] args) {
            int num1 = 0, acumu = 0, cont = 1;

            do {
                Console.Write ("Digite um numero inteiro:\n ");
                num1 = int.Parse (Console.ReadLine ());
                if (num1 % 5 == 0) {
                    acumu += num1;
                }
                cont++;
            } while (cont <= 3);
            Console.Write (acumu);
        }
    }
}