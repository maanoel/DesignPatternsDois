namespace DesignPatternsDois.Capitulo3
{
  public class Estado
  {
    public Contrato Contrato { get; private set; }

    public Estado(Contrato contrato)
    {
      Contrato = contrato;
    }
  }
}