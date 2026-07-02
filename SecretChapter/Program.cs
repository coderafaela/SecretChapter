Saga poremBruxaLivros = new Saga();
poremBruxaLivros.Nome = "Porém Bruxa";

Livro livro1 = new Livro();
livro1.Titulo = "Porém Bruxa";
livro1.Autore = "Carol Chiovatto";
livro1.Paginas = 320;
livro1.Genero = "Fantasia Urbana";
livro1.Sinopse = "Ísis Rossetti é uma bruxa. Como monitora responsável por atividades sobrenaturais na cidade de São Paulo, ela sabe que não pode intervir em questões humanas. Porém, no cotidiano urbano, as pessoas estão sempre em perigo e é impossível não tentar ajudar.\r\n\r\nQuando Ísis recebe a missão de uma divindade, em meio a casos policiais estranhamente similares e investigações extraoficiais, ela precisará revisitar traumas do passado para proteger os comuns e enfrentar o temido Corregedor.";
livro1.Disponivel = true;

Livro livro2 = new Livro();
livro2.Titulo = "Apenas Humana";
livro2.Autore = "Carol Chiovatto";
livro2.Paginas = 368;
livro2.Genero = "Fantasia Urbana";
livro2.Sinopse = "Ísis Rossetti é bruxa e intuitiva, responsável por investigar ocorrências paranormais na cidade de São Paulo. Ela enfrenta casos complexos, relatórios intermináveis e cobranças constantes, além de um Conselho de telepatas mais interessado em disputas de poder e burocracias do que em proteger os comuns. Para piorar, tem que encarar o trânsito caótico e o metrô lotado, e mal tem tempo de respirar. Afinal, é apenas humana.\n\nQuando um caminhão desgovernado avança o sinal numa avenida movimentada e provoca um acidente fatal, Ísis consegue evitar por pouco que ela e o amigo, Murilo, também saiam feridos. O motorista jura ter visto o fantasma do pai antes de perder o controle e, para a bruxa, esse será o início de uma sequência de mistérios repleto de almas perdidas. Quando os problemas começam a convergir, ela contará com a ajuda de Victor Spencer, corregedor que ela antes achava insuportável, mas que agora não tem tanta certeza.";
livro2.Disponivel = false;

poremBruxaLivros.AdicionarLivro(livro1);
poremBruxaLivros.AdicionarLivro(livro2);

poremBruxaLivros.ExibirSaga();