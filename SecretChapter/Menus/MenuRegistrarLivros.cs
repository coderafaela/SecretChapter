using SecretChapter.Modelos;
namespace SecretChapter.Menus;

internal class MenuRegistrarLivros : Menu
{
    public override void Executar(Dictionary<string, Autor> autoresRegistrados)
    {
        base.Executar(autoresRegistrados);
        Console.WriteLine(@"

█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   █░░ █ █░█ █▀█ █▀█ █▀
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▄▄ █ ▀▄▀ █▀▄ █▄█ ▄█");
        Console.WriteLine(" ");
        Console.Write("Digite o autor cujo livro deseja registrar: ");
        string nomeDeAutor = Console.ReadLine()!;
        if (autoresRegistrados.ContainsKey(nomeDeAutor))
        {
            Console.Write("\nAgora digite o título do livro: ");
            string tituloDoLivro = Console.ReadLine()!;
            Autor autor = autoresRegistrados[nomeDeAutor];
            autor.AdicionarLivro(new Livro(tituloDoLivro));
            Console.WriteLine("\nLivro adicionado com sucesso!");
        }
        else
        {
            Console.WriteLine("Autor não registrado");

        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
    }
}
