public class Personagem
{
    private string nome;
    private string classe;
    private int nivel;
    private double vidaAtual;
    private double vidaMaxima;

    public Personagem(string nome, string classe)
    {
        this.nome = nome;
        this.classe = classe;
        this.nivel = 1;

        if (classe.ToLower() == "guerreiro")
        {
            vidaMaxima = 150;
        }
        else if (classe.ToLower() == "mago")
        {
            vidaMaxima = 80;
        }
        else
        {
            throw new Exception("Classe inválida!");
        }

        vidaAtual = vidaMaxima;
    }

    public string Nome
    {
        get { return nome; }
    }

    public string Classe
    {
        get { return classe; }
    }

    public int Nivel
    {
        get { return nivel; }
    }

    public double VidaAtual
    {
        get { return vidaAtual; }
    }

    public double VidaMaxima
    {
        get { return vidaMaxima; }
    }

    public void ReceberDano(double pontos)
    {
        if (pontos <= 0) return;

        vidaAtual -= pontos;

        if (vidaAtual < 0)
            vidaAtual = 0;
    }

    public void Curar(double pontos)
    {
        if (vidaAtual == 0)
        {
            Console.WriteLine("Personagem morto. Não pode ser curado.");
            return;
        }

        if (pontos <= 0) return;

        vidaAtual += pontos;

        if (vidaAtual > vidaMaxima)
            vidaAtual = vidaMaxima;
    }

    public void SubirNivel()
    {
        if (vidaAtual == 0)
        {
            Console.WriteLine("Personagem morto. Não pode subir de nível.");
            return;
        }

        nivel++;

        vidaMaxima += vidaMaxima * 0.10; 
        vidaAtual = vidaMaxima; 
    }

    public void Ressuscitar()
    {
        if (vidaAtual > 0)
        {
            Console.WriteLine("O personagem já está vivo.");
            return;
        }

        vidaAtual = vidaMaxima;
        Console.WriteLine("Personagem ressuscitado!");
    }

    public override string ToString()
    {
        return $"{nome} ({classe}) - Lvl {nivel} - HP: {vidaAtual:F0}/{vidaMaxima:F0}";
    }
}