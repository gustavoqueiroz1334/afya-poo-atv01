public class Conta
{
    private readonly int numero;
    private string titular;
    private double saldo;
    private double limite;

    public Conta(int numero, string titular)
    {
        this.numero = numero;
        this.titular = titular;
        this.saldo = 0;
        this.limite = 500;
    }

    public int Numero
    {
        get { return numero; }
    }

    public string Titular
    {
        get { return titular; }
        set { titular = value; }
    }

    public double Saldo
    {
        get { return saldo; }
    }

    public double Limite
    {
        get { return limite; }
    }

    public double SaldoTotal
    {
        get { return saldo + limite; }
    }

    public string StatusConta
    {
        get { return saldo < 0 ? "Negativo" : "Positivo"; }
    }

    public bool Depositar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor inválido para depósito.");
            return false;
        }

        saldo += valor;
        return true;
    }

    public bool Sacar(double valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("Valor inválido para saque.");
            return false;
        }

        if (valor <= SaldoTotal)
        {
            saldo -= valor;
            return true;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
            return false;
        }
    }

    public override string ToString()
    {
        return $"Conta: {numero} | Titular: {titular} | Saldo: {saldo:F2} | Limite: {limite:F2} | Status: {StatusConta}";
    }
}