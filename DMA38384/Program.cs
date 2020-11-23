using System;

namespace DMA38384
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine(
                    "Boas Vindas ao Artigo 38384, da Plataforma DEVMEDIA" + "OOP com c#"
                );
            Console.WriteLine("-----------------------------------------------------------");
            
            Console.WriteLine(
                "Escolha uma dos acessos: "  +  " 0 - Sair" + " 1 - AdmFisíco" + " 2 - AdmJuridico"
            );

            Menu.getMenu();

        }                                         
    }
}
