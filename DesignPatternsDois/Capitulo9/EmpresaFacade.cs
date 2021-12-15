using DesignPatternsDois.Capitulo8;

namespace DesignPatternsDois.Capitulo9
{
  public class EmpresaFacade
  {
    public Cliente Buscacliente(string cpf)
    {
      return new ClienteDAO().BuscaPorCpf(cpf);
    }

    public Fatura CriaFatura(Cliente cliente, double valor)
    {
      return new Fatura(cliente, valor);
    }

    public Cobranca GeraCobranca(Tipo tipo, Fatura fatura)
    {
      Cobranca cobranca = new Cobranca(tipo, fatura);
      cobranca.Emite();
      return cobranca;
    }

    public ContatoCliente FazContato(Cliente cliente, Cobranca cobranca)
    {
      ContatoCliente contato = new ContatoCliente(cliente, cobranca);
      contato.Dispara();
      return contato;
    }
  }
}
