using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string pedido, numero;
            
            Console.Write("Digite o numero do seu pedido: ");
            numero = Console.ReadLine();


            switch(numero){

            case "1":
            pedido = "Switch - Hamburguer";
            break;

            case "2":
            pedido = "Switch - Cheese Salada";
            break;

             case "3":
            pedido = "Switch - Cheese Burger";
            break;

             case "4":
            pedido = "Switch - Cheese Bacon";
            break;

            default:
            pedido = "Switch - Entrada inválida! :(";
            break;


            }

            Console.Write(pedido);

        }
    }
}
