using ControleFornecedoresApp.Entites;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace ControleFornecedoresApp.Services
{
    public class FornecedorService
    {
        private readonly List<Fornecedor> _fornecedores = new List<Fornecedor>();
        public void CadastrarFornecedor()
        {

            Console.WriteLine("CADASTRO DE FORNECEDORES");
            Console.Write("INFORME O NOME DO FORNECEDOR..:");
            var nomeFornecedor = Console.ReadLine() ?? string.Empty;
            Console.Write("INFORME O CNPJ DO FORNECEDOR..:");
            var cnpjFornecedor = Console.ReadLine() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nomeFornecedor) || string.IsNullOrWhiteSpace(cnpjFornecedor))
            {
                Console.WriteLine("NOME E CNPJ SÃO OBRIGATÓRIOS.");
              return;
            }

            // Aqui você pode adicionar a lógica para salvar o fornecedor em um banco de dados ou lista
            Console.WriteLine($"FORNECEDOR CADASTRADO COM SUCESSO: {nomeFornecedor} - {cnpjFornecedor}");


        }
        public void ListarFornecedores()
        {
            Console.WriteLine("\nLISTA DE FORNECEDORES");
            if (_fornecedores.Count == 0)
            {
                Console.WriteLine("NENHUM FORNECEDOR CADASTRADO.");
                return;
            }

            foreach (var f in _fornecedores)
            {
                Console.WriteLine($"NOME: {f.NomeFornecedor} | CNPJ: {f.CNPJ}");
            }


        }

        public void ExcluirFornecedor()
        {
            Console.WriteLine("\nEXCLUSÃO DE FORNECEDORES");
            Console.Write("INFORME O CNPJ DO FORNECEDOR..: ");
            var cnpj = Console.ReadLine() ?? string.Empty;

            var fornecedor = _fornecedores.Find(f => f.Cnpj == cnpj);

            if (fornecedor == null)
            {
                Console.WriteLine("FORNECEDOR NÃO ENCONTRADO.");
                return;
            }

            _fornecedores.Remove(fornecedor);
            Console.WriteLine($"FORNECEDOR EXCLUÍDO: {fornecedor.Nome}");
        }

                            
        public void FornecedorServices()
        {
            Console.WriteLine("Bem-vindo a Central de Fornecedores");
            Console.WriteLine("(1)- CADASTRAR FORNECEDORES");
            Console.WriteLine("(2)- LISTAR FORNECEDORES");
            Console.WriteLine("(3)- EXCLUIR FORNECEDORES");
            Console.Write("INFORME A OPEÇÃO DESEJADA..:");
            var opcao = int.Parse((Console.ReadLine() ?? string.Empty));
            switch (opcao)
            {
                case 1:
                    CadastrarFornecedor();
                    break;
                case 2:
                    ListarFornecedores();
                    break;
                case 3:
                    ExcluirFornecedor();
                    break;
                default:
                    Console.WriteLine("OPÇÃO INVÁLIDA");
                    break;
            }








        }
    }
}