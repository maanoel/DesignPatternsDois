using DesignPatternsDois.Capitulo8;
using System;

namespace DesignPatternsDois.Capitulo9
{
  public class ContatoCliente
  {
    private Cliente cliente;
    private Cobranca cobranca;

    public ContatoCliente(Cliente cliente, Cobranca cobranca)
    {
      this.cliente = cliente;
      this.cobranca = cobranca;
    }

    internal void Dispara()
    {
      throw new NotImplementedException();
    }
  }
}