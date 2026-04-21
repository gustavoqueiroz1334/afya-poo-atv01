using System;

class Program
{
    static void Main()
    {
        Personagem p = new Personagem("Arthas", "Guerreiro");

        Console.WriteLine(p);

        p.ReceberDano(50);
        Console.WriteLine(p);

        p.Curar(30);
        Console.WriteLine(p);

        p.SubirNivel();
        Console.WriteLine(p);

        p.ReceberDano(1000); 
        Console.WriteLine(p);

        p.Curar(50);

        p.Ressuscitar();
        Console.WriteLine(p);
    }
}