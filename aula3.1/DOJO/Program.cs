using System;

namespace DOJO {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[10];
            double[] preco = new double[10];
            int i = 0;
            int menu = 0;
            double soma = 0;

            string sair = "";

            Console.WriteLine ("Bem vindo ao nosso sistema!\n Menu\n 1-Cadastrar Produto\n 2-Listar Produtos\n 3-Calcular Soma dos Preços");
            menu = int.Parse (Console.ReadLine ());

            switch (menu) {
                case 1:

                    while (sair != "s" || i <= 9) {

                        Console.WriteLine ("Cadastro de produto\n digite o nome do produto: ");
                        nome[i] = Console.ReadLine ();

                        Console.WriteLine ("Preço do produto: ");
                        preco[i] = double.Parse (Console.ReadLine ());
                        i++;

                        Console.WriteLine ("Deseja sair?\n s/n");
                        sair = Console.ReadLine ();
                    }
                    break;

                case 2:
                    if (nome[i] == "") {
                        Console.WriteLine ("Não há produtos cadastrados");
                    } else {
                        for (i = 0; i <= 9; i++) {
                            Console.WriteLine ($"{nome[i]}, o R$ {preco[i]}");
                        }
                    }
                    break;

                case 3:
                    for (i = 0; i <= 9; i++) {
                        soma += preco[i];
                        Console.WriteLine ($"A soma dos produtos cadastrados é {soma}");
                    }
                    break;

                    

            }

        }
    }
}