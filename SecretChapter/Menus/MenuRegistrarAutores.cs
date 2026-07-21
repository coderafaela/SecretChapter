using SecretChapter.Modelos;
namespace SecretChapter.Menus;

internal class MenuRegistrarAutores : Menu
{
    public override void Executar(Dictionary<string, Autor> autoresRegistrados)
    {
        base.Executar(autoresRegistrados);
        Console.WriteLine(@"

█▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀█ █▀█   █▀▄ █▀▀   ▄▀█ █░█ ▀█▀ █▀█ █▀█ █▀▀ █▀
█▀▄ ██▄ █▄█ █ ▄█ ░█░ █▀▄ █▄█   █▄▀ ██▄   █▀█ █▄█ ░█░ █▄█ █▀▄ ██▄ ▄█");
        Console.Clear();
        Console.Write("Digite o nome do(a) autor(a) que deseja registrar: ");
        string nomeDeAutor = Console.ReadLine()!;
        if (!autoresRegistrados.ContainsKey(nomeDeAutor))
        {
            autoresRegistrados.Add(nomeDeAutor, new Autor(nomeDeAutor));
        }
        else
        {
            Console.WriteLine("Autor já registrado.");
        }
        Console.WriteLine($"O(A) autor(a) {nomeDeAutor} foi registrado(a) com sucesso!");
        Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
    }
}
