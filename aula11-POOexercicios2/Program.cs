using System;
using aula11_POOexercicios2.Controller;

namespace aula11_POOexercicios2 {
    class Program {
        static void Main (string[] args) {
            AlunoController aluno = new AlunoController ();

            Console.Clear ();
            
            aluno.DadosAluno ();

            aluno.ExibirDados ();

        }
    }
}