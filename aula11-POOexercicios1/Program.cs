using System;
using aula11_POOexercicios1.Controller;

namespace aula11_POOexercicios1
{
    class Program
    {
        static void Main(string[] args)
        {

            PessoaController pessoa = new PessoaController();

            Console.Clear();

            pessoa.DadosUsuario();

            pessoa.ImcUsuario();
        }
    }
}
