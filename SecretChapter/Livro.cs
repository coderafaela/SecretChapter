class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public bool Traducao { get; set; }
    public string Genero { get; set; }
    public int Paginas { get; set; }
    public string Sinopse { get; set; }
    public string DescricaoResumida =>
        $"{Titulo} - {Autor} ({Genero})";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"{DescricaoResumida}");
        Console.WriteLine($"Páginas: {Paginas}");
        Console.WriteLine($"Sinopse: {Sinopse}");
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