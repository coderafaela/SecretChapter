using SecretChapter.Menus;
using SecretChapter.Modelos;

Dictionary<string, Autor> autoresRegistrados = new();

Dictionary<int, Menu> opcoes=new();
opcoes.Add(1, new MenuRegistrarAutores());
opcoes.Add(2, new MenuRegistrarLivros());
opcoes.Add(3, new MenuRegistrarSagas());
opcoes.Add(4, new MenuMostrarAutores());
opcoes.Add(5, new MenuAvaliarLivro());
opcoes.Add(6, new MenuAvaliarSaga());
opcoes.Add(7, new MenuExibirInformacoes());
opcoes.Add(-1, new MenuSair());

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

██░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░██
██░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░██
██░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░██
");
    Console.WriteLine("Bem-vinde ao Secret Chapter");
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um autor");
    Console.WriteLine("Digite 2 para registrar o livro de um autor");
    Console.WriteLine("Digite 3 para registrar uma saga");
    Console.WriteLine("Digite 4 para mostras autores registrados");
    Console.WriteLine("Digite 5 para avaliar um livro");
    Console.WriteLine("Digite 6 para avaliar uma saga");
    Console.WriteLine("Digite 7 para exibir os detalhes de um autor");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
    if (opcoes.ContainsKey(opcaoEscolhidaNum))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNum];
        menuASerExibido.Executar(autoresRegistrados);
        if (opcaoEscolhidaNum>0) 
        {
            ExibirOpcoesDoMenu();
        }
    } else
    {
        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
    }

}
    ExibirOpcoesDoMenu();




