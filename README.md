# 📚 Secret Chapter

Sistema em C# com menu interativo no terminal para cadastrar autores, seus livros e sagas, além de avaliar cada obra com uma nota — ideal pra quem (como eu) gosta de manter um controle pessoal do que já leu e o que achou.

## 💡 Sobre o projeto

Comecei esse projeto como exercício do curso **C#: aplicando a Orientação a Objetos**, da Alura, e resolvi adaptar pra um tema que eu realmente gosto: livros e autores. Foi meu primeiro contato de verdade com POO, e o projeto foi crescendo — hoje ele já tem um menu interativo completo, com uma arquitetura orientada a objetos por trás, em vez de só rodar um cadastro fixo.

O sistema modela quatro entidades principais que se relacionam entre si:

- **Autor** → guarda nome, a lista de livros escritos por ele e a lista de sagas que ele assina
- **Livro** → guarda o título e as notas (estrelas) recebidas, calculando a média automaticamente
- **Saga** → agrupa livros de uma mesma série e também pode ser avaliada com estrelas
- **Estrelas** → representa uma nota individual, com validação de formato via `Parse()`

## 🧱 Estrutura das classes

### `Autor`

Guarda o nome do autor e as listas de livros (`Livros`) e sagas (`Sagas`) associadas a ele, com métodos `AdicionarLivro()` e `AdicionarSaga()`.

### `Livro`

Guarda o título da obra e a lista de notas recebidas. A propriedade `Media` calcula a média das estrelas automaticamente (limitada a 5), e `AdicionarEstrela()` permite registrar novas avaliações. Implementa a interface `IAvaliavel`.

### `Saga`

Agrupa livros de uma mesma série. Guarda o nome, a lista de livros pertencentes (`LivrosPertencentes`) e também pode receber avaliações próprias, calculando sua `Media` da mesma forma que um livro. Implementa `IAvaliavel`.

### `Estrelas`

Representa uma nota individual. O método estático `Parse()` converte a entrada do usuário em uma instância válida.

### `IAvaliavel`

Interface que unifica `Livro` e `Saga` como "coisas que podem ser avaliadas", exigindo a implementação de `Estrelas(Estrelas estrelas)` e da propriedade `Media`.

### `Menu` (e subclasses)

Classe-base com um método virtual `Executar()`. Cada opção do menu (registrar autor, registrar livro, registrar saga, mostrar autores, avaliar livro, avaliar saga, exibir informações, sair) é uma classe própria que herda de `Menu` e sobrescreve `Executar()` — o programa principal só guarda um `Dictionary<int, Menu>` e delega a execução por polimorfismo, sem precisar de um switch gigante.

## ▶️ Funcionalidades do menu

Ao rodar o programa, é exibido um menu com as seguintes opções:

1. **Registrar um autor** — cadastra um novo autor no sistema
2. **Registrar o livro de um autor** — vincula um livro a um autor já cadastrado
3. **Registrar uma saga** — vincula uma saga a um autor já cadastrado
4. **Mostrar todos os autores** — lista todos os autores cadastrados
5. **Avaliar um livro** — busca um livro pelo título (entre todos os autores) e adiciona uma nota de 0 a 5 estrelas
6. **Avaliar uma saga** — busca uma saga pelo nome (a partir de um autor) e adiciona uma nota de 0 a 5 estrelas
7. **Exibir os detalhes de um autor** — mostra o autor, seus livros e suas sagas, com a média de estrelas de cada um
-1. **Sair** — encerra o programa

## ▶️ Exemplo de uso

```csharp
Autor robertJB = new Autor("Robert Jackson Bennett");

Saga osFundadores = new Saga("Os Fundadores");
Livro livro1 = new Livro("Foundryside: Às Margens da Fundição");
Livro livro2 = new Livro("Shorefall: A Noite do Caos");
Livro livro3 = new Livro("Locklands: Os Abismos Esquecidos");

robertJB.AdicionarSaga(osFundadores);
robertJB.AdicionarLivro(livro1);
robertJB.AdicionarLivro(livro2);
robertJB.AdicionarLivro(livro3);

osFundadores.AdicionarLivro(livro1);
osFundadores.AdicionarLivro(livro2);
osFundadores.AdicionarLivro(livro3);

livro1.AdicionarEstrela(5);
livro2.AdicionarEstrela(4);
livro3.AdicionarEstrela(5);
osFundadores.AdicionarEstrela(5);
```

### Saída esperada (opção 7 — exibir detalhes do autor)

```
Autor: Robert Jackson Bennett
- Livro: Foundryside: Às Margens da Fundição | Estrelas: 5.0
- Livro: Shorefall: A Noite do Caos | Estrelas: 4.0
- Livro: Locklands: Os Abismos Esquecidos | Estrelas: 5.0
- Saga: Os Fundadores | Estrelas: 5.0
```

## 🛠️ Tecnologias

- C#
- Orientação a Objetos (encapsulamento, composição entre classes, propriedades computadas)
- Polimorfismo (herança e `override` na hierarquia de `Menu`)
- Interfaces (`IAvaliavel`, implementada por `Livro` e `Saga`)
- Coleções (`Dictionary`, `List`) para gerenciar autores, livros e sagas em memória

## 🚀 Possíveis melhorias futuras

- [ ] Persistência de dados (arquivo ou banco de dados)
- [ ] Busca de livros e sagas por autor sem precisar saber o título exato
- [ ] Validação de entradas mais robusta (evitar erro ao digitar texto onde se espera número)
- [ ] Interface web ou API REST no lugar do terminal

## ✍️ Autora

Feito por [Rafaela A. Quevedo](https://github.com/coderafaela), estudante de ADS e futura desenvolvedora back-end, sempre com uma lista de leitura grande demais pra dar conta.
