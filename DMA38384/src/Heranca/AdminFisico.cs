using System;
using System.Threading;
using DMA38384.src.Abstracao;

namespace DMA38384.src.Heranca
{
    public abstract class AdminFisico : Usuario
    {
        
        //Aqui instanciamos primeira herança
        public static void AcessarAbstracao()
        {
            System.Console.WriteLine("Acesso Parcial do OOP Abstrato");
        }
    }
}