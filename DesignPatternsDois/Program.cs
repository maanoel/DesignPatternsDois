using DesignPatternsDois.Capitulo2;
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
    } 
  }
}
