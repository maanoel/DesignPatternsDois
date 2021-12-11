using DesignPatternsDois.Capitulo2;
using DesignPatternsDois.Capitulo3;
using System;
using System.Collections.Generic;
using System.Data;

namespace DesignPatternsDois
{
  class Program
  {
    static void Main(string[] args)
    {
      //ConnectionString
      IDbConnection conexao =  ConnectionFactory.ObterConexao();
      IDbCommand comando = conexao.CreateCommand();
      comando.CommandText = "select * from tabela";
      Console.WriteLine("Hello World!");

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

      //Memento pattern
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
  }
}
