using ControleFornecedoresApp.Entites;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace ControleFornecedoresApp.Services
{
    public class ControleService
    {

        private readonly CategoriaService _categoriaService = new();
        private readonly List<Produtos> _produtos = new();
        public IReadOnlyList<Produtos> ProdutosCadastrados => _produtos;

        public void ControleServices() 
        {
           

           
 
                Console.WriteLine("Bem-vindo a Central de Controle");
                Console.WriteLine("(1)- FORNECEDORES");
                Console.WriteLine("(2)- PRODUTOS");
                Console.WriteLine("(3)- CATEGORIAS");
                Console.WriteLine("(0) - SAIR");

                Console.Write("INFORME A OPEÇÃO DESEJADA..:");
                var opcao = int.Parse((Console.ReadLine() ?? string.Empty));
              

                

                switch (opcao)
                {
                    case 1:
                        FornecedorService fornecedorService = new FornecedorService();
                        fornecedorService.FornecedorServices();
                    

                    if (opcao == 1)
                    {
                                Console.WriteLine("DESEJA VOLTAR AO MENU PRINCIPAL? (S/N)");
                                var resposta = Console.ReadLine();
                                if (resposta?.ToUpper() == "S")
                                {
                                    ControleServices();
                                }
                                else
                                {
                                    Console.WriteLine("ENCERRANDO...");
                                    Console.Clear();
                                   

                                }
                       
                    }
                    goto case 2;


                case 2:
                        ProdutoService produtoService = new ProdutoService();
                        produtoService.ProdutoServices();
                    

                    if (opcao == 2) 
                    {
                        Console.WriteLine("DESEJA VOLTAR AO MENU PRINCIPAL? (S/N)");
                        var resposta = Console.ReadLine();
                        if (resposta?.ToUpper() == "S")
                        {
                            ControleServices();
                        }
                        else
                        {
                            Console.WriteLine("ENCERRANDO...");
                            Console.Clear();
                            
                           
                        }
                   
                    }
                    goto  case 3;  

                    case 3:
                        CategoriaService categoriaService = new CategoriaService();
                        categoriaService.CategoriaServices();

                    if (opcao == 3)
                    {
                        Console.WriteLine("DESEJA VOLTAR AO MENU PRINCIPAL? (S/N)");
                        var resposta = Console.ReadLine();
                        if (resposta?.ToUpper() == "S")
                        {   
                           
                            ControleServices();
                        }
                        else 
                        {
                            Console.WriteLine("ENCERRANDO...");
                            Console.Clear();
                            ControleServices();
                        }
                    } 
                    break;

                   
                    
                   

                    case 0:
                        Console.WriteLine("ENCERRANDO...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVÁLIDA");
                        break;
                } while (opcao != 0)
                  Console.Clear();
                  return;

            


        }

        
    }
}
