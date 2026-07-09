using SecretChapter.Modelos;

Autor claireN = new Autor("Claire North");

Autor joeA = new Autor("Joe Abercrombie");

Dictionary<string, Autor> autoresRegistrados = new();


void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗███████╗░█████╗░██████╗░███████╗████████╗  ░█████╗░██╗░░██╗░█████╗░██████╗░████████╗███████╗██████╗░
██╔════╝██╔════╝██╔══██╗██╔══██╗██╔════╝╚══██╔══╝  ██╔══██╗██║░░██║██╔══██╗██╔══██╗╚══██╔══╝██╔════╝██╔══██╗
╚█████╗░█████╗░░██║░░╚═╝██████╔╝█████╗░░░░░██║░░░  ██║░░╚═╝███████║███████║██████╔╝░░░██║░░░█████╗░░██████╔╝
░╚═══██╗██╔══╝░░██║░░██╗██╔══██╗██╔══╝░░░░░██║░░░  ██║░░██╗██╔══██║██╔══██║██╔═══╝░░░░██║░░░██╔══╝░░██╔══██╗
██████╔╝███████╗╚█████╔╝██║░░██║███████╗░░░██║░░░  ╚█████╔╝██║░░██║██║░░██║██║░░░░░░░░██║░░░███████╗██║░░██║
╚═════╝░╚══════╝░╚════╝░╚═╝░░╚═╝╚══════╝░░░╚═╝░░░  ░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░░░░╚═╝░░░╚══════╝╚═╝░░╚═╝");

    Console.WriteLine(@"

█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█
█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█
█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█
");
    Console.WriteLine("Bem-vinde ao Secret Chapter");
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um autor");
    Console.WriteLine("Digite 2 para registrar o livro de um autor");
    Console.WriteLine("Digite 3 para mostrar todos os autores");
    Console.WriteLine("Digite 4 para avaliar um livro");
    Console.WriteLine("Digite 5 para exibir os detalhes de um autor");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNum)
    {
        case 1:
            RegistrarAutor();
            break;
        case 2:
            RegistrarLivros();
            break;
        case 3:
            MostrarAutores();
            break;
        case 4:
            AvaliarUmLivro();
            break;
        case 5:
            ExibirInformacoes();
            break;
        case -1:
            Console.WriteLine("Bye bye, bitch");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

}

void RegistrarAutor()
{
    Console.Clear();
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
    ExibirOpcoesDoMenu();

}

void RegistrarLivros()
{
    Console.Clear();
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
    ExibirOpcoesDoMenu();
}

void MostrarAutores()
{
    Console.Clear();
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
    ExibirOpcoesDoMenu();


}

void AvaliarUmLivro()
{
    Console.Clear();
    Console.WriteLine(@"
▄▀█ █░█ ▄▀█ █░░ █ █▀▀   █░█ █▀▄▀█   █░░ █ █░█ █▀█ █▀█
█▀█ ▀▄▀ █▀█ █▄▄ █ ██▄   █▄█ █░▀░█   █▄▄ █ ▀▄▀ █▀▄ █▄█");
    Console.WriteLine(" ");
    Console.Write("Digite o nome do livro que deseja avaliar: ");
        string tituloDoLivro = Console.ReadLine()!;

        Livro ? livroEncontrado = null;
        foreach (var autor in autoresRegistrados.Values)
        {
            livroEncontrado = autor.Livros.FirstOrDefault(l => l.Titulo == tituloDoLivro);
            if (livroEncontrado != null) break;
        }

        if (livroEncontrado != null)
        {
            Console.Write($"Digite o número de estrelas para {tituloDoLivro}: ");
            double estrelasLivro = double.Parse(Console.ReadLine()!);
            livroEncontrado.AdicionarEstrela(estrelasLivro);
            Console.WriteLine($"\nAs {estrelasLivro} estrelas foram registradas com sucesso para o livro {tituloDoLivro}!");
        }
        else
        {
            Console.WriteLine($"\nOps, o livro {tituloDoLivro} não foi encontrado.");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
 }


void ExibirInformacoes()
{
    Console.Clear();
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
                Console.WriteLine($"- {livro.Titulo} | Estrelas: {livro.Media:F1}");
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
    ExibirOpcoesDoMenu();




