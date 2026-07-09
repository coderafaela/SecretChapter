namespace SecretChapter.Modelos;

class Autor
{
    private List<Saga> sagas = new List<Saga>();
    private List<Livro> livros = new List<Livro>();

    public Autor(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public List<Saga> Sagas => sagas;
    public List<Livro> Livros => livros;

    public void AdicionarSaga(Saga saga)
    {
        sagas.Add(saga);
    }

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }
}