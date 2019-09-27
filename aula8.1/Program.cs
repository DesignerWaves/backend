using System;

namespace aula8._1 {
    class Program {
        static void Main (string[] args) {

            int numero;

            try {
                //tratamento de erro
                //escrevremos um bloco de codigo
                Console.WriteLine ("Digite um numero: ");
                numero = int.Parse(Console.ReadLine());

            }catch(Exception ex){

//Mostrammos a execeção da regra
//Erro gerado na aplicação
                Console.WriteLine("Erro" + ex);

            }
        }
    }
}