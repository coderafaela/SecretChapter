class Saga
{
    private List<Livro> livros = new List<Livro>();

    public Saga(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int LivrosPertencentes => livros.Count;
    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void ExibirSaga()
    {
        Console.WriteLine($"Saga: {Nome}");
        Console.WriteLine($"Livros Pertencentes: {LivrosPertencentes} ");
        foreach (var livro in livros)
        {
            livro.ExibirFichaTecnica();
            Console.WriteLine();
        }
    }
}