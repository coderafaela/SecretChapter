namespace SecretChapter.Modelos;

internal class Livro
{
    private List<Estrelas> estrelas = new List<Estrelas>();

    public Livro(string titulo)

    {
        Titulo = titulo;
    }

    public string Titulo { get; }
    public double Media => estrelas.Count > 0 ? Math.Min(estrelas.Average(e => e.Estrela), 5) : 0;

    public void AdicionarEstrela(double estrela)
    {
        estrelas.Add(new Estrelas(estrela));
    }
}