using System;

class Program
{
    static void Main()
    {
        Cofre cofre = new Cofre("Gustavo", "1234");

        Console.WriteLine(cofre);

        cofre.Abrir("0000");
        cofre.Abrir("1111");
        cofre.Abrir("2222"); 

        cofre.Abrir("1234");

        Console.WriteLine(cofre);

        cofre.ResetarCofre();

        cofre.Abrir("1234"); 

        cofre.AlterarSenha("1234", "9999");

        Console.WriteLine(cofre);
    }
}