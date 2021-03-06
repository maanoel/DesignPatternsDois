using System;

namespace DesignPatternsDois.Capitulo6
{
  public class MensagemPorAdministrativa : IMensagem
  {
    private string nome;

    public MensagemPorAdministrativa(string nome)
    {
      this.nome = nome;
    }

    public IEnviador Enviador { get; set; }

    public void Envia()
    {
      this.Enviador.Envia(this);
    }

    public string Formata()
    {
      return string.Format("Enviando a mensagem para o adm {0}", nome);
    }
  }
}
