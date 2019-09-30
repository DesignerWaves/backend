using System;

namespace aula11_POOexercicios.Controller {
    public class imcModel {
        dadosModel dados = new dadosModel ();

        public void pegarvar () {

            System.Console.WriteLine ("Digite seu nome: ");
            dados.nome = Console.ReadLine ();

            System.Console.WriteLine ("Digite seu peso: ");
            dados.peso = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite sua altura: ");
            dados.altura = int.Parse (Console.ReadLine ());
        }

        public void imc () {

            double imc = 0;

            imc = dados.peso / (dados.altura * dados.altura);

            System.Console.WriteLine (imc);
            if (imc <= 18.5) {
                System.Console.WriteLine ("\nSua situação: Abaixo do peso");
            } else if (imc >= 18.5 && imc <= 25) {
                System.Console.WriteLine ("\nSua situação: Peso normal");
            } else if (imc >= 26 && imc <= 30) {
                System.Console.WriteLine ("\nSua situação: Sobrepeso");
            } else if (imc >= 31 && imc <= 35) {
                System.Console.WriteLine ("\nSua situação: Obesidade grau I");
            } else if (imc >= 36 && imc <= 39) {
                System.Console.WriteLine ("\nSua situação: Obesidade grau II");
            } else if (imc >= 40) {
                System.Console.WriteLine ("\nSua situação: Obesidade grau III");
            }
        }
    }
}
}