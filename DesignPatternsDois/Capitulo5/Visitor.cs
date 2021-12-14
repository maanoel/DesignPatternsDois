using DesignPatternsDois.capitulo4;

namespace DesignPatternsDois.Capitulo5
{
  public interface IVisitor
  {
    void ImprimeSoma(Soma soma);
    void ImprimeSubtracao(Subtracao subtracao);
    void ImprimeNumero(Numero numero);
  }
}
