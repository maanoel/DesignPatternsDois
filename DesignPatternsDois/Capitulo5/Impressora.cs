using DesignPatternsDois.capitulo4;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDois.Capitulo5
{
  public class Impressora
  {
    public void ImprimeSoma(Soma soma)
    {
      Console.Write("(");
      Console.Write("+");
      //Direita
      Console.Write(")");
    }

    public void ImprimeSubtracao(Subtracao subtracao)
    {
      Console.Write("(");
      //esquerda
      Console.Write("-");
      //Direita
      Console.Write(")");
    }

    public void ImprimeNumero(Numero numero)
    {
      Console.Write(numero.Valor);
    }
  }
}
