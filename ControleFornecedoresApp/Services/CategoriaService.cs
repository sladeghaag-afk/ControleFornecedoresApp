using ControleFornecedoresApp.Entites;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ControleFornecedoresApp.Services
{
    public class CategoriaService
    {
        public readonly List<Categoria> _categoriaServices = new();
        public IReadOnlyList<Categoria> Categorias => _categoriaServices;

        public Categoria? CategoriaServices()
        {
            Console.WriteLine("\nESCOLHA A CATEGORIA");
            foreach (var c in Enum.GetValues<NomeCategoria>())
                Console.WriteLine($"  {(int)c} - {c}");
            Console.WriteLine("  0 - Cancelar");
            Console.Write("OPÇÃO..: ");

            var entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out var opcao))
            {
                Console.WriteLine("Digite apenas o número da opção.");
                Console.ReadLine();

            }

            if (opcao == 0)
                return null;

            if (!Enum.IsDefined(typeof(NomeCategoria), opcao))
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
                Console.ReadLine();
                return null;
            }

            var categoria = new Categoria { Nome = (NomeCategoria)opcao };
            _categoriaServices.Add(categoria);
            Console.WriteLine($"CATEGORIA SELECIONADA: {categoria.Nome}");
            return categoria;

        }




    }





    
}
