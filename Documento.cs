using System;

// Classe base que representa um Documento genérico
public class Documento
{
    // Propriedades comuns de um documento
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public DateTime DataCriacao { get; set; }

    // Método virtual para imprimir informações básicas do documento
    public virtual void Imprimir()
    {
        // Exibe o título, autor e a data de criação
        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Data: {DataCriacao.ToShortDateString()}");
    }

    // Método virtual para obter o conteúdo formatado do documento
    public virtual string ConteudoFormatado()
    {
        // Método genérico que pode ser sobrescrito pelas classes derivadas
        return "";
    }
}
