using System;

namespace Ex1 {
    class Program {
        static void Main (string[] args) {
            int[] var1 = new int[10];
            int[] var2 = new int[10];

            for (int i = 0; i <= 9; i++) {
                Console.WriteLine ("Digite um valor: ");
                var1[i] = int.Parse (Console.ReadLine ());
            }
            for (int i = 0; i <= 9; i++) {
                var2[i] = var1[i];
            }

            for (int i = 0 ; i <= 9 ; i++){
                Console.WriteLine(var2[i]);
            }
            Console.WriteLine(var2[9] * 5);
        }
    }
}