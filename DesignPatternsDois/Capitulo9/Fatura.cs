using DesignPatternsDois.Capitulo8;

namespace DesignPatternsDois.Capitulo9
{
  public class Fatura
  {
    private Cliente cliente;
    private double valor;

    public Fatura(Cliente cliente, double valor)
    {
      this.cliente = cliente;
      this.valor = valor;
    }
  }
}