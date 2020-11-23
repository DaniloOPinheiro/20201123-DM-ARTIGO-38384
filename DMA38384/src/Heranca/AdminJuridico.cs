using System;
using System.Threading;
using DMA38384.src.Abstracao;

namespace DMA38384.src.Heranca
{
    public abstract class AdminJuridico : Usuario
    {
        
        //Aqui instanciamos primeira herança
        public static void AcessarAbstracao()
        {
            System.Console.WriteLine("Acesso Completo da OOP Abstrato");
        }

        //Aqui instanciamos segunda herança
        // public override string setMensagem(string novaMensagem)
        // {
        //     return novaMensagem = "herança";
        // }
    }
}