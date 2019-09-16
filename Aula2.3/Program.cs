using System;

namespace Aula2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deixamos declarada como falsa por padrão
            bool entrada = false;
            int idade;
            string retorno;
            
            Console.Write("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());

            // Como já atribuimos anteriormente, mudamos o status da variavel para verdadeira caso entre nessa condição 
            if ( idade > 17 ){
                entrada = true;
            }

            if( entrada == true){
                retorno = "Entrada permitida!!!";
            }else{
                retorno = "Entrada não permitida >3<";
            }

            Console.WriteLine(retorno);

            
        }
    }
}
