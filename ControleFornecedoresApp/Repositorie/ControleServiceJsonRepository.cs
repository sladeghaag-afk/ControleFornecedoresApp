using ControleFornecedoresApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using ControleFornecedoresApp.Controllers;
using System.Text.Json;

namespace ControleFornecedoresApp.Repositorie
{
    public class ControleServiceJsonRepository : IControleService
    {
        public void ExportarDados(ControleService controle)
        {
           var diretorio = "c:\\temp";
            var caminho = Path.Combine(diretorio, $"controle_{controle.ControleServices}.json");

            Directory.CreateDirectory(diretorio);
            var opcoes = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(controle, opcoes);
            File.WriteAllText(caminho, json);
        }


    }
}
