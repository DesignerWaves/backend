using System;

namespace aula3 {
    class Program {
        static void Main (string[] args) {
            //laço contato - for - incremento (+)
            // for(int cont= 0 ; cont <= 100 ; cont++){

            //     // verificamos se o numero é diferente de :
            //     // cont % tem como fnalidade pegar verificar o resto da divisão e juntamente com o != (diferente) faz com que o pegue todos os numeros que nao tenham um valor exato como resultado e os exiba na tela

            //     if(cont % 2 != 0){
            //         Console.WriteLine(cont);

            //     }
            // }
            // //Lçao contado - for - decremetno (-)
            // for (int cont = 100 ; cont >= 0 ; cont--){
            //     if(cont % 2 != 0){
            //         Console.WriteLine("For 100 - 0 " + cont);
            //     }
            // }

            // Laço condição - while
            /*
            double nota = 0;
            string sair = "";
            double acumu = 0;
            int cont = 0;
            while ( sair != "sim") {
                Console.Write ("Digite a nota de um aluno: ");
                nota = double.Parse (Console.ReadLine ());
                if (nota != 1000) {
                    acumu += nota;
                    cont++;

                    Console.Write ("Deseja sair da aplicação? Sim/Nao");
                    sair = Console.ReadLine ().ToLower ();
                }
                Console.Write ("medias das notas " + (acumu / cont));

            } */

            /*
            Problema:

            faça um algoritimo que leia 20 numeros inteiros e acumule os numeros multiplos de 3
            */

            // Laçocondicional do / while
            int cont = 1, acumu = 0, var1 = 0;

            do {
                Console.WriteLine ("Escreva um numero: ");
                var1 = int.Parse (Console.ReadLine ());
                if (var1 % 3  == 0) {
                    acumu += var1;
                }

                cont++;
            } while (cont <= 3); {
                Console.WriteLine (acumu);

            }

        }

    }
}