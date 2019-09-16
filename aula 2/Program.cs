using System;

namespace aula_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos as notas que 
            double nota1, nota2, nota3, media;

            // Capturamos a 1º nota
            Console.Write("Digite a sua primeira nota: ");
            nota1 = double.Parse( Console.ReadLine());

            // Capturamos a 2º nota
            Console.Write("Digite a sua primeira nota: ");
            nota2 = double.Parse( Console.ReadLine());

            // Capturamos a 3º nota
            Console.Write("Digite a sua primeira nota: ");
            nota3 = double.Parse( Console.ReadLine());

            //Tratamento dos dados  
            media = (nota1+nota2+nota3) / 3;

            //Verificamos se a media do aluno é maior ou igual
            if( media >= 6 ){
                Console.WriteLine($"A media do aluno foi {media}, logo o aluno está aprovado");

            } else {
                Console.WriteLine($"A media do aluno foi {media}, logo o aluno está reprovado");
            }

        }
    }
}
