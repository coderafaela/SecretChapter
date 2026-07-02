class Livro
{
    public string Titulo { get; set; }
    public string Autore { get; set; }
    public bool Disponivel { get; set; }
    public string Genero { get; set; }
    public int Paginas { get; set; }
    public string Sinopse { get; set; }
    public string DescricaoResumida =>
        $"{Titulo} - {Autore} ({Genero})";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"{DescricaoResumida}");
        Console.WriteLine($"Páginas: {Paginas}");
        Console.WriteLine($"Sinopse: {Sinopse}");
        if (Disponivel)
        {
            Console.WriteLine("\nDisponível para Empréstimo");
        }
        else
        {
            Console.WriteLine("\nNão está disponível para empréstimo");
        }
    }
}