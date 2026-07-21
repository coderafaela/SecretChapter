using SecretChapter.Modelos;
namespace SecretChapter.Menus;

internal class MenuMostrarAutores : Menu
{
    public override void Executar(Dictionary<string, Autor> autoresRegistrados)
    {
        base.Executar(autoresRegistrados);
        Console.WriteLine(@"
▄▀█ █░█ ▀█▀ █▀█ █▀█ █▀▀ █▀
█▀█ █▄█ ░█░ █▄█ █▀▄ ██▄ ▄█");
        Console.WriteLine(" ");
        foreach (string autor in autoresRegistrados.Keys)
        {
            Console.WriteLine(autor);
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
    }

}
