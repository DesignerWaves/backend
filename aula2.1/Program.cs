using System;

namespace aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos as notas que 
            float  nota1, nota2, nota3, media;
            string resultado;

            // Capturamos a 1º nota
            Console.Write("Digite a sua primeira nota: ");
            nota1 = float.Parse( Console.ReadLine());

            // Capturamos a 2º nota
            Console.Write("Digite a sua segunda nota: ");
            nota2 = float.Parse( Console.ReadLine());

            // Capturamos a 3º nota
            Console.Write("Digite a sua terceira nota: ");
            nota3 = float.Parse( Console.ReadLine());

            //Tratamento dos dados  
            media = (nota1+nota2+nota3) / 3;

            //Verificamos se a media do aluno é maior ou igual
            if( media >= 6 ){
                resultado = "aprovado";
            } else if( media < 6 && media >= 4 ){
                resultado = "Recuperação";
            }else{
                resultado = "Reprovado";
            }

            Console.WriteLine($"Média : {media} - Aluno {resultado} ");
        }
    }
}