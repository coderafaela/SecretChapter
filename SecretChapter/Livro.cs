class Livro
{
    public Livro(Autor autor, string titulo)
    {
        Autor = autor;
        Titulo = titulo;
    }
    public string Titulo { get; }
    public Autor Autor { get; set; }
    public bool Traducao { get; set; }
    public string Genero { get; set;  }
    public int Paginas { get; set; }
    public string Sinopse { get; set; }
    public string DescricaoResumida =>
        $"{Titulo} - {Autor.Nome} ({Genero})";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"{DescricaoResumida}");
        if (Paginas != 0)
        {
            Console.WriteLine($"Páginas: {Paginas}");
        }
        else
            Console.WriteLine($"Páginas: Informação Indisponível");

        if (Sinopse != null)
        {
            Console.WriteLine($"Sinopse: {Sinopse}");
        }
        else
            Console.WriteLine($"Sinopse: Informação Indisponível");
        if (Traducao)
        {
            Console.WriteLine("\nPossui tradução para o português");
        }
        else
        {
            Console.WriteLine("\nAinda não possui tradução para o português");
        }
    }
}