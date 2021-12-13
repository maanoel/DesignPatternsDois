using DesignPatternsDois.Capitulo5;

namespace DesignPatternsDois.capitulo4
{
  public class Subtracao : IExpressao
  {
    public IExpressao Esquerda { get; private set; }
    public IExpressao Direita { get; private set; }

    public Subtracao(IExpressao esquerda, IExpressao direita)
    {
      this.Esquerda = esquerda;
      this.Direita = direita;
    }

    public int Avalia()
    {
      int valorEsquerda = Esquerda.Avalia();
      int valorDireita = Direita.Avalia();

      return valorEsquerda - valorDireita;
    }

    public void Aceita(Impressora impressora)
    {
      impressora.ImprimeSubtracao(this);
    }
  }
}
