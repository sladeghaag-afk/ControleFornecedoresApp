using System;
using System.Collections.Generic;
using System.Text;
using ControleFornecedoresApp.Entites;



namespace ControleFornecedoresApp.Services
{
    public class ProdutoService
    {
        public readonly CategoriaService _categoriaService = new();
        public readonly List<Produtos> _produtoService = new();
        public IReadOnlyList<Produtos> CadastrarProduto => _produtoService;

        public void ProdutoServices()
        {
            var produto = new Produtos ();
         
            Console.WriteLine("CADASTRE UM PRODUTO");
            Console.Write("INFORME O NOME DO PRODUTO..: ");
            produto.Nome = Console.ReadLine() ?? string.Empty;
            Console.Write("INFORME O PREÇO DO PRODUTO..: ");
            produto.Preco = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("INFORME A QUANTIDADE DO PRODUTO..: ");
            produto.Quantidade = int.Parse(Console.ReadLine() ?? "0");
           
         
        }




    }

}
