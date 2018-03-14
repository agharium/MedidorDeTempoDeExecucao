public class Media
{
    public string nome { get; private set; }
    public double tempo { get; private set; }

    public Media(string nome, double tempo)
    {
        this.nome = nome;
        this.tempo = tempo;
    }

}
