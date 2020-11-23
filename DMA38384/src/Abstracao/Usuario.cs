using System.Net.Http;
using System;

namespace DMA38384.src.Abstracao
{
    public abstract class Usuario
    {
        // private string mensagem;
        public void AcessarAbstracao()
        {
            System.Console.WriteLine("Acesso do OOP Abstrato");
        }
        
        // public string getMensagem(string mensagem)
        // {
        //     return this.mensagem;
        // }

        // public void setMensagem(string _mensagem)
        // {
                // this.mensagem = _mensagem;
        //     get { return mensagem; }
        //     set { mensagem =  value; }
        // }

        // if(!novaMensagens)
        //  System.Console.WriteLine("Não identificamos uma mensagem!");
        // else
        //  return setMensagem("");
    }
}