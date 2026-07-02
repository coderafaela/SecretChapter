class Saga
{
    private List<Livro> livros = new List<Livro>();>
    public string Nome { get; set; }
    public int LivrosPertencentes { get; }
    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }
}