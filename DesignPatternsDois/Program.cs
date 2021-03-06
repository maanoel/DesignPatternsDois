using DesignPatternsDois.Capitulo2;
using DesignPatternsDois.Capitulo3;
using DesignPatternsDois.capitulo4;
using DesignPatternsDois.Capitulo5;
using DesignPatternsDois.Capitulo6;
using DesignPatternsDois.Capitulo7;
using DesignPatternsDois.Capitulo8;
using DesignPatternsDois.Capitulo9;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

namespace DesignPatternsDois
{
  class Program
  {
    static void Main(string[] args)
    {
      IExpressao soma = Interpreter();
      Memento();
      Flyweight();
      ConnectionString();
      Visitor(soma);
      Bridge();
      Command();
      Adapter();
      Facade();

    }

    private static IExpressao Interpreter()
    {
      //INTERPRETER é utilizado em uma árvore de expressoes matemáticas E DSL
      IExpressao direita = new Soma(new Soma(new Numero(1), new Numero(100)), new Subtracao(new Numero(1), new Numero(100)));
      IExpressao esquerda = new Subtracao(new Numero(1), new Numero(10));
      IExpressao soma = new Soma(esquerda, direita);

      Console.WriteLine(soma.Avalia());

      //Existe uma API PRONTA, EXPRESSION para representar expressões complexas
      //INTERPRETER no C# abaixo.
      Expression somaExpression = Expression.Add(Expression.Constant(1), Expression.Constant(100));
      Func<int> funcao = Expression.Lambda<Func<int>>(somaExpression).Compile();
      Console.WriteLine(funcao());
      //
      return soma;
    }

    private static void Memento()
    {
      //Memento pattern
      //Uma observação sobre esse padrão..
      //O momento dependendo do contexto, pode levar uso extremo da memória, dependendo 
      //do tipo de objeto que está se querendo guardar o momento do estado.
      //Para resolver esse problema e diminuir o uso de memória
      //Podemos salvar apenas as propriedades que iremos usar após salvar o estado.

      Historico historico = new Historico();
      Contrato contrato = new Contrato(DateTime.Now, "Vitor", TipoContrato.Novo);

      historico.Adiciona(contrato.SalvaEstado());

      Console.WriteLine(contrato.Tipo);

      contrato.Avancar();

      historico.Adiciona(contrato.SalvaEstado());

      contrato.Avancar();

      historico.Adiciona(contrato.SalvaEstado());

      Console.WriteLine(contrato.Tipo);
      Console.WriteLine(historico.Pega(0).Contrato.Tipo);
      Console.WriteLine(historico.Pega(1).Contrato.Tipo);
      Console.WriteLine(historico.Pega(2).Contrato.Tipo);
    }

    private static void Flyweight()
    {
      //Flyweight Pattern
      NotasMusicais notas = new NotasMusicais();
      IList<INota> musica = new List<INota>() {
        notas.Pega("do"),
        notas.Pega("re"),
        notas.Pega("mi"),
        notas.Pega("fa"),
        notas.Pega("sol"),
        notas.Pega("la"),
        notas.Pega("si"),
      };

      Piano piano = new Piano();
      piano.Toca(musica);
    }

    private static void ConnectionString()
    {
      //ConnectionString
      IDbConnection conexao = ConnectionFactory.ObterConexao();
      IDbCommand comando = conexao.CreateCommand();
      comando.CommandText = "select * from tabela";
      Console.WriteLine("Hello World!");
    }

    private static void Visitor(IExpressao soma)
    {
      ImpressoraVisitor impressora = new ImpressoraVisitor();
      soma.Aceita(impressora);
    }

    private static void Bridge()
    {
      ///Bridge, utilizando a composição de classes, estou fazendo 
      ///uma ponte entre as interfaces
      ///Esse padrão é usado toda vez que temos uma hierarquia de classes que 
      ///tenham uma ou mais responsabilidades,

      IMensagem mensagemEmail = new MensagemCliente("Vitor brito: Aqui está sua recompensa de 100000000");
      IMensagem mensagemSMS = new MensagemPorAdministrativa("Vitor brito: Aqui está sua recompensa de 100000000");

      IEnviador enviadorEmail = new EnviaPorEmail();
      IEnviador enviadorSMS = new EnviaPorSMS();

      mensagemEmail.Enviador = enviadorEmail;
      mensagemEmail.Envia();

      mensagemSMS.Enviador = enviadorSMS;
      mensagemSMS.Envia();
    }


    private static void Command()
    {
      //COMMAND
      FilaDeTrabalho fila = new FilaDeTrabalho();
      Pedido pedido1 = new Pedido("nadine", 2300.00);
      Pedido pedido2 = new Pedido("vitor", 2200.00);

      fila.Adiciona(new PagaPedido(pedido1));
      fila.Adiciona(new PagaPedido(pedido2));
      fila.Adiciona(new FinalizaPedido(pedido1));

      fila.Processa();
    }

    private static void Adapter()
    {

      //Utilizamos o adapter sempre que quisermos
      //adaptar um código de uma lib ou de um sistema legado

      Cliente cliente = new Cliente();

      cliente.Nome = "Vitor";
      cliente.Endereco = "Rua vergueiro";
      cliente.DataNascimento = DateTime.Now;

      string xml = new GeradorDeXml().GeraXml(cliente);

      Console.WriteLine(xml);
    }

    private static void Facade()
    {
      //variáveis globais não são boas, então os singleton é um anti pattern
      string cpf = "1234";
      EmpresaFacade facade = new EmpresaFacadaSingleton().Instancia;
      Cliente cliente = facade.BuscaCliente(cpf);
      //
    }

  }
}
