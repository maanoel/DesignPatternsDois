using System;
using System.Collections.Generic;

namespace DesignPatternsDois.Capitulo2
{
  public class Piano
  {
    public void Toca(IList<INota> musica) {
      foreach(var nota in musica) {
        Console.Beep(nota.Frequencia, 300);
      }
    }
  }
}
