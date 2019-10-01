using System;
using aula11_POOexercicios1.Model;

namespace aula11_POOexercicios1.Controller {
    public class PessoaController {
        //Instancia do objeto 
        //PessoaModel está sendo puxada para dentro do PessoaController
        //"pessoa" é o objeto usado para trazer pessoa model para PessoaController
        PessoaModel pessoa = new PessoaModel ();

        public void DadosUsuario () {

            System.Console.WriteLine ("Digite seu nome: ");
            pessoa.NomePessoa = Console.ReadLine ();

            System.Console.WriteLine ("Digite o seu peso: ");
            pessoa.PesoPessoa = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Digite sua altura: ");
            pessoa.AlturaPessoa = double.Parse (Console.ReadLine ());

        }

        public void ImcUsuario () {

            pessoa.ImcPessoa = pessoa.PesoPessoa / (pessoa.AlturaPessoa * pessoa.AlturaPessoa);

            if (pessoa.ImcPessoa <= 18.5) {
                System.Console.WriteLine ("Abaixo do peso");
            } else if (pessoa.ImcPessoa >= 18.5 && pessoa.ImcPessoa <= 25) {
                System.Console.WriteLine ("Peso normal");
            } else if (pessoa.ImcPessoa >= 26 && pessoa.ImcPessoa <= 30){
                System.Console.WriteLine("Sobrepeso");
            }else if(pessoa.ImcPessoa >= 31 && pessoa.ImcPessoa <= 35){
                System.Console.WriteLine("Obesidade grau I");
            }else if(pessoa.ImcPessoa >= 36 && pessoa.ImcPessoa <= 39){
                System.Console.WriteLine("Obesidade grau II");
            }else if( pessoa.ImcPessoa >= 40){
            System.Console.WriteLine("Obesidade grau III");
            }
        }

        // System.Console.WriteLine();
        // pessoa.NomePessoa = Console.ReadLine();

    }
}