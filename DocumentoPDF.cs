using System;

// Classe derivada de Documento, representando um Documento PDF
public class DocumentoPDF : Documento
{
    // Sobrescrita do método Imprimir para exibir conteúdo específico de DocumentoPDF
    public override void Imprimir()
    {
        base.Imprimir(); // Chama o método da classe base
        Console.WriteLine("Conteúdo: Documento PDF.");
    }

    // Sobrescrita do método ConteudoFormatado para retornar uma string formatada para PDF
    public override string ConteudoFormatado()
    {
        return "Conteúdo formatado em PDF.";
    }

    // Método específico para DocumentoPDF: adicionar uma marca d'água
    public void AdicionarMarcaDagua(string texto)
    {
        Console.WriteLine($"Marca d'água: {texto}");
    }
}
