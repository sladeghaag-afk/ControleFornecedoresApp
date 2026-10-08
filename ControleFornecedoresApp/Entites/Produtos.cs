using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFornecedoresApp.Entites
{
    public class Produtos
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;

        public double Preco { get; set; } = 0.0;

        public int Quantidade { get; set; } = 0;

        public DateTime DataCompra { get; set; } = DateTime.Now;

    }


   

}
