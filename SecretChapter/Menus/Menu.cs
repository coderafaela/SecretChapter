using SecretChapter.Modelos;
namespace SecretChapter.Menus;

internal class Menu
{
    public virtual void Executar(Dictionary<string, Autor> autoresRegistrados)
    {
        Console.Clear();
    }
}
