public class Lampada
{
    private string marca;
    private readonly string tecnologia; 
    private bool ligada;
    private int brilho; // 0 a 100

    public Lampada(string marca, string tecnologia)
    {
        this.marca = marca;
        this.tecnologia = tecnologia;
        this.ligada = false;
        this.brilho = 100;
    }

    public string Marca
    {
        get { return marca; }
    }

    public string Tecnologia
    {
        get { return tecnologia; }
    }

    public bool Ligada
    {
        get { return ligada; }
    }

    public int Brilho
    {
        get { return brilho; }
    }

    public void Alternar()
    {
        ligada = !ligada;
    }

    public void AjustarBrilho(int novoBrilho)
    {
        if (!ligada)
        {
            Console.WriteLine("Erro: A lâmpada precisa estar ligada para ajustar o brilho.");
            return;
        }

        if (novoBrilho >= 0 && novoBrilho <= 100)
        {
            brilho = novoBrilho;
        }
        else
        {
            Console.WriteLine("Erro: O brilho deve estar entre 0 e 100.");
        }
    }

    public override string ToString()
    {
        return $"Marca: {marca}, Tecnologia: {tecnologia}, Estado: {(ligada ? "Ligada" : "Desligada")}, Brilho: {brilho}%";
    }
}