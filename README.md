# 📚 Traduziu ou Não Traduziu?

Sistema em C# para controlar se os livros de uma saga já possuem tradução para o português — ideal pra quem (como eu) já perdeu a paciência esperando a editora lançar o próximo volume da série favorita.

## 💡 Sobre o projeto

Comecei esse projeto como exercício de um curso da Alura, mas resolvi expandir pra resolver um problema bem real (e bem específico): saber rapidinho quais livros de uma saga estrangeira já foram traduzidos para o português e quais ainda estão só em inglês.

O sistema modela três entidades principais que se relacionam entre si:

- **Autor** → pode ter várias sagas associadas
- **Saga** → agrupa vários livros
- **Livro** → guarda os detalhes de cada obra, incluindo se já tem tradução (`Traducao`), sinopse, número de páginas e gênero

## 🧱 Estrutura das classes

### `Autor`
Guarda o nome do autor e a lista de sagas que ele escreveu. Um mesmo autor pode ter mais de uma saga cadastrada no sistema.

### `Saga`
Representa uma série de livros. Guarda o nome da saga e a lista de livros pertencentes a ela, além de expor quantos livros já foram adicionados (`LivrosPertencentes`).

### `Livro`
Cada livro está sempre vinculado a um autor e tem:
- Título
- Gênero
- Número de páginas (opcional)
- Sinopse (opcional)
- Se possui tradução para o português (`Traducao`)

Se páginas ou sinopse não forem informadas, o sistema avisa que a informação está indisponível, em vez de simplesmente printar `0` ou `null`.

## ▶️ Exemplo de uso

```csharp
Autor robertJacksonBennett = new Autor("Robert Jackson Bennett");
Saga shadowoftheLevithan = new Saga("Shadow of the Leviathan");

Livro livro1 = new Livro(robertJacksonBennett, "O Cálice Contaminado")
{
    Paginas = 448,
    Genero = "Fantasia/Ficção Científica LGBTQ+",
    Traducao = true,
    Sinopse = "Em uma opulenta mansão de Daretana..."
};

shadowoftheLevithan.AdicionarLivro(livro1);
robertJacksonBennett.adicionarSaga(shadowoftheLevithan);

robertJacksonBennett.ExibirAutor();
shadowoftheLevithan.ExibirSaga();
```

### Saída esperada

```
Autor: Robert Jackson Bennett
Sagas no Sistema: Shadow of the Leviathan
Saga: Shadow of the Leviathan
Livros Pertencentes: 3
O Cálice Contaminado - Robert Jackson Bennett (Fantasia/Ficção Científica LGBTQ+)
Páginas: 448
Sinopse: Em uma opulenta mansão de Daretana...

Possui tradução para o português
...
```

## 🛠️ Tecnologias

- C#
- Orientação a Objetos (encapsulamento, composição entre classes, propriedades computadas)

## 🚀 Possíveis melhorias futuras

- [ ] Persistência de dados (arquivo ou banco de dados)
- [ ] Busca de livros por título ou autor
- [ ] Ordenação de livros por data de lançamento
- [ ] Interface de linha de comando com menu interativo
- [ ] Integração com alguma API de catálogo de livros

## ✍️ Autora

Feito por [Rafaela A. Quevedo](https://github.com/rafaela-aquevedo), estudante de ADS e futura desenvolvedora back-end, que só quer saber se vai ter que ler em inglês ou não.
