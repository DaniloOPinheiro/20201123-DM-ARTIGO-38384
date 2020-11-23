using System;
using DMA38384.src.Heranca;

namespace DMA38384
{
    public class Menu
    {
        public static void getMenu()
        {
            short opcao = short.Parse(Console.ReadLine());
            
            switch (opcao)
            {
                case 0: System.Environment.Exit(0);
                    break;
                case 1: AdmFisico();
                    break;
                case 2: AdmJuridico();
                    break;
                default: getMenu();
                    break;
            }

            Console.ReadLine();
        }  

            static void AdmFisico()
            {
                Console.Clear();
                Console.Write("Acesso De Usuario Fisíco: ");
                AdminFisico.AcessarAbstracao();
            }

            static void AdmJuridico()
            {
                Console.Clear();
                
                Console.Write("Acesso De Usuario Juridico: ");
                AdminJuridico.AcessarAbstracao();
            }
    }
}