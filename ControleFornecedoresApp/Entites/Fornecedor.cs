using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFornecedoresApp.Entites
{
    public class Fornecedor
    {
        public Guid IdFornecedor { get; set; } = Guid.NewGuid();

        public string NomeFornecedor { get; set; } = string.Empty;

        public string CNPJ { get; set; } = string.Empty;





    }
}
