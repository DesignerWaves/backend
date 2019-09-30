using System;
using aula11_POO.controllers;

namespace aula11_POO {
    class Program {
        static void Main (string[] args) {
            ProdutosController produto1 = new ProdutosController ();

            produto1.CadastrarProduto ();
            produto1.ExibirProduto ();
            
        }
    }
}