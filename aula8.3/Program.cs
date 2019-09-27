using System;

namespace aula8._3 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Digite o valor: ");
            double valor = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite o desconto: ");
            int desconto = int.Parse (Console.ReadLine ());

            System.Console.WriteLine (DescontoValor (valor, desconto));

        }


/// <summary>
/// Desconto Valor
/// </summary>
/// <param name="valor">Preço da mercadoria</param>
/// <param name="porcento">Percentula do desconto</param>
/// <returns>Valor já descontado</returns>
        static double DescontoValor (double valor, double porcento) {

            double desconto = valor -( valor * ( porcento / 100));
            return desconto;
        }

    }
}