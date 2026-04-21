using System;

class Program
{
    static void Main()
    {
        Conta conta = new Conta(12345, "Gustavo");

        Console.WriteLine(conta);

        conta.Depositar(200);
        Console.WriteLine(conta);

        conta.Sacar(600);
        Console.WriteLine(conta);

        conta.Sacar(200);
        Console.WriteLine(conta);

        conta.Titular = "Gustavo Silva"; 
        Console.WriteLine(conta);
    }
}