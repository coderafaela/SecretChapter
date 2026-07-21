using SecretChapter.Modelos;

namespace SecretChapter.Menus;

internal class MenuAvaliarSaga : Menu
{
    public override void Executar(Dictionary<string, Autor> autoresRegistrados)
    {
        base.Executar(autoresRegistrados);
        Console.WriteLine(@"
▄▀█ █░█ ▄▀█ █░░ █ ▄▀█ █▀█   █▀ ▄▀█ █▀▀ ▄▀█
█▀█ ▀▄▀ █▀█ █▄▄ █ █▀█ █▀▄   ▄█ █▀█ █▄█ █▀█");
        Console.WriteLine(" ");
        Console.Write("Digite o nome do autor: ");
        string nomeDoAutor = Console.ReadLine()!;
        if (autoresRegistrados.ContainsKey(nomeDoAutor))
        {
            Autor Autor = autoresRegistrados[nomeDoAutor];
            Console.Write("Digite o nome da saga que deseja avaliar: ");
            string tituloDaSaga = Console.ReadLine()!;

            Saga? sagaEncontrada = null;
            foreach (var autor in autoresRegistrados.Values)
            {
                sagaEncontrada = autor.Sagas.FirstOrDefault(s => s.Nome == tituloDaSaga);
                if (sagaEncontrada != null) break;
            }

            if (sagaEncontrada != null)
            {
                Estrelas estrelasSaga;
                while (true)
                {
                    Console.Write($"Digite o número de estrelas para {tituloDaSaga}: ");
                    estrelasSaga = Estrelas.Parse(Console.ReadLine()!);

                    if (estrelasSaga.Estrela < 0 || estrelasSaga.Estrela > 5)
                    {
                        Console.WriteLine("Número inválido. Por favor, digite um número entre 0 e 5.");
                        continue;
                    }

                    break;
                }

                sagaEncontrada.AdicionarEstrela(estrelasSaga.Estrela);
                Console.WriteLine($"\nAs {estrelasSaga.Estrela} estrelas foram registradas com sucesso para a saga {tituloDaSaga}!");
            }
            else
            {
                Console.WriteLine($"\nOps, a saga '{tituloDaSaga} não foi encontrada.");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu: ");
            Console.ReadKey();
            Console.Clear();
        }

    }
       
}

