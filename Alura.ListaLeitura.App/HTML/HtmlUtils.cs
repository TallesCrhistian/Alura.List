﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Alura.ListaLeitura.App.HTML
{
    public class HtmlUtils
    {
        public static string CarregaArquivoHtml(string nomeArquivo)
        {
            var nomeCompletoArquivo = $"C:\\Users\\Talles\\Downloads\\Alura.ListaLeitura\\Alura.ListaLeitura.App\\HTML\\{nomeArquivo}.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }

        }
    }
}
