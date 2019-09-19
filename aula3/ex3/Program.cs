using System;

namespace ex3 {
    class Program {
        static void Main (string[] args) {
            int num = 1;
            int var = 0;
            

            Console.WriteLine ("Digite um valor:\n");
            var = int.Parse (Console.ReadLine ());

            do {
                if( num % 5 == 0){
                Console.WriteLine(num);
                }
                num++; //incremento para ir aumentando o numero
            } while (num <= var); 
// determinei o valor inicial e o valor final o usuario que digita assim os numeros que estao entre eles, todos os que são multiplos de 5 são printados na tela
            

        }

    }
}
