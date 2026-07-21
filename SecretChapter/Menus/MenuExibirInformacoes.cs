using SecretChapter.Modelos;

namespace SecretChapter.Menus;

internal class MenuExibirInformacoes : Menu
{
    public override void Executar(Dictionary<string, Autor> autoresRegistrados)
    {
        base.Executar(autoresRegistrados);
        Console.WriteLine(@"


█ █▄░█ █▀▀ █▀█ █▀█ █▀▄▀█ ▄▀█ █▀▀ █▀█ █▀▀ █▀   █▀ █▀█ █▄▄ █▀█ █▀▀   █▀█ ▄▀ ▄▀█ ▀▄   ▄▀█ █░█ ▀█▀ █▀█ █▀█ ▄▀ ▄▀█ ▀▄
█ █░▀█ █▀░ █▄█ █▀▄ █░▀░█ █▀█ █▄▄ █▄█ ██▄ ▄█   ▄█ █▄█ █▄█ █▀▄ ██▄   █▄█ ▀▄ █▀█ ▄▀   █▀█ █▄█ ░█░ █▄█ █▀▄ ▀▄ █▀█ ▄▀");
        Console.WriteLine(" ");
        Console.Write("Digite o nome do autor: ");
        string nomeDeAutor = Console.ReadLine()!;

        if (autoresRegistrados.ContainsKey(nomeDeAutor))
        {
            Autor autor = autoresRegistrados[nomeDeAutor];
            Console.WriteLine($"\nAutor: {autor.Nome}");

            if (autor.Livros.Count == 0)
            {
                Console.WriteLine("Nenhum livro registrado.");
            }
            else
            {
                foreach (var livro in autor.Livros)
                {
                    Console.WriteLine($"- Livro: {livro.Titulo} | Estrelas: {livro.Media:F1}");
                }
            }
            if (autor.Sagas.Count == 0)
            {
                Console.WriteLine("Nenhuma saga registrada.");
            }
            else
            {
                foreach (var saga in autor.Sagas)
                {
                    Console.WriteLine($"- Saga: {saga.Nome} | Estrelas: {saga.Media:F1}");
                }
            }
        }
        else
        {
            Console.WriteLine($"\nO(A) autor(a) {nomeDeAutor} não foi encontrado(a)!");
        }

        Console.WriteLine("Digite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
    }
}
