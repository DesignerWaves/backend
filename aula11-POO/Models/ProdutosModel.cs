namespace aula11_POO.Models
{
    public class ProdutosModel
    {
        public int idproduto { get ; set ; }

        public string nomeproduto { get ; set ; }

        public string descricao { get ; set ; }

        public double preco { get ; set ; }

        public fornecedoresModel fornecedor {get ; set ;}

        // pegar e exibir determinado valor ou declarar 
    }
}