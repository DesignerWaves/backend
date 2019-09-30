using System;
using System.IO;
using aula11_POO.Models;

namespace aula11_POO.controllers {
    public class ProdutosController {

        ProdutosModel produto = new ProdutosModel ();

        public void CadastrarProduto () {

            try {

                Console.WriteLine ("Digite o id do produto: ");
                produto.idproduto = int.Parse (Console.ReadLine ());

                System.Console.WriteLine ("Digite o nome do produto: ");
                produto.nomeproduto = Console.ReadLine ();

                System.Console.WriteLine ("Digite a descrição do produto: ");
                produto.descricao = Console.ReadLine ();

                System.Console.WriteLine ("Digite o preço do produto: ");
                produto.preco = double.Parse (Console.ReadLine ());

                // System.Console.WriteLine ("Digite o id do fornecedor: ");
                // produto.fornecedor.idfornecedor = int.Parse (Console.ReadLine ());

                // System.Console.WriteLine ("Digite o nome do fornecedor: ");
                // produto.fornecedor.nomefornecedor = Console.ReadLine ();

            }catch(Exception ex){

            System.Console.WriteLine("Desculpe, houve um erro na aplicação");
            SalvarErros(ex);

            }

        }

        /// <summary>
        /// exibe os produtos registrados para o usuario
        /// </summary>
        public void ExibirProduto () {

            System.Console.WriteLine (produto.idproduto);
            System.Console.WriteLine (produto.nomeproduto);
            System.Console.WriteLine (produto.descricao);
            System.Console.WriteLine (produto.preco);
            // System.Console.WriteLine (produto.fornecedor.idfornecedor);
            // System.Console.WriteLine (produto.fornecedor.nomefornecedor);

        }

        /// <summary>
        /// Salva os erros gerados pelo Sistema
        /// </summary>
        /// <param name="ex">erro retornado para o catch</param>
        private void SalvarErros (Exception ex) {

            StreamWriter txt = new StreamWriter ("error_log.txt", true);

            txt.WriteLine (DateTime.Now.ToLongDateString ());
            txt.WriteLine (DateTime.Now.ToShortTimeString ());
            txt.WriteLine (ex);
            txt.WriteLine ();

            txt.Close ();

        }

    }
}