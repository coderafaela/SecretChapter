using SecretChapter.Modelos;
namespace SecretChapter.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Autor> autoresRegistrados)
    {
        base.Executar(autoresRegistrados);
        Console.WriteLine("Bye bye");
        Environment.Exit(0);
    }
}
