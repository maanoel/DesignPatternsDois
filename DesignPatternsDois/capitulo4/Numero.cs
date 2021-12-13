using DesignPatternsDois.Capitulo5;

namespace DesignPatternsDois.capitulo4
{
  public class Numero : IExpressao
  {
    public int Valor { get; private set; }

    public Numero(int numero)
    {
      this.Valor = numero;
    }

    public int Avalia()
    {
      return this.Valor;
    }

    public void Aceita(Impressora impressora)
    {
      impressora.ImprimeNumero(this);
    }
  }
}
