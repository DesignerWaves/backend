using System;

namespace ex4 {
    class Program {
        static void Main (string[] args) {
            int media = 0, num = 0, cont = 0, cont2= 0, acumu = 0;

            Console.Write ("Digite um valor: ");
            num = int.Parse (Console.ReadLine ());

            for (cont = 1; cont <= 19; cont++) {
                Console.Write ("Digite um valor: ");
                num = int.Parse (Console.ReadLine ());

                if (num >= 0) {
                    Console.WriteLine (num);

                } else {
                    cont2++;
                    acumu = acumu + num;
                }
            }
            Console.WriteLine ($"Media dos valores é {media=acumu/cont2}");
        }//
    }
}