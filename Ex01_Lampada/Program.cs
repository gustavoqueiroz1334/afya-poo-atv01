using System;

class Program
{
    static void Main()
    {
        Lampada lampada = new Lampada("Philips", "LED");

        Console.WriteLine(lampada);

        lampada.AjustarBrilho(50); 

        lampada.Alternar();
        lampada.AjustarBrilho(50);

        Console.WriteLine(lampada);

        lampada.Alternar(); 
        Console.WriteLine(lampada);

        lampada.Alternar();
        Console.WriteLine(lampada);
    }
}