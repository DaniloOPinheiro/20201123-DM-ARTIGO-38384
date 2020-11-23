using System.Threading;
using System;
using DMA38384.src.Abstracao;

namespace DMA38384.src.Polimorfismo
{
    public abstract class AdminJuridico : Abstracao.Usuario
    {
        // public override void AcessarAbstracao()
        // {
        //     //Aqui entra a questão do Polimorfismo
        //     throw new NotImplementedException("Acesso Completo ao Sistema");
        // }
    }
}