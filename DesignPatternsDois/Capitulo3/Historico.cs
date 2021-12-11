using System.Collections.Generic;

namespace DesignPatternsDois.Capitulo3
{
  public class Historico
  {
    private IList<Estado> Estados = new List<Estado>();

    public void Adiciona(Estado estado) {
      Estados.Add(estado);
    }

    public Estado Pega(int indice) {
      return Estados[indice];
    }
  }
}
