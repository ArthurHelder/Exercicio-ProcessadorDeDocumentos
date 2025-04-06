using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Criando uma lista de documentos de diferentes tipos
        List<Documento> documentos = new List<Documento>
        {
            new DocumentoTexto { Titulo = "Documento 1", Autor = "Autor 1", DataCriacao = DateTime.Now },
            new DocumentoHTML { Titulo = "Documento 2", Autor = "Autor 2", DataCriacao = DateTime.Now },
            new DocumentoPDF { Titulo = "Documento 3", Autor = "Autor 3", DataCriacao = DateTime.Now }
        };

        // Criando o processador de documentos
        ProcessadorDocumentos processador = new ProcessadorDocumentos();

        // Processando e imprimindo os documentos, demonstrando polimorfismo
        processador.ProcessarLote(documentos);
    }
}
