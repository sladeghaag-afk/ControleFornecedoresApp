using System;
using System.Collections.Generic;
using System.Text;

namespace ControleFornecedoresApp.Entites
{
    public class Categoria
    {
        public Guid IdCategoria { get; set; } = Guid.NewGuid();
        public NomeCategoria Nome { get; set; }

    }
    public enum NomeCategoria
    {
        Eletronicos = 1,
        Vestuario = 2,
        Alimentos = 3,
        Bebidas = 4,
        Moveis = 5,
        Brinquedos = 6,
        Livros = 7,
        Esportes = 8,
        Beleza = 9,
        Automotivo = 10
    }




}
