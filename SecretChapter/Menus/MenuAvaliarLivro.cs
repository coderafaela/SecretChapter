using SecretChapter.Modelos;
namespace SecretChapter.Menus;

internal class MenuAvaliarLivro : Menu
{
    public override void Executar(Dictionary<string, Autor> autoresRegistrados)
    {
        base.Executar(autoresRegistrados);
        Console.WriteLine(@"
▄▀█ █░█ ▄▀█ █░░ █ █▀▀   █░█ █▀▄▀█   █░░ █ █░█ █▀█ █▀█
█▀█ ▀▄▀ █▀█ █▄▄ █ ██▄   █▄█ █░▀░█   █▄▄ █ ▀▄▀ █▀▄ █▄█");
        Console.WriteLine(" ");
        Console.Write("Digite o nome do livro que deseja avaliar: ");
        string tituloDoLivro = Console.ReadLine()!;


        Livro? livroEncontrado = null;
        foreach (var autor in autoresRegistrados.Values)
        {
            livroEncontrado = autor.Livros.FirstOrDefault(l => l.Titulo == tituloDoLivro);
            if (livroEncontrado != null) break;
        }

        if (livroEncontrado != null)
        {
            Estrelas estrelasLivro;
            while (true)
            {
                Console.Write($"Digite o número de estrelas para {tituloDoLivro}: ");
                estrelasLivro = Estrelas.Parse(Console.ReadLine()!);

                if (estrelasLivro.Estrela < 0 || estrelasLivro.Estrela > 5)
                {
                    Console.WriteLine("Número inválido. Por favor, digite um número entre 0 e 5.");
                    continue;
                }

                break;
            }

            livroEncontrado.AdicionarEstrela(estrelasLivro.Estrela);
            Console.WriteLine($"\nAs {estrelasLivro.Estrela} estrelas foram registradas com sucesso para o livro {tituloDoLivro}!");
        }
        else
        {
            Console.WriteLine($"\nOps, o livro {tituloDoLivro} não foi encontrado.");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
    }
}
