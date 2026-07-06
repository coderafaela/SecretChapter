class Autor
{
    private List<Saga> sagas = new List<Saga>();

    public Autor(string nome)
    {
        Nome = nome;
    }


    public string Nome { get; }
    public void AdicionarSaga(Saga saga)
    {
        sagas.Add(saga);
    }

    public void ExibirAutor()
    {
        Console.WriteLine($"Autor: {Nome}");

        // Exibe todos os nomes das sagas no sistema
        if (sagas.Count == 0)
        {
            Console.WriteLine("Sagas no Sistema: Nenhuma");
        }
        else
        {
            Console.Write("Sagas no Sistema: ");
            for (int i = 0; i < sagas.Count; i++)
            {
                if (i > 0) Console.Write(", ");
                Console.Write(sagas[i].Nome);
            }
            Console.WriteLine();
        }
    }
}