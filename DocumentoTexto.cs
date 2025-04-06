using System;

// Classe derivada de Documento, representando um Documento de Texto
public class DocumentoTexto : Documento
{
    // Sobrescrita do método Imprimir para exibir conteúdo específico de DocumentoTexto
    public override void Imprimir()
    {
        base.Imprimir(); // Chama o método da classe base
        Console.WriteLine("Conteúdo: Documento de texto simples.");
    }

    // Sobrescrita do método ConteudoFormatado para retornar uma string formatada específica
    public override string ConteudoFormatado()
    {
        return "Conteúdo formatado em texto simples.";
    }

    // Método específico para DocumentoTexto: conta o número de palavras
    public int ContarPalavras()
    {
        // Exemplo fixo de número de palavras
        return 100;
    }
}
