using System;

namespace Explicação {
    class Program {
        static void Main (string[] args) {
            double[] media = new double[10];

            for (int i = 1; i < 10; i++) {
                Console.Write ("Digite uma media: ");
                media[i] = double.Parse (Console.ReadLine ());

            }
            Console.Write (media[3]);
            Console.WriteLine ();
            for (int i = 0; i < media.Length; i++) {
                Console.WriteLine ("Valores : " + media[1]);
            }
        }
    }
}