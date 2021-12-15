namespace DesignPatternsDois.Capitulo7
{
  public class FinalizaPedido : IComando
  {
    private Pedido pedido;

    public FinalizaPedido(Pedido pedido)
    {
      this.pedido = pedido;
    }

    public void Executa()
    {
      pedido.Finaliza();
    }
  }
}
