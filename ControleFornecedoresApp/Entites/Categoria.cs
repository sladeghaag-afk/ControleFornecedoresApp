using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFornecedoresApp.Entites
{
    public class Categoria
    {
        public Guid IdCategoria { get; set; } = Guid.NewGuid();

        public string NomeCategoria { get; set; } = string.Empty;

    }
}
