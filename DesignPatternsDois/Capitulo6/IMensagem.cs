namespace DesignPatternsDois.Capitulo6
{
  public interface IMensagem
  {
    IEnviador Enviador{ get; set; }
    void Envia();
    string Formata();
  }
}
