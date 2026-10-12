using ControleFornecedoresApp.Controllers;
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
        public readonly List<Fornecedor> _fornecedores = new List<Fornecedor>();
        public void CadastrarFornecedor()
        {
            var Fornecedor = new Fornecedor();

            Console.WriteLine("CADASTRO DE FORNECEDORES");
            Console.Write("INFORME O NOME DO FORNECEDOR..:");
            Fornecedor.NomeFornecedor = Console.ReadLine() ?? string.Empty;
            Console.Write("INFORME O CNPJ DO FORNECEDOR..:");
            Fornecedor.CNPJ = Console.ReadLine() ?? string.Empty.PadRight(14).Substring(0, 14).Trim();

            if (string.IsNullOrWhiteSpace(Fornecedor.NomeFornecedor) || string.IsNullOrWhiteSpace(Fornecedor.CNPJ))
            {
                Console.WriteLine("NOME E CNPJ SÃO OBRIGATÓRIOS.");
                CadastrarFornecedor();
                return;
            }
            if (_fornecedores.Exists(f => f.CNPJ == Fornecedor.CNPJ))
            {
                Console.WriteLine("FORNECEDOR JÁ CADASTRADO.");
                CadastrarFornecedor();
                return;
            }
            if (Fornecedor.CNPJ.Length != 14)
            {
                Console.WriteLine("CNPJ INVÁLIDO. DEVE CONTER 14 DÍGITOS.");
                CadastrarFornecedor();
                return;
            }

            if (!long.TryParse(Fornecedor.CNPJ, out _))
            {
                Console.WriteLine("CNPJ INVÁLIDO. DEVE CONTER APENAS NÚMEROS.");
                CadastrarFornecedor();
                return;
            }



            // Aqui você pode adicionar a lógica para salvar o fornecedor em um banco de dados ou lista



        }
        public void ListarFornecedores()
        {
            Console.WriteLine("\nLISTA DE FORNECEDORES");
            if (_fornecedores.Count == 0)
            {
                Console.WriteLine("NENHUM FORNECEDOR CADASTRADO.");
                while (_fornecedores.Count != 0)
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

            var fornecedor = _fornecedores.Find(f => f.CNPJ == cnpj);

            if (fornecedor == null)
            {
                Console.WriteLine("FORNECEDOR NÃO ENCONTRADO.");
                return;
            }

            _fornecedores.Remove(fornecedor);
            Console.WriteLine($"FORNECEDOR EXCLUÍDO: {fornecedor.NomeFornecedor}");
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

        internal void ExportarDados(ControleService controleService)
        {
            throw new NotImplementedException();
        }
    }
}