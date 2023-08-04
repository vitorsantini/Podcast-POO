class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public string Titulo { get; }
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $" O episodio {Ordem} recebe o titulo {Titulo} e tem duração de {Duracao} min - Convidados: {string.Join(", ", convidados)}";

    public void AdicionaConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}