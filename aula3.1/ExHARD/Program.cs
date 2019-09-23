using System;

namespace ExHARD {
    class Program {
        static void Main (string[] args) {
            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            DateTime[] data_ida = new DateTime[5];
            DateTime[] data_volta = new DateTime[5];
            string sair = "";

            while (sair != "0") {
                Console.WriteLine ("Bem vindo ao nosso sistema de passagens! ");
                Console.WriteLine ("Menu: ");
                Console.WriteLine ("1 - Cadastrar");
                Console.WriteLine ("2 - Listar passagem");
                Console.WriteLine ("0 - Sair");

                switch (sair) {
                    case "1":
                        for (int batata = 0; batata <= 4; batata++) {

                            Connsole.WriteLine ("Nome do passageiro: ");
                            nome[batata] = Console.ReadLine ();

                            Console.WriteLine ("Digite a UF de origem: ");
                            origem[batata] = Console.ReadLine ();

                            Console.Write ("Digite a data de IDA: ");
                            data_ida[batata] = DateTime.Parse (Console.ReadLine ());

                            Console.WriteLine ("Digite a data de volta");
                            data_volta[batata] = DateTime.Parse (Console.ReadLine ());

                            Console.WriteLine ("Dados cadastrados com sucesso!!!");

                        }
                        break;

                    case "2":
                        if () {

                        }

                        break;
                }
            }

        }
    }
}