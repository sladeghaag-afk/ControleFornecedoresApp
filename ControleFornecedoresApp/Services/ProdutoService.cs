using System;
using System.Collections.Generic;
using System.Text;
using ControleFornecedoresApp.Entites;

namespace ControleFornecedoresApp.Services
{
    public class ProdutoService
    {

        public void ProdutoServices()
        {
            var produto = new Produtos ();
            Console.WriteLine("Cadastre um produto");
            Console.Write("Informe o nome do produto: ");
            produto.Nome = Console.ReadLine() ?? string.Empty;
            Console.Write("Informe o preço do produto: ");
            produto.Preco = double.Parse(Console.ReadLine() ?? "0");
            Console.Write("Informe a quantidade do produto: ");
            produto.Quantidade = int.Parse(Console.ReadLine() ?? "0");

        }




    }

}
