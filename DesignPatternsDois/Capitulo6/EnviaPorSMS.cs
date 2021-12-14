using System;

namespace DesignPatternsDois.Capitulo6
{
  class EnviaPorSMS : IEnviador
  {
    public void Envia(IMensagem mensagem)
    {
      Console.Write("Enviando a mensagem por SMS");
      Console.WriteLine(mensagem.Formata());
    }
  }
}
