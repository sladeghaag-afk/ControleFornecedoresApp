using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using ControleFornecedoresApp.Entites;

namespace ControleFornecedoresApp.Services
{
    public class ControleService
    {
        public void ControleServices() 
        {
            Console.WriteLine("Bem-vindo a Central de Controle");
            Console.WriteLine("(1)- PRODUTOS");
            Console.WriteLine("(2)- FORNECEDORES");
            Console.WriteLine("(3)- CATEGORIAS");

            Console.Write("INFORME A OPEÇÃO DESEJADA..:");
            var opcao = int.Parse((Console.ReadLine()?? string.Empty ));

            switch (opcao)
            {
                case 1:
                    ProdutoService produtoService = new ProdutoService();
                    produtoService.ProdutoServices();
                    break;
                case 2:
                    FornecedorService fornecedorService = new FornecedorService();
                    fornecedorService.FornecedorServices();
                    break;
                case 3:
                    CategoriaService categoriaService = new CategoriaService();
                    categoriaService.CategoriaServices();
                    break;
                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA");
                    break;
            }




        } 
       




    }
}
