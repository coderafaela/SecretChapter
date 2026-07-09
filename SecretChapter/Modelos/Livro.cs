namespace SecretChapter.Modelos;

class Livro
{
    private List<double> estrelas = new List<double>();

    public Livro(string titulo)
    {
        Titulo = titulo;
    }

    public string Titulo { get; }
    public double Media => estrelas.Count > 0 ? estrelas.Average() : 0;

    public void AdicionarEstrela(double estrela)
    {
        estrelas.Add(estrela);
    }
}