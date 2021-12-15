using System;

namespace DesignPatternsDois.Capitulo7
{
  class PagaPedido : IComando
  {
    private Pedido pedido;

    public PagaPedido(Pedido pedido)
    {
      this.pedido = pedido;
    }
    public void Executa()
    {
      pedido.Paga();
    }
  }
}
