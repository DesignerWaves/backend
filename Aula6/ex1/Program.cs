using System;

namespace ex1 {
    class Program {
        static void Main (string[] args) { 
            
            //chamamoms nossa primeria função 
            Console.WriteLine (BomDia ());

            //chamamos nossa primeria função do tipo void sem retorno
            ImprimeDataHora ();

            //chamamos nossa função que calcula a meida
            double[] numero = { 2 , 5 , 2 };
            Console.WriteLine(CalculaMedia(numero));


        }

        /// <summary>
        /// Função que escreve bom dia para o usuario
        /// </summary>
        /// <returns>Retorno Ola! Bom dia</returns>
        static string BomDia () {
            return "Olá!, Bom dia!";
        }

        /// <summary>
        /// Função que mostra uma saudação de acordo com o horario atual 
        /// </summary>
        /// <param name="saudacao">um texto qualquer (sobrecarga de metodo)</param>
        /// <returns>Saudação de acordo com o horario</returns>
        static string BomDia (string saudacao) {

            int hora = DateTime.Now.Hour;

            if (DateTime.Now.Hour <= 12) {
                saudacao = "bom dia";
            } else if (hora > 12 && hora <= 18) {
                saudacao = "boa tarde";

            } else {
                saudacao = "boa noite";
            }

            return saudacao;

        }

        /// <summary>
        /// Retorna um numero - teste de sobrecarga 
        /// </summary>
        /// <param name="numero">Um numero inteiro qualquer</param>
        /// <returns>Número passado como parametro</returns>

        static int BomDia (int numero) {
            return numero;
        }

        /// <summary>
        /// Retorna data e hora atuais
        /// </summary>
        static void ImprimeDataHora () {
            Console.WriteLine (DateTime.Now.ToShortDateString ());
            Console.WriteLine (DateTime.Now.Hour.ToString ());
        }
        
        /// <summary>
        /// Função que calcula a media de um vetor
        /// </summary>
        /// <param name="valores">Vetores com valores</param>
        /// <returns>Media dos valores</returns>
        static double CalculaMedia (double[] valores) {
            double resultado = 0;

            for (int i = 0; i < valores.Length; i++) {
                resultado += valores[i];
            }

            resultado = resultado / valores.Length;

            return resultado;
        }
    }
}