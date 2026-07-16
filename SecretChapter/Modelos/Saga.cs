namespace SecretChapter.Modelos;

internal class Saga
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
}