Autor robertJacksonBennett = new Autor("Robert Jackson Bennett");

Saga shadowoftheLevithan = new Saga("Shadow of the Leviathan");

Livro livro1 = new Livro(robertJacksonBennett, "O Cálice Contaminado")
{
    Paginas = 448,
    Genero = "Fantasia/Ficção Científica LGBTQ+",
    Traducao = true,
    Sinopse = "Em uma opulenta mansão de Daretana, um oficial imperial de alto escalão morre de repente após uma planta enorme florescer de seu corpo. Completamente fora do comum, todos os indícios do caso apontam para um assassinato, até então sem pista alguma. Agora, a população local corre um grande risco ― mesmo ali, às margens do império, onde existem preocupações maiores por causa dos temíveis leviatãs que invadem as terras de tempos em tempos.\r\n\r\nSó uma detetive de carreira respeitável poderia resolver o caso. Entram em cena Ana Dolabra, de mente afiada e atitudes excêntricas, capaz de solucionar os crimes mais diversos sem nem mesmo sair de casa, e seu novo assistente Dinios Kol, dono de uma habilidade de memorização muito conveniente para uma investigação. No entanto, ambos guardam os próprios enigmas à medida que desvendam uma rede que põe em xeque o próprio Império, caso a misteriosa planta não seja contida.",
};


Livro livro2 = new Livro(robertJacksonBennett, "A Drop of Corruption")
{
    Genero = "Fantasia/Ficção Científica LGBTQ+",
    Traducao = false,
};

Livro livro3 = new Livro(robertJacksonBennett, "A Trade of Blood")
{
    Genero = "Fantasia/Ficção Científica LGBTQ+",
    Traducao = false,
};


shadowoftheLevithan.AdicionarLivro(livro1);
shadowoftheLevithan.AdicionarLivro(livro2);
shadowoftheLevithan.AdicionarLivro(livro3);
robertJacksonBennett.adicionarSaga(shadowoftheLevithan);


robertJacksonBennett.ExibirAutor();
shadowoftheLevithan.ExibirSaga();



