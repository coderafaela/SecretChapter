namespace SecretChapter.Modelos;

    internal class Estrelas
{
    public Estrelas(double estrela)
    {
       Estrela = estrela;
    }
    public double Estrela { get; }

    public static Estrelas Parse(string texto)
    {
        double estrelasLivro = double.Parse(texto);
        return new Estrelas(estrelasLivro);
    }
}

