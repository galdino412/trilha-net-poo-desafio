using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("### Testando Smartphone Nokia ###");
        
        // Criando um objeto Nokia
        Smartphone nokia = new Nokia("11999999999", "Nokia Tijolão", "1234567890", 64);
        
        // Testando funcionalidades
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        
        Console.WriteLine("\n--------------------------\n");

        Console.WriteLine("### Testando Smartphone iPhone ###");

        // Criando um objeto iPhone
        Smartphone iphone = new Iphone("11988888888", "iPhone 15 Pro", "0987654321", 256);
        
        // Testando funcionalidades
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine("\n--------------------------\n");

        Console.WriteLine("Teste finalizado com sucesso!");
    }
}
// TODO: Realizar os testes com as classes Nokia e Iphone