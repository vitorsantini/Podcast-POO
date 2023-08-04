Episodio ep1 = new(1, "Leonardo, Samir e Heitor", 70);
ep1.AdicionaConvidados("Leonardo");
ep1.AdicionaConvidados("Samir");
ep1.AdicionaConvidados("Heitor");

Episodio ep2 = new(2, "Heitor e Davi", 90);
ep2.AdicionaConvidados("Heitor");
ep2.AdicionaConvidados("Davi");


Podcast podcast = new("Vitor", "Conversa entre amigos");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);

podcast.ExibirDetalhes();