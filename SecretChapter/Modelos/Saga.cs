namespace SecretChapter.Modelos;

internal class Saga : IAvaliavel    
{
    private List<Livro> livros = new List<Livro>();
    private List<Estrelas> estrelas = new List<Estrelas>();

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
    public double Media => estrelas.Count > 0 ? Math.Min(estrelas.Average(e => e.Estrela), 5) : 0;

    public void AdicionarEstrela(double estrela)
    {
        estrelas.Add(new Estrelas(estrela));
    }

    void IAvaliavel.Estrelas(Estrelas estrelas)
    {
        this.estrelas.Add(estrelas);
    }
}