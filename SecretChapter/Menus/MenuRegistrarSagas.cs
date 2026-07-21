
using SecretChapter.Modelos;

namespace SecretChapter.Menus;

internal class MenuRegistrarSagas : Menu
{
    public override void Executar(Dictionary<string, Autor> autoresRegistrados)
    {
        base.Executar(autoresRegistrados);
        Console.WriteLine(@"
█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ ▄▀█ █▀█   █▀ ▄▀█ █▀▀ ▄▀█
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▀█ █▀▄   ▄█ █▀█ █▄█ █▀█");
        Console.WriteLine(" ");
        Console.Write("Digite o autor cujo livro deseja registrar: ");
        string nomeDeAutor = Console.ReadLine()!;
        if (autoresRegistrados.ContainsKey(nomeDeAutor))
        {
            Console.Write("\nAgora digite o título da saga: ");
            string tituloDaSaga = Console.ReadLine()!;
            Autor autor = autoresRegistrados[nomeDeAutor];
            autor.AdicionarSaga(new Saga(tituloDaSaga));
            Console.WriteLine("\nSaga adicionada com sucesso!");
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
