using System;

namespace ex2 {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[12];
            string[] cor = new string[12];
            string[] tamanho = new string[12];
            double[] preco = new double[12];
            int quant = 0; 


            Console.WriteLine("Digite quantos produtos você quer cadastrar: ");
            quant = int.Parse(Console.ReadLine());

            for (int i = 0; i <= quant - 1; i++) {
                Console.WriteLine ("Insira o nome do produto: ");
                nome[i] = Console.ReadLine ();

                Console.WriteLine ("Insira a cor do produto: ");
                cor[i] = Console.ReadLine ();

                Console.WriteLine ("Insira o tamanho do produto: ");
                tamanho[i] = Console.ReadLine ();

                Console.WriteLine ("Insira o preço do produto: ");
                preco[i] = double.Parse(Console.ReadLine ());

            }
            for (int i = 0; i <= quant - 1; i++) {
                Console.WriteLine ($"\n\nNome: {nome[i]}");

                Console.WriteLine ($"\nCor: {cor[i]}");

                Console.WriteLine ($"\nTamanho: {tamanho[i]}");

                Console.WriteLine ($"\npreço: {preco[i]}\n");

            }
        }
    }
}