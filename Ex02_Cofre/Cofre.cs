public class Cofre
{
    private string dono;
    private string senha;
    private bool estaAberto;
    private int tentativasErradas;

    public Cofre(string dono, string senha)
    {
        this.dono = dono;
        this.senha = senha;
        this.estaAberto = false;
        this.tentativasErradas = 0;
    }

    public string Dono
    {
        get { return dono; }
    }

    public bool EstaAberto
    {
        get { return estaAberto; }
    }

    public int TentativasErradas
    {
        get { return tentativasErradas; }
    }

    public void Abrir(string senhaInformada)
    {
        if (tentativasErradas >= 3)
        {
            Console.WriteLine("Cofre bloqueado!");
            return;
        }

        if (senhaInformada == senha)
        {
            estaAberto = true;
            tentativasErradas = 0;
            Console.WriteLine("Cofre aberto com sucesso!");
        }
        else
        {
            tentativasErradas++;
            Console.WriteLine("Senha incorreta!");
        }
    }

    public void Fechar()
    {
        estaAberto = false;
        Console.WriteLine("Cofre fechado.");
    }

    public void AlterarSenha(string senhaAntiga, string novaSenha)
    {
        if (!estaAberto)
        {
            Console.WriteLine("Erro: o cofre precisa estar aberto para alterar a senha.");
            return;
        }

        if (senhaAntiga != senha)
        {
            Console.WriteLine("Erro: senha antiga incorreta.");
            return;
        }

        senha = novaSenha;
        Console.WriteLine("Senha alterada com sucesso!");
    }

    public void ResetarCofre()
    {
        tentativasErradas = 0;
        Console.WriteLine("Cofre resetado.");
    }

    public override string ToString()
    {
        return $"Dono: {dono}, Estado: {(estaAberto ? "Aberto" : "Fechado")}, Tentativas Erradas: {tentativasErradas}";
    }
}