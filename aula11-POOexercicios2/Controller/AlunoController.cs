using System;
using aula11_POOexercicios2.Model;

namespace aula11_POOexercicios2.Controller {
    public class AlunoController {
        AlunoModel Aluno = new AlunoModel ();

        public void DadosAluno () {

            try {
                System.Console.WriteLine ("Digite seu nome: ");
                Aluno.AlunoNome = Console.ReadLine ();

                do {
                    System.Console.WriteLine ("Digite o seu RG: ");
                    Aluno.AlunoRG = double.Parse (Console.ReadLine ());
                } while (!(Aluno.AlunoRG.Equals (typeof (double))));

                System.Console.WriteLine ("Digite o seu curso: ");
                Aluno.AlunoCurso = Console.ReadLine ();

                System.Console.WriteLine ("Você é bolsista? ( Sim / Não )");
                Aluno.Resposta = Console.ReadLine ();

            } catch (System.Exception) {
                Console.Clear ();
                System.Console.WriteLine ("Dado invalido!");

            }

        }

        public void ExibirDados () {

            System.Console.WriteLine ("\nNome do aluno: " + Aluno.AlunoNome);

            System.Console.WriteLine ("\nRG do aluno: " + Aluno.AlunoRG);
            System.Console.WriteLine ("\nCurso do aluno: " + Aluno.AlunoCurso);

            //transformei a string em true or false
            if (Aluno.Resposta == "Sim" || Aluno.Resposta == "S" || Aluno.Resposta == "sim" || Aluno.Resposta == "s") {
                Aluno.AlunoBolsa = true;
            } else if (Aluno.Resposta == "Não" || Aluno.Resposta == "N" || Aluno.Resposta == "não" || Aluno.Resposta == "nao" || Aluno.Resposta == "n") {
                Aluno.AlunoBolsa = false;
            }

            //peguei a informação true or false e a repasei no if
            if (Aluno.AlunoBolsa == true) {
                System.Console.WriteLine ("\nO aluno é bolsista");
            } else {
                System.Console.WriteLine ("\nO aluno não é bolsista");
            }
        }

    }
}