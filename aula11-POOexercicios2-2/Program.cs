using System;
using aula11_POOexercicios2_2.Controller;

namespace aula11_POOexercicios2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            CelularController celular = new CelularController();

            Console.Clear();

            celular.Ligado();

            celular.FazerLigacao();
        }
    }
}
