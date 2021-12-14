using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDois.Capitulo6
{
  public class EnviaPorEmail : IEnviador
  {
    public void Envia(IMensagem mensagem)
    {
      Console.WriteLine("Enviando a mensagem por e-mail");
      Console.WriteLine(mensagem.Formata());
    }
  }
}
