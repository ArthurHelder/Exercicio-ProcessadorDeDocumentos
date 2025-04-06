using System;
using System.Collections.Generic;

// Classe responsável por processar um lote de documentos
public class ProcessadorDocumentos
{
    // Método que recebe uma lista de documentos e chama o método Imprimir de cada um
    public void ProcessarLote(List<Documento> documentos)
    {
        foreach (var doc in documentos)
        {
            doc.Imprimir(); // Polimorfismo: chama o método correto dependendo do tipo do documento
        }
    }
}
