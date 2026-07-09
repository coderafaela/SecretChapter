# 📚 Secret Chapter

Sistema em C# com menu interativo no terminal para cadastrar autores e seus livros, além de avaliar cada obra com uma nota — ideal pra quem (como eu) gosta de manter um controle pessoal do que já leu e o que achou.

## 💡 Sobre o projeto

Comecei esse projeto como exercício do curso **C#: aplicando a Orientação a Objetos**, da Alura, e resolvi adaptar pra um tema que eu realmente gosto: livros e autores. Foi meu primeiro contato de verdade com POO, e o projeto foi crescendo — hoje ele já tem um menu interativo completo, em vez de só rodar um cadastro fixo.

O sistema modela duas entidades principais que se relacionam entre si:

- **Autor** → guarda nome e a lista de livros escritos por ele
- **Livro** → guarda o título e as notas (estrelas) recebidas, calculando a média automaticamente

## 🧱 Estrutura das classes

### `Autor`
Guarda o nome do autor e a lista de livros associados a ele. Também mantém uma lista de sagas (`Sagas`), preparada para uso futuro, ainda não integrada ao menu.

### `Livro`
Guarda o título da obra e a lista de notas recebidas. A propriedade `Media` calcula a média das estrelas automaticamente, e `AdicionarEstrela()` permite registrar novas avaliações.

## ▶️ Funcionalidades do menu

Ao rodar o programa, é exibido um menu com as seguintes opções:

1. **Registrar um autor** — cadastra um novo autor no sistema
2. **Registrar o livro de um autor** — vincula um livro a um autor já cadastrado
3. **Mostrar todos os autores** — lista todos os autores cadastrados
4. **Avaliar um livro** — busca um livro pelo título (entre todos os autores) e adiciona uma nota de 0 a 5 estrelas
5. **Exibir os detalhes de um autor** — mostra o autor e a lista de livros dele, com a média de estrelas de cada um
-1. **Sair** — encerra o programa

## ▶️ Exemplo de uso

```csharp
Autor claireN = new Autor("Claire North");
Livro livro1 = new Livro("Slow Gods");
livro1.AdicionarEstrela(5);
livro1.AdicionarEstrela(4);
claireN.AdicionarLivro(livro1);
```

### Saída esperada (opção 5 — exibir detalhes do autor)

```
Autor: Claire North
- Slow Gods | Estrelas: 4.5
```

## 🛠️ Tecnologias

- C#
- Orientação a Objetos (encapsulamento, composição entre classes, propriedades computadas)
- Coleções (`Dictionary`, `List`) para gerenciar autores e livros em memória

## 🚀 Possíveis melhorias futuras

- [ ] Persistência de dados (arquivo ou banco de dados)
- [ ] Integrar `Saga` ao menu, permitindo agrupar livros por série
- [ ] Busca de livros por autor sem precisar saber o título exato
- [ ] Validação de entradas (evitar erro ao digitar texto onde se espera número)
- [ ] Interface web ou API REST no lugar do terminal

## ✍️ Autora

Feito por [Rafaela A. Quevedo](https://github.com/rafaela-aquevedo), estudante de ADS e futura desenvolvedora back-end, sempre com uma lista de leitura grande demais pra dar conta.
