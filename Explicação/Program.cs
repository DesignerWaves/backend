using System;

namespace aula2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string placa;
            string final;
            string resultado;

        Console.Write("Digite a placa do seu carro: ");
        placa = Console.ReadLine();


        //Contamos a quantidades de caracteres de um elemento
        int caracteres = placa.Length;

        //Pegamos o ultimo digito com o metodo substring();
        final = placa.Substring(caracteres - 1);

        if(final == "1" || final == "2") {
            resultado = "Seu rodizio é na segunda-feira";
        }else if(final == "3" || final == "4"){
            resultado = "Seu rodizio é na terça-feira";
        }else if(final == "5" || final == "6"){
            resultado = "Seu rodizio é na quarta-feira";
        }else if(final == "7" || final == "8"){
            resultado = "Seu rodizio é na quinta-feira";
        }else if(final == "9" || final == "0"){
            resultado = "Seu rodizio é na sexta-feira";
        }else{
            resultado = "Placa inválida!";
        }

        Console.Write(resultado);

        switch(final){

            case "1":
            resultado = "Switch - Segunda-Feira";
            break;

             case "2":
            resultado = "Switch - Segunda-Feira";
            break;

             case "3":
            resultado = "Switch - Terça-Feira";
            break;

             case "4":
            resultado = "Switch - Terça-Feira";
            break;

             case "5":
            resultado = "Switch - Quarta-Feira";
            break;

             case "6":
            resultado = "Switch - Quarta-Feira";
            break;

             case "7":
            resultado = "Switch - Quinta-Feira";
            break;

             case "8":
            resultado = "Switch - Quinta-Feira";
            break;

             case "9":
            resultado = "Switch - Sexta-Feira";
            break;

             case "0":
            resultado = "Switch - Sexta-Feira";
            break;

            default:
            resultado = "Switch - Entrada inválida! :(";
            break;
        }
        
        }
    }
}
