namespace DesignPatternsDois.Capitulo6
{
  class MensagemCliente: IMensagem
  {
    private string nome;

    public MensagemCliente(string nome)
    {
      this.nome = nome;
    }

    public IEnviador Enviador { get; set; }

    public void Envia() {
      this.Enviador.Envia(this);
    }

    public string Formata()
    {
      return string.Format("Enviando a mensagem para o adm {0}", nome);
    }
  }
}
