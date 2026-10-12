using System;
using System.Collections.Generic;
using System.Text;
using ControleFornecedoresApp.Interfaces;
using ControleFornecedoresApp.Controllers;
using System.Xml.Serialization;

namespace ControleFornecedoresApp.Repositorie
{
    public class ControleServiceXmlRepository : IControleService
    {
        public  void ExportarDados(ControleService controle)
        {
            var xmlSerializer = new XmlSerializer(typeof(ControleService));
            var diretorio = "c:\\temp";
            var caminho = Path.Combine(diretorio,$"controle_{controle.ControleServices}.xml");

            Directory.CreateDirectory(diretorio);
            using (var writingStream = new StreamWriter(caminho))
            {
                xmlSerializer.Serialize(writingStream, controle);
            }
        }



    }
}
