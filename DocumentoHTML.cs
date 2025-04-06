using System;

// Classe derivada de Documento, representando um Documento HTML
public class DocumentoHTML : Documento
{
    // Sobrescrita do método Imprimir para exibir conteúdo específico de DocumentoHTML
    public override void Imprimir()
    {
        base.Imprimir(); // Chama o método da classe base
        Console.WriteLine("Conteúdo: Documento HTML.");
    }

    // Sobrescrita do método ConteudoFormatado para retornar uma string formatada como HTML
    public override string ConteudoFormatado()
    {
        return "<html>Conteúdo HTML formatado</html>";
    }

    // Método específico para DocumentoHTML: adicionar estilo CSS ao conteúdo
    public void AdicionarEstilo(string css)
    {
        Console.WriteLine($"Estilo CSS aplicado: {css}");
    }
}
